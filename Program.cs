string? GetInput(string prompt) {
    Console.Write(prompt);
    string? b = Console.ReadLine();
    Console.WriteLine();

    return b;
}

var num1 = Double.Parse(GetInput("Num one? "));
var op = GetInput("Op? (+|-|*|/|//|%): ");
var num2 = Double.Parse(GetInput("Num two? "));

var output = 0d;


if (op == "+")
    output = num1 + num2;
else if (op == "-")
    output = num1 - num2;
else if (op == "*")
    output = num1 * num2;
else if (op == "/")
    output = num1 / num2;
else if (op == "//")
    output = Math.Truncate(Math.Truncate(num1) / Math.Truncate(num2));
else if (op == "%")
    output = num1 % num2;

Console.WriteLine($"{num1} {op} {num2} = {output}");