Sum Digits
==========

```fsharp
[<TestCase(10, 1)>]
member this.when_summing_two_digits(number, digitSum) =
  let checker = new LuhnChecker()

  Assert.That(checker.sumDigits number, Is.EqualTo(digitSum))
```



```fsharp
member this.sumDigits number =
  1
```

I see what you did there....

```fsharp
[<TestCase(11, 2)>]
```

```fsharp
member this.sumDigits number =
  number.ToString() |>
  Seq.map (fun c -> Int32.Parse((string)c)) |>
  Seq.sum
```

That's more like it. There might be other ways to do it.

```fsharp
member this.digits number =
  //Continually mod 10 until we don't have anymore digits
  Seq.unfold (fun v -> if v > 0 then Some(v % 10, v / 10) else None) number |>
  Seq.choose id

member this.sumDigits number =
  this.digits number |> Seq.sum
```

Now let's get back to [even digit value](step-5.md)
