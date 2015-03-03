Odd Digit Value
===============

Let's get warmed up by test driving the odd digit value calculation. 

```fsharp
[<TestFixture>]
type LuhnTests() =
  [<TestCase(0,0)>]
  [<TestCase(5,5)>]
  [<TestCase(9,9)>]
  member this.when_calculating_the_value_for_an_odd_digit(digit, expected) =
    let checker = new LuhnChecker()

    Assert.That(checker.oddDigitValue digit, Is.EqualTo(expected))
```

If you haven't realized, odd digits are really easy. Let's implement it.

```fsharp
type LuhnChecker() =
  member this.oddDigitValue digit =
    digit
```

We also could have aliased the identity function for this:

    member this.oddDigitValue = id
