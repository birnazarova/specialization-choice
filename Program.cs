string[] stringArray = new string[]{"Kyrgyzstan", "Denmark", "Netherlands", ":-)"};

var resultArray = Array.Empty<string>();
int i = 0;

while (i < stringArray.Length)
{
    if (stringArray[i].Length <= 3)
    {
        resultArray = resultArray.Append(stringArray[i]).ToArray();
    }
    i++;
}

foreach (string item in resultArray){
    Console.Write(item);
    Console.Write(" ");
} 
Console.WriteLine();