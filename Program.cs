string[] stringArray = new string[]{"hello", "2", "world", ":-)"};

var resultArray = Array.Empty<string>();
int i = 0;

while (i < stringArray.Length)
{
    if (stringArray[i].Length <= 3)
    {
        string element = stringArray[i];
        resultArray = resultArray.Append(element).ToArray();
    }
    i++;
}

foreach (string item in resultArray){
    Console.Write(item);
    Console.Write(" ");
} 
Console.WriteLine();