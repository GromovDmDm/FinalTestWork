
ShowArray(ArrayMaxTextThreeLength(CreateArray()));

void ShowArray(string[] array) 
{
    if(array[0] == null) 
        Console.Write("Нет элементов меньше или равно 3");
    else {
        Console.Write("Элементы меньше или равно 3: ");
        foreach (var item in array)
            Console.Write(item + " ");
    }
}

string[] CreateArray() 
{
  Console.Write("Напишите какой длины создаётся массив: ");
  int size = Convert.ToInt32(Console.ReadLine());
  string[] array = new string[size];
  Console.WriteLine("Создаём массив: ");
  for (int i = 0; i < size; i++)
  {
    Console.Write($"Введите значение {i + 1} элемента массива: ");
    array[i] = Console.ReadLine() ?? "";
  }
  return array;
}

string[] ArrayMaxTextThreeLength(string[] array) {
    string[] arrayMaxTextThreeLength = new string[array.Length];
    int size = 0;
    foreach (var value in array)
    {
        if (value.Length <= 3 && value != "")
        {
            arrayMaxTextThreeLength[size] = value;
            size++;
        }
    }
    return arrayMaxTextThreeLength;
}