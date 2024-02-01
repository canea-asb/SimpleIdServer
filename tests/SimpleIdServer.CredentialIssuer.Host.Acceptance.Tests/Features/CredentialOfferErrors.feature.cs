﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.CredentialIssuer.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class CredentialOfferErrorsFeature : object, Xunit.IClassFixture<CredentialOfferErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "CredentialOfferErrors.feature"
#line hidden
        
        public CredentialOfferErrorsFeature(CredentialOfferErrorsFeature.FixtureData fixtureData, SimpleIdServer_CredentialIssuer_Host_Acceptance_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CredentialOfferErrors", "\tCheck the errors returned by the credential_offer endpoint", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="grants parameter is required")]
        [Xunit.TraitAttribute("FeatureTitle", "CredentialOfferErrors")]
        [Xunit.TraitAttribute("Description", "grants parameter is required")]
        public void GrantsParameterIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("grants parameter is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table31 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table31.AddRow(new string[] {
                            "Authorization",
                            "Bearer AT"});
#line 5
 testRunner.When("execute HTTP POST JSON request \'http://localhost/credential_offer\'", ((string)(null)), table31, "When ");
#line hidden
#line 9
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.And("JSON \'error\'=\'invalid_credential_offer_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("JSON \'error_description\'=\'the parameter grants is missing\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="credential_configuration_ids parameter is required")]
        [Xunit.TraitAttribute("FeatureTitle", "CredentialOfferErrors")]
        [Xunit.TraitAttribute("Description", "credential_configuration_ids parameter is required")]
        public void Credential_Configuration_IdsParameterIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("credential_configuration_ids parameter is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table32 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table32.AddRow(new string[] {
                            "Authorization",
                            "Bearer AT"});
                table32.AddRow(new string[] {
                            "grants",
                            "[\"grant\"]"});
#line 16
 testRunner.When("execute HTTP POST JSON request \'http://localhost/credential_offer\'", ((string)(null)), table32, "When ");
#line hidden
#line 21
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
 testRunner.And("JSON \'error\'=\'invalid_credential_offer_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("JSON \'error_description\'=\'the parameter credential_configuration_ids is missing\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="sub parameter is required")]
        [Xunit.TraitAttribute("FeatureTitle", "CredentialOfferErrors")]
        [Xunit.TraitAttribute("Description", "sub parameter is required")]
        public void SubParameterIsRequired()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("sub parameter is required", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 27
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table33 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table33.AddRow(new string[] {
                            "Authorization",
                            "Bearer AT"});
                table33.AddRow(new string[] {
                            "grants",
                            "[\"grant\"]"});
                table33.AddRow(new string[] {
                            "credential_configuration_ids",
                            "[\"id\"]"});
#line 28
 testRunner.When("execute HTTP POST JSON request \'http://localhost/credential_offer\'", ((string)(null)), table33, "When ");
#line hidden
#line 34
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
 testRunner.And("JSON \'error\'=\'invalid_credential_offer_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("JSON \'error_description\'=\'the parameter sub is missing\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="grant must be valid")]
        [Xunit.TraitAttribute("FeatureTitle", "CredentialOfferErrors")]
        [Xunit.TraitAttribute("Description", "grant must be valid")]
        public void GrantMustBeValid()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("grant must be valid", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 40
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table34 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table34.AddRow(new string[] {
                            "Authorization",
                            "Bearer AT"});
                table34.AddRow(new string[] {
                            "grants",
                            "[\"grant\"]"});
                table34.AddRow(new string[] {
                            "credential_configuration_ids",
                            "[\"id\"]"});
                table34.AddRow(new string[] {
                            "sub",
                            "user"});
#line 41
 testRunner.When("execute HTTP POST JSON request \'http://localhost/credential_offer\'", ((string)(null)), table34, "When ");
#line hidden
#line 48
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 51
 testRunner.And("JSON \'error\'=\'invalid_credential_offer_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And("JSON \'error_description\'=\'the grant types grant are not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="grant must be supported")]
        [Xunit.TraitAttribute("FeatureTitle", "CredentialOfferErrors")]
        [Xunit.TraitAttribute("Description", "grant must be supported")]
        public void GrantMustBeSupported()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("grant must be supported", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 54
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table35 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table35.AddRow(new string[] {
                            "Authorization",
                            "Bearer AT"});
                table35.AddRow(new string[] {
                            "grants",
                            "[\"grant\"]"});
                table35.AddRow(new string[] {
                            "credential_configuration_ids",
                            "[\"id\"]"});
                table35.AddRow(new string[] {
                            "sub",
                            "user"});
#line 55
 testRunner.When("execute HTTP POST JSON request \'http://localhost/credential_offer\'", ((string)(null)), table35, "When ");
#line hidden
#line 62
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.And("JSON \'error\'=\'invalid_credential_offer_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.And("JSON \'error_description\'=\'the grant types grant are not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="credential configuration must exists")]
        [Xunit.TraitAttribute("FeatureTitle", "CredentialOfferErrors")]
        [Xunit.TraitAttribute("Description", "credential configuration must exists")]
        public void CredentialConfigurationMustExists()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("credential configuration must exists", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 68
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table36 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table36.AddRow(new string[] {
                            "Authorization",
                            "Bearer AT"});
                table36.AddRow(new string[] {
                            "grants",
                            "[\"authorization_code\"]"});
                table36.AddRow(new string[] {
                            "credential_configuration_ids",
                            "[\"id\"]"});
                table36.AddRow(new string[] {
                            "sub",
                            "user"});
#line 69
 testRunner.When("execute HTTP POST JSON request \'http://localhost/credential_offer\'", ((string)(null)), table36, "When ");
#line hidden
#line 76
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 79
 testRunner.And("JSON \'error\'=\'invalid_credential_offer_request\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
 testRunner.And("JSON \'error_description\'=\'the credentials id are not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                CredentialOfferErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                CredentialOfferErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
