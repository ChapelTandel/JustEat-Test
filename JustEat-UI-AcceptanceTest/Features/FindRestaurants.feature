Feature: Use the website to find restaurants
        So that I can order food
        As a hungry customer
        I want to be able to find restaurants in my area
 
 Scenario: Search for restaurants in an area
        Given I want food in "AR51 1AA"
        When I search for restaurants
        Then I should see some restaurants in "AR51 1AA"


 Scenario Outline: Post code can not be blank or incomplete
		Given I am on homepage 
		When I search for restaurats in "<postcode>"
		Then I should see validation "<message>"
		
		Examples: 
		| postcode | message                             |
		|          | Please enter a postcode             |
		| HA       | Please enter a full, valid postcode |

Scenario: Menu item can be added to the basket 
		Given I search and select a restaurant in "HA7 2AB"
		When I add an item to the basket 
		Then I should see the item in the basket 

