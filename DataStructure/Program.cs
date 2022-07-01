
Console.WriteLine("Please enter a word you would like to reverse:");
string wordChoice = Console.ReadLine();



Console.WriteLine("\nYour word in reverse is: " + ReverseString(wordChoice));






//Method

static string ReverseString(string wordChoice)
{

    char[] stringArray = wordChoice.ToCharArray();

    string reverse = String.Empty;

    for (int i = stringArray.Length - 1; i >= 0; i--)
    {
        reverse += stringArray[i];
    }

    return reverse;

}