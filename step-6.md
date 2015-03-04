# Account Number Value

Let's call the account number's value the sum of the value of all digits in the account number.
[6.0](../../tree/step-6-0/example/LuhnKataExample)
```fsharp
[<TestCase(1, 2)>]
member this.when_getting_the_value_for_the_account_number(number, expectedValue) =
  Assert.That(accountNumberValue number, Is.EqualTo(expectedValue))
```

[6.1](../../tree/step-6-1/example/LuhnKataExample)
```fsharp
let accountNumberValue number =
  evenDigitValue number
```

Alright, so that works for single digit account numbers. Let's add another test case

[6.2](../../tree/step-6-2/example/LuhnKataExample)
```fsharp
[<TestCase(10, 1)>]
```

And let's fix that test.

[6.3](../../tree/step-6-3/example/LuhnKataExample)
```fsharp
let accountNumberValue number =
  digits number |>
  Seq.mapi (fun index element -> if index % 2 = 0 then evenDigitValue element else oddDigitValue element) |>
  Seq.sum
```

That `Seq.mapi` line is pretty ugly. Let's refactor that

[6.4](../../tree/step-6-4/example/LuhnKataExample)
```fsharp
let digitValue index element =
  if index % 2 = 0 then
    evenDigitValue element
  else
    oddDigitValue element
    
let accountNumberValue number =
  digits number |>
  Seq.mapi digitValue |>
  Seq.sum
```

[Let's move on to the next step and wrap this up!](step-7.md)
