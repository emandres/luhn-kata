namespace LuhnKataExample

open System

module LuhnCheck =
    let oddDigitValue = id

    let evenDigitValue digit =
        2 * digit

    let digits number =
       number.ToString() |>
       Seq.map (fun c -> Int32.Parse((string)c))

    let sumDigits number =
       digits number |>
       Seq.sum