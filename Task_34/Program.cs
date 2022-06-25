/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Write("Enter N (size of array): ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
void RandomArray(int[] array)                       //Соответственно,  здесь мы делаем метод "который ничего не принимает и что-то выдает". В данном случае для каждой итерации будет присваиваться новое значения для элемента массива до тех пор пока выполняется условие i< длины массива array
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[");                             // Добавляем вывод "[" перед циклом , иначе эта скобка будет писаться перед каждой новой итерацией
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");      // делаем -1 после цикла, чтобы корректно вывести на экран закрывающую скобку "]"
}
RandomArray(array);                                     //Вызываем метод Случайного заполнения массива
PrintArray(array);                                      //вызываем метод печати нашего случайного массива
Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine($"Number of even numbers in the array: {count}");






