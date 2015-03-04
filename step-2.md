# Odd Digit Value

Let's get warmed up by test driving the odd digit value calculation. 

[2.0](../../compare/step-2-0~3...step-2-0)
```fsharp
open LuhnChecker

[<TestFixture>]
type LuhnTests() =

  [<TestCase(0,0)>]
  [<TestCase(5,5)>]
  [<TestCase(9,9)>]
  member this.when_calculating_the_value_for_an_odd_digit(digit, expected) =
    Assert.That(oddDigitValue digit, Is.EqualTo(expected))
```

If you haven't realized, odd digits are really easy. Let's implement it.

[2.1](../../compare/step-2-0...step-2-1)
```fsharp
module LuhnChecker =
  let oddDigitValue digit =
    digit
```

We also could have aliased the identity function for this:

[2.2](../../compare/step-2-1...step-2-2)
```fsharp
let oddDigitValue = id
```

Let's move onto [even digit value](step-3.md).
