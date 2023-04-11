Feature: SkillsFeature

A short summary of the feature

@skillsBinding
Scenario: Add skills on my profile
	Given I launch and log into MarsQA portal successfully
	When I add a new skill
	Then The new skill should be added successfully