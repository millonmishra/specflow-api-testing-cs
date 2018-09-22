Feature: API Application Test

@systemtest
Scenario: Get todo List API Response using given end point
	Given I have a endpoint todos
	When I call get mthod for this api
	Then i get response in json format


Scenario: Get a single todo API Response using given end point
	Given I have a endpoint todos
	When I call get mthod for this api using 3
	Then i get response in json format
