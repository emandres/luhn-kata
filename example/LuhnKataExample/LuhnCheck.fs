namespace LuhnKataExample

open System

module LuhnCheck =
    let oddDigitValue = id

    let evenDigitValue digit =
        2 * digit