Feature: Create Zoho Sales Order

@zoho
 Scenario: Get Zoho Auth Token
	Given I have a 'POSTAUTH' API 'Token'
	When I send API request for 'zohoauth'
	# Then I fetch the access token
	Then I validate status code 200