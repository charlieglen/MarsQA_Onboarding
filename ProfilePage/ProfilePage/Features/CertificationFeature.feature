Feature: CertificationFeature

As a seller, I would like to sign up to MarsQA portal and add my certification details
So people seeking for some skills can look into it.

@certificationBinding
Scenario: Add certification details on my profile
	Given I add a new certification details
	Then The new certification details should be added successfully
