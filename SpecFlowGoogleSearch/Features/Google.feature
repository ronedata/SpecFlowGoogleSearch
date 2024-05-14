Feature: Google

A short summary of the feature

@tag1
Scenario: Google Search Result
	Given Go to google page
	When I search for "specflow sample test c#"
	Then I should see title "Bing"