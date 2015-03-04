namespace LuhnKataExample

open System

module LuhnCheck =
    let oddDigitValue = id

    let evenDigitValue digit =
        2 * digit

    let digits number =
       Seq.unfold (fun v -> if v > 0 then Some(v % 10, v / 10) else None) number

    let sumDigits number =
       digits number |>
       Seq.sum