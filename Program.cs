Console.Clear();
Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayStrings = new string[size];
int limit = 3;
int position = 0;
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    if (element.Length <= limit)
    {
        arrayStrings[position] = element;
        position++;
    }
}
