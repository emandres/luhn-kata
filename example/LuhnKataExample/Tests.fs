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