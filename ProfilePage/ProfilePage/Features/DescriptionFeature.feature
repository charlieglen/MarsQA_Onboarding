Feature: DescriptionFeature

As a seller, I would like to sign up to MarsQA portal and add a short description.
So people seeking for some skills can look into it.

@descriptionBinding
Scenario: Add description on my profile
	Given I add a new description
	Then The new description should be added successfully
