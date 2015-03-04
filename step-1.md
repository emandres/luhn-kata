Background
==========

Credit card numbers are composed of two parts: an account number, and a check digit. The check digit is the last digit of the credit card number, and exists to ensure that a number isn't mistyped when manually entered. It is computed using a simple checksum algorithm known as a Luhn check. 

So how does it work? Let's take the number 13293714 and compute it's check digit.

Index|Digit|Value|Digit Sum
----:|----:|----:|--------:
0|4|8|8
1|1|1|1
2|7|14|5
3|3|3|3
4|9|18|9
5|2|2|2
6|3|6|6
7|2|2|2
|||Sum|36
|||Mod 10|6
|||Check Digit|4

* Even index digits are doubled. If the result is greater than ten, add its digits together.
* Odd index digits stay the same.
* Add all of the values together, mod 10.
* Subtract from 10, mod 10.
* Indexing begins with the **last** digit, zero based (i.e. the last digit is even).

To start with, let's write the code to calculate the value for an odd-indexed digit. Go to [the next step](step-2.md).

