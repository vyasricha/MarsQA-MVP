﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MarsQA_1.FeatureFile
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Languages tab")]
    public partial class LanguagesTabFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Language.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Languages tab", "\tIn order to update my profile\r\n\tAs a skill trader\r\n\tI want to add, edit and dele" +
                    "te language", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to add new language")]
        [NUnit.Framework.CategoryAttribute("autoamte")]
        public virtual void CheckIfUserIsAbleToAddNewLanguage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add new language", null, new string[] {
                        "autoamte"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
testRunner.Given("I am on the Languages tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
testRunner.When("I click on Add New Button and I add new language and level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
testRunner.Then("new language and level should display on my listing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to edit selected language")]
        [NUnit.Framework.CategoryAttribute("automate")]
        public virtual void CheckIfUserIsAbleToEditSelectedLanguage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to edit selected language", null, new string[] {
                        "automate"});
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
testRunner.Given("The language is alrady exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
testRunner.When("I click on edit icon and edit selected language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
testRunner.Then("the edited language should display on my listings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to delete the language")]
        [NUnit.Framework.CategoryAttribute("automate")]
        public virtual void CheckIfUserIsAbleToDeleteTheLanguage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to delete the language", null, new string[] {
                        "automate"});
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 20
testRunner.Given("The language is alrady exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
testRunner.When("I click on delete icon and delete selected language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
testRunner.Then("the deleted language should not display on my listings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to add more than four languages")]
        [NUnit.Framework.CategoryAttribute("manual")]
        public virtual void CheckIfUserIsAbleToAddMoreThanFourLanguages()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add more than four languages", null, new string[] {
                        "manual"});
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 26
testRunner.Given("I have four languages in my list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
testRunner.When("I try to add fiveth language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
testRunner.Then("Add New button should not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to add duplicate language")]
        [NUnit.Framework.CategoryAttribute("manual")]
        public virtual void CheckIfUserIsAbleToAddDuplicateLanguage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add duplicate language", null, new string[] {
                        "manual"});
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 32
testRunner.Given("The language is already in my list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
testRunner.When("I try to add the same language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
testRunner.Then("The alert message \"Duplicate data\" should display", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
testRunner.And("Language does not entered", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to add language without entering the value in language fiel" +
            "d")]
        [NUnit.Framework.CategoryAttribute("manual")]
        public virtual void CheckIfUserIsAbleToAddLanguageWithoutEnteringTheValueInLanguageField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add language without entering the value in language fiel" +
                    "d", null, new string[] {
                        "manual"});
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 39
testRunner.Given("I am on the Languages tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
testRunner.When("I clicked on Add New button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 41
testRunner.And("I select the language level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
testRunner.But("I did not enter language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 43
testRunner.Then("The alert message \"Please enter language and level\" should display", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
testRunner.And("New language does not entered", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to add language without selecting the language level")]
        [NUnit.Framework.CategoryAttribute("manual")]
        public virtual void CheckIfUserIsAbleToAddLanguageWithoutSelectingTheLanguageLevel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add language without selecting the language level", null, new string[] {
                        "manual"});
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 48
testRunner.Given("I am on the Languages tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
testRunner.When("I clicked on Add New button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
testRunner.And("I entered the new language", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
testRunner.But("I did not select the language level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line 52
testRunner.Then("The alert message \"Please enter language and level\" should display", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
testRunner.And("New language does not entered", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check if user is able to add language without entering value in language field an" +
            "d selecting the language level")]
        [NUnit.Framework.CategoryAttribute("manual")]
        public virtual void CheckIfUserIsAbleToAddLanguageWithoutEnteringValueInLanguageFieldAndSelectingTheLanguageLevel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check if user is able to add language without entering value in language field an" +
                    "d selecting the language level", null, new string[] {
                        "manual"});
#line 56
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 57
testRunner.Given("I am on the Languages tab", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 58
testRunner.When("I clicked on Add New button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 59
testRunner.And("I did not entered the new language and select the language level", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
testRunner.Then("The alert message \"Please enter language and level\" should display", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
testRunner.And("language does not entered", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
