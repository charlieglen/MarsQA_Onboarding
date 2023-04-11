Feature: CertificationFeature

A short summary of the feature

@certificationBinding
Scenario: Add certification details on my profile
	Given I launch and log into MarsQA portal successfully
	When I add a new certification details
	Then The new certification details should be added successfully
