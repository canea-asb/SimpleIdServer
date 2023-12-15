﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using SimpleIdServer.Did.Crypto;
using SimpleIdServer.Did.Models;

namespace SimpleIdServer.Did.Builders;

public interface IVerificationMethodBuilder
{
    string JSONLDContext { get; }
    string Type { get; }
    IdentityDocumentVerificationMethod Build(IdentityDocument idDocument, ISignatureKey signatureKey);
}
