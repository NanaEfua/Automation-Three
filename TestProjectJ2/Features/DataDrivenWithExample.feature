Feature: DataDrivenWithExample
	To benefit from the website, I need to register first

@mytag
Scenario Outline: Data Driven With Example
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up
	And I enter my Username text"<Username>"
	And I enter email text"<Email>"
	And I enter password text"<Password>"
	When I click on sign up button
	Then I can register successfully
	
	Examples:
	| Username | Email     | Password           |
	| EfuaBo   | nana      | 1234               |
	| Olamide  | olamide   | PasswordSecure2233 |
	| Akwasi   | alltheway | GagaKuma8899       |