# Bit Bakery

#### By Noah Kise

#### A console application to simulate shopping at a bakery.

## Technologies Used

* C#
* MSTest

## Description

This is a console application that lets the user simulate shopping at a bakery.  They can enter quantities for loaves of bread and pastries, and then see the total price of their order.  The user can also edit their order, and error handling is incorporated to force user inputs to be valid positive integers.  There is an easter egg if the user enters the correct quantities to calculate one of two secret target prices.

## Setup/Installation Requirements

* .NET must be installed. Latest version can be found [here](https://dotnet.microsoft.com/en-us/).
* To run locally on your computer, clone the main branch of this [repository](https://github.com/NoahKise/bakery-console-app/tree/main).
* In your terminal, navigate to the root folder of this project and run `dotnet restore`.
* Navigate to the "Bakery" directory and run `dotnet run`.
* It is recommended to open in a terminal that is fairly large so banners can display properly. Using VSCode terminal is NOT recommended.

## Known Bugs

* Although there is specific error messaging for entering in numbers above 1000000, if you enter in a massive number such as 1000000000000000 it defaults to a more generic error message.

## License

Code licensed under [GPL](LICENSE.txt)

Any suggestions for ways I can improve this app? Reach out to me at noah@kisefamily.com

Copyright (c) January 19 2024 Noah Kise