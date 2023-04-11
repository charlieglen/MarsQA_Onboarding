Feature: DescriptionFeature

A short summary of the feature

@descriptionBinding
Scenario: Add description on my profile
	Given I launch and log into MarsQA portal successfully
	When I add a new description
	Then The new description should be added successfully
