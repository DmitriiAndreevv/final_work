
//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“**Hello**”, “2”, “**world**”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“**Russia**”, “**Denmark**”, “**Kazan**”] → []

string [] words (string[] word)
{
    string [] Wordsnew = new string[11];
    int count = 0;
    for (int i = 0; i < word.Length; i++)
    {
        if(word[i].Length <= 3 )
        {
            Wordsnew[count++] = word[i];
        }
    }
    Array.Resize(ref Wordsnew, count);
    return Wordsnew;
}

void Print (string [] array)
{
    Console.WriteLine("["+ string.Join(" ,", array) + "]");
    Console.WriteLine();
}

string[] NewArray = { "hello", "2", "world", ":-)"};
string[] NewArray2 = {"1234", "1567", "-2", "computer science"};
string[] NewArray3 = {"Russia", "Denmark", "Kazan"};


Print(words(NewArray));
Print(words(NewArray2));
Print(words(NewArray3));