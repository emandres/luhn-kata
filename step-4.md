# Sum Digits

###### [4.0](../../tree/step-4-0/example/LuhnCheckerExample)
```fsharp
[<TestCase(10, 1)>]
member this.when_summing_two_digits(number, digitSum) =
  Assert.That(sumDigits number, Is.EqualTo(digitSum))
```

###### [4.1](../../tree/step-4-1/example/LuhnCheckerExample)
```fsharp
let sumDigits number =
  1
```

I see what you did there....

###### [4.2](../../tree/step-4-2/example/LuhnCheckerExample)
```fsharp
[<TestCase(11, 2)>]
```

###### [4.3](../../tree/step-4-3/example/LuhnCheckerExample)
```fsharp
let sumDigits number =
  number.ToString() |>
  Seq.map (fun c -> Int32.Parse((string)c)) |>
  Seq.sum
```

That's more like it. There might be other ways to do it.

###### [4.4](../../tree/step-4-4/example/LuhnCheckerExample)
```fsharp
let digits number =
  //Continually mod 10 until we don't have anymore digits
  Seq.unfold (fun v -> if v > 0 then Some(v % 10, v / 10) else None) number

let sumDigits number =
  this.digits number |> Seq.sum
```

Now let's get back to [even digit value](step-5.md).
