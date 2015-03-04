# Even Digit Value (continued)

Let's refresh ourselves of what our test was.

###### [5.0](../../tree/step-5-0/example/LuhnKataExample)
```fsharp
[<TestCase(1, 2)>]
[<TestCase(6,3)>]
let when_calculating_the_value_for_an_even_digit(digit, expected) =
  Asset.That(evenDigitValue digit, Is.EqualTo(expected))
```

Now that we have the `sumDigits` function, the implementation should be trivial.

###### [5.1](../../tree/step-5-1/example/LuhnKataExample)
```fsharp
let evenDigitValue digit =
  2 * digit |> sumDigits
```

Now that we can calculate the values for even and odd digits, we can move on to [getting the values for each digit in the account number](step-6.md).
