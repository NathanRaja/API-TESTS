Test Time Fun: Perpetrators caught violating these commandments your PR will be destroyed shortly.

External Test:

Tests within this project will make external calls. Specifically we have divided this project into
two sections:

	- Contract: testing the contract and comparing that what you send matches the contarct.
	- E2E: testing the real communication.

Naming Conventions:

	- Should<Expression> (e.g. ShouldReturnOutOfStockProductIfSizeIsOutOfStock)
	- Classes with multiple methods, <Method Name>_Should<Expression> (e.g. GetLanguage_ShouldBeLowerCaseForAllCountries)

Test Conventions:

	- A test for each contract accessible.

Testing Resources:
https://github.com/xunit/samples.xunit

Trait Tests:
http://www.brendanconnolly.net/organizing-tests-with-xunit-traits/
https://github.com/brendanconnolly/Xunit.Categories - Might be worth including or writing our own

Theory Tests:
https://andrewlock.net/creating-parameterised-tests-in-xunit-with-inlinedata-classdata-and-memberdata/
http://hamidmosalla.com/2017/02/25/xunit-theory-working-with-inlinedata-memberdata-classdata/
https://andrewlock.net/creating-strongly-typed-xunit-theory-test-data-with-theorydata/

Shared Data and Context:
https://xunit.github.io/docs/shared-context