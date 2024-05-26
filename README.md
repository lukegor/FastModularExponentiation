# Fast Modular Exponentiation

This project is a C# program for calculating <b>fast modular exponentiation</b>, i.e. the result of raising a base number to an exponent and then taking the modulus, as in $a^b \mod n$. The algorithm is efficient and widely used in cryptographic applications.

## Technologies
[<img align="left" alt="Csharp" width="36px" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" style="padding-right:10px;"/>][csharp]
[<img align="left" alt="dotnet" width="36px" src="https://upload.wikimedia.org/wikipedia/commons/thumb/7/7d/Microsoft_.NET_logo.svg/2048px-Microsoft_.NET_logo.svg.png" style="padding-right:10px;"/>][dotnet]

[csharp]: https://en.wikipedia.org/wiki/C_Sharp_(programming_language)
[dotnet]: https://en.wikipedia.org/wiki/.NET

<br>
<br>

## Features

- **User Input**: Prompts the user to enter the base, exponent, and modulus.
- **Efficient Algorithm**: Implements exponentiation by squaring.
- **Detailed Output**: Displays intermediate steps and final result.
- **Unit Tests**: Includes comprehensive unit tests to ensure correctness.

## Formula

The formula for modular exponentiation is:

$a^b \mod n$

where:
- `a` is the base number,
- `b` is the exponent,
- `n` is the modulus.


## How to Run

1. Clone the repository.
2. Open a terminal or command prompt.
3. Navigate to the project directory (`FastModularExponentiation`)
4. Compile the program using the following command
```
dotnet build
```
5. Run the program using the following command:
```
dotnet run
```

## Example Usage

```shell
Enter a: 2
Enter exponent: 10
Enter modulo: 1000

 i |        x |        a | t_i
 0 |        1 |        2 | 0
 1 |        1 |        4 | 1
 2 |        4 |       16 | 0
 3 |        4 |      256 | 1
 4 |       24 |      536 | -

Result: 24
```

## Unit tests

Unit tests are included to validate the correctness of the algorithm. These tests cover various scenarios to ensure accurate results for different inputs.
Follow these steps to execute the unit tests:

1. Open a terminal or command prompt.
2. Navigate to the directory containing the solution file (`FastModularExponentiation`).
3. Run the command `dotnet test`.

## License

This project is licensed under the [The MIT License](https://opensource.org/license/mit). See the LICENSE file for more details.
