// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateTextArray(int size)
{
string[] textArr = new string[size];

for(int i = 0; i < textArr.Length; i++)
{
   Console.WriteLine("Введите элемент массива.");
   textArr[i] = Console.ReadLine()!; 
}
return textArr;
}
int NewSizeStringArray(string[] txtArr)
{
    int newSize = 0;
   for(int i = 0; i < txtArr.Length; i++)
   {           
         if(txtArr[i].Length <= 3) newSize++;
   }
   return newSize;
}

string[] NewTextArray(string[] txtArr, int newArrSize)
{
string[] newTxtArr = new string[newArrSize];
int n = 0;
for (int i = 0; i < txtArr.Length; i++)
{
    if (txtArr[i].Length <= 3)
                {
                     newTxtArr[n] = txtArr[i];
                     n++;
                }
}
return newTxtArr;
}                        

string[] textArray = CreateTextArray(5);
int newSize = NewSizeStringArray(textArray);
string[] newTextArray = NewTextArray(textArray, newSize);
Console.WriteLine($"[{string.Join(", ", textArray)}] -> [{string.Join(", ", newTextArray)}]");