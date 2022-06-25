// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Enter N (size of array): ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
void RandomArray(int[] array)                       //Соответственно,  здесь мы делаем метод "который ничего не принимает и что-то выдает". В данном случае для каждой итерации будет присваиваться новое значения для элемента массива до тех пор пока выполняется условие i< длины массива array
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10);
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

int sum = 0;                                            // инициализируем новую переменную, куда мы будем складывать сумму
for (int i = 0; i < array.Length; i += 2)
{
    sum = sum + array[i];
}
Console.WriteLine($"Sum of the elements in odd positions: {sum}");