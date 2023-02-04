
string UserInput = Console.ReadLine();
string Looped = "";
int counter = 0;

foreach (char i in UserInput)
{
    counter++;

    char CapitalLetter = char.ToUpper.(i);

    string letters = new string(i, counter - 1);

    Looped += CapitalLetter + letters + ",";

}

Looped = Looped.Remove(Looped.Length - 1, 1);
Console.WriteLine(Looped);
