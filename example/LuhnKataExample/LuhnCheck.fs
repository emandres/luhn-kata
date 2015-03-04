namespace LuhnKataExample

open System

module LuhnCheck =

    let digits number =
       Seq.unfold (fun v -> if v > 0 then Some(v % 10, v / 10) else None) number

    let sumDigits number =
       digits number |>
       Seq.sum

    let oddDigitValue = id

    let evenDigitValue digit =
        2 * digit |> sumDigits

    let accountNumberValue accountNumber =
        digits accountNumber |>
        Seq.mapi (fun index element -> if index % 2 = 0 then evenDigitValue element else oddDigitValue element) |>
        Seq.sum
