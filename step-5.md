Even Digit Value (continued)
============================

Let's refresh ourselves of what our test was.

```fsharp
[<TestCase(1, 2)>]
[<TestCase(6,3)>]
let when_calculating_the_value_for_an_even_digit(digit, expected) =
  Asset.That(evenDigitValue digit, Is.EqualTo(expected))
```

Now that we have the sumDigits function, the implementation should be trivial.

```fsharp
let evenDigitValue digit =
  2 * digit |> sumDigits
```

Now that we can calculate the values for even and odd digits, we can move on to [getting the values for each digit in the account number](step-6.md).
