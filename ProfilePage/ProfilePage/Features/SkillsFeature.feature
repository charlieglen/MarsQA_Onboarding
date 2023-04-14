Feature: SkillsFeature

As a seller, I would like to sign up to MarsQA portal and add my skills.
So people seeking for some skills can look into it.

@skillsBinding
Scenario: Add skills on my profile
	Given I add a new skill
	Then The new skill should be added successfully