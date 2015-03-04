Account Number Value
====================
Let's call the account number's value the sum of the value of all digits in the account number.

```fsharp
[<TestCase(1, 2)>]
member this.when_getting_the_value_for_the_account_number(number, expectedValue) =
  let checker = new LuhnChecker()

  Assert.That(checker.accountNumberValue number, Is.EqualTo(expectedValue))
```

```fsharp
member this.accountNumberValue number =
  evenDigitValue number
```

Alright, so that works for single digit account numbers. Let's add another test case

```fsharp
[<TestCase(10, 1)>]
```

And let's fix that test.

```fsharp
member this.accountNumberValue number =
  Seq.mapi (fun index element -> if index % 2 = 0 then evenDigitValue element else oddDigitValue element) |>
  Seq.sum
```
