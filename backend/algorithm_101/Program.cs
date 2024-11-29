// See https://aka.ms/new-console-template for more information


//Data types
int numericValue = 1;
float withDecimalValue = 1.2f;
double withMoreDecimalValue = 1.2f;

char letterValue = 'c';
string wordSentenctValue = "Welcome to the course";
bool booleanValue = true;

float bread = 2.2f;
int butter = 1;

float total = bread + butter;
Console.WriteLine($"Your total is {total}");

if (true)
{
    Console.WriteLine("This statement is corret");
}

if (false)
{
    Console.WriteLine("This statement is false");
}

bool IsThereMilkAtFridge = false;

if (IsThereMilkAtFridge)
{
    Console.WriteLine("Get From Fridge");
}
else
{
    Console.WriteLine("Go an buy milk.");
}


Console.WriteLine("Hello, World!");