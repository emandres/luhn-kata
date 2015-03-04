# Sum Digits

Let's write a test for summing digits.

[4.0](../../compare/step-3-3...step-4-0)
```fsharp
[<TestCase(10, 1)>]
member this.when_summing_two_digits(number, digitSum) =
  Assert.That(sumDigits number, Is.EqualTo(digitSum))
```
And implement it.

[4.1](../../compare/step-4-0...step-4-1)
```fsharp
let sumDigits number =
  1
```

I see what you did there....

[4.2](../../compare/step-4-1...step-4-2)
```fsharp
[<TestCase(11, 2)>]
```

Let's actually implement it.

[4.3](../../compare/step-4-2...step-4-3)
```fsharp
let sumDigits number =
  number.ToString() |>
  Seq.map (fun c -> Int32.Parse((string)c)) |>
  Seq.sum
```

That's more like it. There might be other ways to do it.

[4.4](../../compare/step-4-3...step-4-4)
```fsharp
let digits number =
  //Continually mod 10 until we don't have anymore digits
  Seq.unfold (fun v -> if v > 0 then Some(v % 10, v / 10) else None) number

let sumDigits number =
  this.digits number |> Seq.sum
```

Now let's get back to [even digit value](step-5.md).
