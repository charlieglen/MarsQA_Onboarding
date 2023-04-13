Feature: EducationFeature

As a seller, I would like to sign up to MarsQA portal and create my profile
So people seeking for some skills can look into my details.

Scenario Outline: 01) Add education record on my profile
	Given I add a new education record, '<Institution Name>', '<Institution Country>', '<Title>', '<Degree>', '<Year>'
	Then The new education record should be added successfully, '<Institution Name>', '<Institution Country>', '<Title>', '<Degree>', '<Year>'

Examples:
| Institution Name | Institution Country | Title | Degree               | Year |
| USM              | Philippines        | B.Sc  | Computer Engineering | 2010 |
| USEP             | Canada             | BFA   | Astronaut            | 2018 |

Scenario:  02) Edit education record on my profile
	Given I edit an existing education record
	Then The new education record should be updated successfully

Scenario:  03) Delete education record on my profile
	Given I delete an existing education record
	Then The new education record should be deleted successfully
