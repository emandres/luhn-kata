namespace LuhnKataExample

open System

module LuhnCheck =
    let oddDigitValue = id

    let evenDigitValue digit = raise <| new NotImplementedException()