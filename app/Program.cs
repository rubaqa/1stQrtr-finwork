//сначала напишем вывод массива в консоль
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
//спросим количество исходных элементов и создадим исходный массив
Console.Write("Сколько значений нужно проверить? ");
int size1 = Convert.ToInt32(Console.ReadLine());
string[] inArray = new string[size1];
Console.WriteLine("После номера элемента и двоеточия вводите значения");
//спросим поочередно эелементы
for (int i = 0; i < inArray.Length; i++)
{
    Console.Write($"{i + 1}: ");
    inArray[i] = Console.ReadLine()!;
    if (inArray[i] == null) inArray[i] = "";
}
//сколько "маленьких" значений? Тобешь размер результирующего массива
int size2 = 0;
for (int i = 0; i < inArray.Length; i++)
{
    if (inArray[i].Length <= 3)
    {
        size2++;
    }
}
//создадим новый массив и вложим "маленькие" значения
string[] resArray = new string[size2];
for (int i = 0; i < resArray.Length; i++)
{
    if (inArray[i].Length <= 3) resArray[i] = inArray[i];
}
//выведем в консоль оба массива
Console.Write("Из введенного массива { ");
PrintArray(inArray);
Console.Write("} получился массив { ");
PrintArray(resArray);
Console.Write("}.");
//Закрываем программу
Console.WriteLine();
Console.WriteLine();
Thread.Sleep(999);
Console.WriteLine("Нажмите любую кнопку для выхода.");
Console.ReadKey();