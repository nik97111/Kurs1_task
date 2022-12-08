// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ['1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] array = {"Варан", "Ёж", "Сова", "Лещ", "Бегемот", "Як", "Слон"};
var count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        count++;
    }
}

string[] arrayNew = new string[count];
var countEl = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length <= 3)
    {
        arrayNew[countEl++] = array[i];
    }
}

for (int i = 0; i < arrayNew.Length; i++)
{
    Console.Write(arrayNew[i] + " ");
}