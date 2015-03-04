namespace LuhnKataExample

open System
open NUnit.Framework
open LuhnCheck

[<TestFixture>]
type LuhnTests() =

    [<TestCase(0,0)>]
    [<TestCase(5,5)>]
    [<TestCase(9,9)>]
    member this.when_calculating_the_value_for_an_odd_digit(digit:int, expected:int) =
        Assert.That(oddDigitValue digit, Is.EqualTo(expected))

    [<TestCase(1L, 2L)>]
    [<TestCase(6L, 3L)>]
    member this.when_calculating_the_value_for_an_even_digit(digit, expected) =
        Assert.That(evenDigitValue digit, Is.EqualTo(expected))

    [<TestCase(10L, 1L)>]
    [<TestCase(11L, 2L)>]
    member this.when_summing_two_digits(number, digitSum) =
        Assert.That(sumDigits number, Is.EqualTo(digitSum))

    [<TestCase(1L, 2L)>]
    [<TestCase(10L, 1L)>]
    member this.when_getting_the_value_for_the_account_number(number, expectedValue) =
        Assert.That(accountNumberValue number, Is.EqualTo(expectedValue))

    [<TestCase(1L, 8L)>]
    [<TestCase(10L, 9L)>]
    [<TestCase(411111111111111L, 1L)>]
    [<TestCase(57L, 0L)>]
    member this.when_getting_the_check_digit(number, expected) =
        Assert.That(checkDigit number, Is.EqualTo(expected))