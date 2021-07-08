﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using SimpleIdServer.OAuth.Domains;
using SimpleIdServer.OAuth.DTOs;
using SimpleIdServer.OAuth.Exceptions;
using SimpleIdServer.OAuth.Extensions;
using SimpleIdServer.OAuth.Persistence;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleIdServer.OAuth.Api.Management.Handlers
{
    public interface IAddOAuthUserBySCIMIdHandler
    {
        Task<bool> Handle(JObject jObj, CancellationToken cancellationToken);
    }

    public class AddOAuthUserBySCIMIdHandler : IAddOAuthUserBySCIMIdHandler
    {
        private readonly IOAuthUserRepository _oauthUserRepository;
        private readonly ILogger<AddOAuthUserBySCIMIdHandler> _logger;

        public AddOAuthUserBySCIMIdHandler(
            IOAuthUserRepository oauthUserRepository,
            ILogger<AddOAuthUserBySCIMIdHandler> logger)
        {
            _oauthUserRepository = oauthUserRepository;
            _logger = logger;
        }

        public virtual async Task<bool> Handle(JObject jObj, CancellationToken cancellationToken)
        {
            var parameter = ExtractParameter(jObj);
            var user = await _oauthUserRepository.FindOAuthUserByClaim(SimpleIdServer.Jwt.Constants.UserClaims.ScimId, parameter.ScimId, cancellationToken);
            if (user != null)
            {
                _logger.LogError("User cannot be added because it already exists");
                throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.USER_ALREADY_EXISTS, parameter.ScimId));
            }

            var newUser = OAuthUser.Create(parameter.Content.GetStr(SimpleIdServer.Jwt.Constants.UserClaims.Subject));
            UpdateUser(parameter.Content, newUser);
            await _oauthUserRepository.Add(newUser, cancellationToken);
            await _oauthUserRepository.SaveChanges(cancellationToken);
            _logger.LogInformation($"the user {parameter.ScimId} has been added");
            return true;
        }
        protected virtual AddUser ExtractParameter(JObject jObj)
        {
            var scimId = jObj.SelectToken(AddUserParameters.SCIM_ID);
            if (scimId == null)
            {
                _logger.LogError($"the parameter '{AddUserParameters.SCIM_ID}' is required");
                throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.MISSING_PARAMETER, AddUserParameters.SCIM_ID));
            }

            var content = jObj.SelectToken(AddUserParameters.CONTENT);
            if (content == null)
            {
                _logger.LogError($"the parameter '{AddUserParameters.CONTENT}' is required");
                throw new OAuthException(ErrorCodes.INVALID_REQUEST, string.Format(ErrorMessages.MISSING_PARAMETER, AddUserParameters.CONTENT));
            }

            return new AddUser(scimId.ToString(), content as JObject);
        }

        protected virtual void UpdateUser(JObject jObj, OAuthUser user)
        {
            if (jObj.ContainsKey(SimpleIdServer.Jwt.Constants.OAuthClaims.Claims))
            {
                var claims = jObj[SimpleIdServer.Jwt.Constants.OAuthClaims.Claims] as JObject;
                foreach (var kvp in claims)
                {
                    user.UpdateClaim(kvp.Key, kvp.Value.ToString());
                }
                return;
            }
        }

        protected class AddUser
        {
            public AddUser(string scimId, JObject content)
            {
                ScimId = scimId;
                Content = content;
            }

            public string ScimId { get; set; }
            public JObject Content { get; set; }
        }
    }
}
