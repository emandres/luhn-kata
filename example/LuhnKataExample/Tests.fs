namespace LuhnKataExample

open NUnit.Framework
open LuhnCheck

[<TestFixture>]
type LuhnTests() =

    [<TestCase(0,0)>]
    [<TestCase(5,5)>]
    [<TestCase(9,9)>]
    member this.when_calculating_the_value_for_an_odd_digit(digit:int, expected:int) =
        Assert.That(oddDigitValue digit, Is.EqualTo(expected))

    [<TestCase(1, 2)>]
    [<TestCase(6, 3)>]
    member this.when_calculating_the_value_for_an_even_digit(digit, expected) =
        Assert.That(evenDigitValue digit, Is.EqualTo(expected))

    [<TestCase(10, 1)>]
    [<TestCase(11, 2)>]
    member this.when_summing_two_digits(number, digitSum) =
        Assert.That(sumDigits number, Is.EqualTo(digitSum))

    [<TestCase(1, 2)>]
    member this.when_getting_the_value_for_the_account_number(number, expectedValue) =
        Assert.That(accountNumberValue number, Is.EqualTo(expectedValue))