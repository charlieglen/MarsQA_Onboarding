Feature: LanguageFeature

A short summary of the feature

@languageBinding
Scenario: Add language on my profile
	Given I launch and log into MarsQA portal successfully
	When I add a new language
	Then The new language should be added successfully