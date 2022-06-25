// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76
Console.Write("Enter N (size of array): ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
void RandomArray(double[] array)                       //Соответственно,  здесь мы делаем метод "который ничего не принимает и что-то выдает". В данном случае для каждой итерации будет присваиваться новое значения для элемента массива до тех пор пока выполняется условие i< длины массива array
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);           //???????
    }
}
void PrintArray(double[] array)
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
double maxNumber = array[0];
double minNumber = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxNumber) maxNumber = array[i];
    if (array[i] < minNumber) minNumber = array[i];
}
double subtraction = maxNumber - minNumber;
Console.WriteLine($"The difference between the maximum ({maxNumber}) and minimum ({minNumber}) array elements = {subtraction}");