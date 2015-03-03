Background
==========

Credit card numbers are composed of two parts: an account number, and a check digit. The check digit is the last digit of the credit card number, and exists to ensure that a number isn''t mistyped when manually entered. It is computed using a simple checksum algorithm known as a Luhn check. 

So how does it work?

4|3| 2| 1|0|check
-|-|--|--|-|-----
4|2| 8| 3|1|?????
8|1|16| 3|2|?????
8|1| 7| 3|2|21

* Even index digits are doubled. If the result is greater than ten, add its digits together.
* Odd index digits are stay the same.
* Add all of the values together, mod 10.
* Subtract from 10, mod 10.

