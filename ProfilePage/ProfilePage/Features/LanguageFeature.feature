Feature: LanguageFeature

As a seller, I would like to sign up to MarsQA portal and add languages that I know.
So people seeking for some skills can look into it.

@languageBinding
Scenario: Add language on my profile
	Given I add a new language
	Then The new language should be added successfully