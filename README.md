# Roman Numeral Converter

## Description

This application was developed in 2013 for the [BIL2008 Algorithms](https://katalog.ktu.edu.tr/dersbilgipaketi/course.aspx?pid=9&lang=2&dbid=607742) course assignment on Roman Numeral conversion. The application performs bidirectional conversion between Roman numerals and standard numbers. While converting a number to Roman numerals is quite simple, converting a Roman numeral to a standard number requires checking if the Roman numeral is valid.

A three-step solution has been developed to verify the validity of a Roman numeral:

1. Assume the entered Roman numeral is correct and convert it to a standard number.
2. Convert the obtained standard number back to a Roman numeral.
3. If the converted numeral matches the initially entered numeral (string), a valid value has been entered; if it does not match, the value is invalid.