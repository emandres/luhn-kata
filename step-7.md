# Generating the Check Digit

We're almost there. With our shiny new account number value, we can calculate the final check digit. To get the check digit, we need to `mod 10` the account number value, then subtract it from 10.

###### [7.0](../../tree/step-7-0/example/LuhnKataExample)
```fsharp
[<TestCase(1, 8)>]
[<TestCase(10, 9)>]
[<TestCase(411111111111111L, 1)>]
member this.when_getting_the_check_digit(number, checkDigit) =
  Assert.That(checkDigit number, Is.EqualTo(checkDigit))
```

###### [7.1](../../tree/step-7-1/example/LuhnKataExample)
```fsharp
let checkDigit number =
  10 - (accountNumberValue number) % 10
```

Just one corner case we need to address.

###### [7.2](../../tree/step-7-2/example/LuhnKataExample)
```fsharp
[<TestCase(57, 0)>]
```

In the case where the account number value is 0, this makes the check digit 10, which is actually two digits, so we `mod 10` again.

###### [7.3](../../tree/step-7-3/example/LuhnKataExample)
```fsharp
let checkDigit number =
  (10 - (accountNumberValue number) % 10) % 10
```

[Let's discuss what we learned](step-8.md)
