# tdd-money
The multi-currency Money TDD example from the'Test-Driven Development by Example' book by Kent Beck

## To-do list

*The bold item is the one currently being worked on*

* $5 + 10 CHF = $10 if rate is 2:1
* ~~$5 * 2 = $10~~
* ~~Make "amount" private~~
* ~~Dollar side-effects?~~
* Money rounding?
* ~~equals()~~
* hashCode()
* Equal null
* Equal object
* ~~5 CHF * 2 = 10 CHF~~
* Dollar/Franc duplication
* ~~Common equals~~
* Common times

## How to run the tests yourself

This is a .NET Core solution

First follow the instructions on this page to get .NET Core installed locally:
https://www.microsoft.com/net/core#windowscmd

I used https://code.visualstudio.com/ and command line for this, but the full Visual Studio IDE can also be used.

If using command line, make sure you are in the root folder and then run these commands to get going:

```
dotnet restore
```

followed by this to get into the Test project

```
cd Money.Tests
```

and then this to run the tests with [dotnet-watch](https://docs.microsoft.com/en-us/aspnet/core/tutorials/dotnet-watch) to retest every time a file changes:

```
dotnet watch test
``` 

or if you want to just run the tests one time you can run this in the Money.Tests folder

```
dotnet test
```