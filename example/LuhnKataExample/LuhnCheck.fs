namespace LuhnKataExample

open System

module LuhnCheck =

    let digits (number:Int64) =
       Seq.unfold (fun (v:Int64) -> if v > 0L then Some(v % 10L, v / 10L) else None) number

    let sumDigits (number:Int64) =
       digits number |>
       Seq.sum

    let oddDigitValue = id

    let evenDigitValue digit =
        2L * digit |> sumDigits

    let digitValue index element =
        if index % 2 = 0 then
            evenDigitValue element
        else
            oddDigitValue element

    let accountNumberValue accountNumber =
        digits accountNumber |>
        Seq.mapi digitValue |>
        Seq.sum

    let checkDigit accountNumber =
        10L - (accountNumberValue accountNumber) % 10L
