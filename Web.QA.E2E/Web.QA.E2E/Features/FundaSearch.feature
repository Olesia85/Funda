Feature: FundaSearch
	Search functionality


  Scenario: Search by place and price fore sale
	Given I navigate to 'Main' page
	When I enter 'Diemen' in to the address field
	And I select price '50000' from the drop-down 'From, for by'
	And I select price '75000' from the drop-down 'To, for buy'
	And I click 'Search button'
	Then I navigate to 'Search' page
    And I see range '€ 50,000 - € 75,000 ()' in filter parameters
	And I see right price '€ 50,000 k.k.' and address '1111 HJ Diemen' in first search result


  Scenario: Search by place and price for rent
    Given I navigate to 'Main' page
	When I click 'For rent button'
	Then I enter 'Amsterdam' in to the address field
	And I select price '1000' from the drop-down 'From, for rent'
	And I select price '1500' from the drop-down 'To, for rent'
	And I click 'Search button'
    And I see range '€ 1.000 - € 1.500 ()' in filter parameters
    And I see right price '€ 1.450 /mnd' and address '1083 HH Amsterdam' in first search result


  Scenario: Search by place and price for rent, then by number of rooms and floor area 
    Given I navigate to 'Main' page
	When I click 'For rent button'
	Then I enter 'Amsterdam' in to the address field
	And I select price '1000' from the drop-down 'From, for rent'
	And I select price '1500' from the drop-down 'To, for rent'
	And I click 'Search button'
    When I click '4+ rooms radiobutton'
    And I click '75+ m2'
	Then I see range '€ 1.000 - € 1.500 ()' in filter parameters
	And I see '4+ kamers (Aantal kamers)' in  'number of rooms' filter parameters
	And I see '75+ m² (Woonoppervlakte)' in  'floor area' filter parameters
	And I see right number of rooms '4 kamers' and floor area '85 m²' in first search result


  Scenario: Search by new construction
    Given I navigate to 'Main' page
	When I click 'New construction button'
	Then I enter 'Utrecht' in to the address field and press return button
    And I see right place '3545 EA Utrecht' in first search result

