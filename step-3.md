# Even Digit Value

Now let's work on calculating even digit values. As mentioned previously, even digits have a bit more of an algorithm to them.

1. Double the digit
2. If the digit is multiple digits, add them together.

Let's write a test

[3.0](../../compare/step-2-2...step-3-0)
```fsharp
[<TestCase(1, 2)>]
member this.when_calculating_the_value_for_an_even_digit(digit, expected) =
  Assert.That(evenDigitValue digit, Is.EqualTo(expected))
```

Go ahead and implement it to make that test pass.
[3.1](../../compare/step-3-0...step-3-1)
```fsharp
let evenDigitValue digit =
  2 * digit
```

Now, let's write a test case where the doubled digit is multiple digits.
[3.2](../../compare/step-3-1...step-3-2)
```fsharp
[<TestCase(6,3)>]
```

And implement it.

[3.3](../../compare/step-3-2...step-3-3)
```fsharp
let evenDigitValue digit =
  2 * digit |> sumDigits
```

Summing digits will vary widely based on the language you're using. Since this is non-trivial code, let's back out the changes that got us to the broken state, and write some tests for the `sumDigits` function. [Let's do it!](step-4.md)

