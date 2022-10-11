// На входе массив строк. На выходе массив, содержащий строки первого массива длиной менее 4 символов.
string[] CutStrings(string[] someArray)
{
    List <string> subList = new List<string>();
    foreach (string item in someArray)
    {
        if (item.Length < 4)
        {
            subList.Add(item);
        }
    }
    string[] newArray = subList.ToArray();
    return newArray;
}

string[] exampleOne = {"qwer","asdf","qw","zx"};
string[] exampleTwo = {"Harry","Potter","is","not","here","!"};
string[] exampleThree = {"One","Two","Three","Four","Five","Six"};

//На выходе массив строк. К нему применяется функциия CutStrings, ее результат выводится в консоль.
void PrintResult(string[] someArray)
    {
    foreach (string item in CutStrings(someArray))
        {
            Console.Write($"{item} ");
        }
    }

