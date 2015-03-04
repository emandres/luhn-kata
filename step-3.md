Even Digit Value
================

Now let's work do the even digit value. As mentioned previously, even digits have a bit more of an algorithm to them.

1. Double the digit
2. If the digit is multiple digits, add them together.

Let's write a test

```fsharp
[<TestCase(1, 2)>]
let when_calculating_the_value_for_an_even_digit(digit, expected) =
  Asset.That(evenDigitValue digit, Is.EqualTo(expected))
```

Go ahead an implement make that test pass.

```fsharp
let evenDigitValue digit =
  2 * digit
```

Now, let's write a test case where the doubled digit is multiple digits.

```fsharp
[<TestCase(6,3)>]
```

And implement it.

```fsharp
let evenDigitValue digit =
  2 * digit |> sumDigits
```

Summing digits will vary widely based on the language you're using. Since this is non-trivial code, let's back out the changes that got us to the broken state, and write some tests for the `sumDigits` function. [Let's do it!](step-4.md)

