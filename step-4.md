Sum Digits
==========

```fsharp
[<TestCase(10, 1)>]
let when_summing_two_digits(number, digitSum) =
  Assert.That(sumDigits number, Is.EqualTo(digitSum))
```



```fsharp
let sumDigits number =
  1
```

I see what you did there....

```fsharp
[<TestCase(11, 2)>]
```

```fsharp
let sumDigits number =
  number.ToString() |>
  Seq.map (fun c -> Int32.Parse((string)c)) |>
  Seq.sum
```

That's more like it. There might be other ways to do it.

```fsharp
let digits number =
  //Continually mod 10 until we don't have anymore digits
  Seq.unfold (fun v -> if v > 0 then Some(v % 10, v / 10) else None) number |>
  Seq.choose id

let sumDigits number =
  this.digits number |> Seq.sum
```

Now let's get back to [even digit value](step-5.md).
