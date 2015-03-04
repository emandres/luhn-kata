# Generating the Check Digit

We're almost there. With our shiny new account number value, we can calculate the final check digit. To get the check digit, we need to `mod 10` the account number value, then subtract it from 10.

```fsharp
[<TestCase(1, 8)>]
[<TestCase(10, 9)>]
[<TestCase(411111111111111L, 1)>]
let when_getting_the_check_digit(number, checkDigit) =
  Assert.That(checkDigit number, expected)
```

```fsharp
let checkDigit number =
  10 - (accountNumberValue number) % 10
```

Just one corner case we need to address.

```fsharp
[<TestCase(57, 0)>]
```

In the case where the account number value is 0, this makes the check digit 10, which is actually two digits, so we `mod 10` again.

```fsharp
let checkDigit number =
  (10 - (accountNumberValue number) % 10) % 10
```
