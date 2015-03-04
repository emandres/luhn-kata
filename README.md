# Luhn Kata
## A Functional Programming Kata

In this kata, we will explore writing an algorithm in a functional programming style. You do not need to use a functional language (but you are welcome to). The examples will be written in F# to provide an example of a functional style in a functional language. Since most will not be using a functional language, we will impose some restrictions on the code you write:

1. No state mutation (you can set variables, but do not change them afterward)
2. No looping (`for`, `while`, etc). Instead use higher order functions such as `map`, `reduce`, and `filter` (these may be differently named in your framework, e.g. `Select`, `Aggregate`, and `Where` in LINQ).
3. Functions may contain only **one** statement.
4. No classes &mdash; we're writing FP, not OO. If your language requires a class to compile, you are to treat it as a bag of functions.

With these restrictions in mind, you will want to have a library available to make functional-style programming easier. In C#, you will likely rely on LINQ. In JavaScript, you may want to use [underscore.js](http://underscorejs.org). Other languages might have the necessary functions in the standard library (F#, ruby).

Let's [get started](step-1.md)!
