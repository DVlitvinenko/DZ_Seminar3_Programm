
public class Metods
{
  // 1. Создание массива

public static int []CreateArray (int size)
{
  return new int[size];
}

// 2. Заполнение массива

public static void FillArray (int []NameArray)
{
  int index = 0;
  int length = NameArray.Length;
  while (index < length)
  {
    NameArray[index] = Rundom(-5000000, 500000);
    index++;
  }
}
// 3. Ввод данных

public static int Input (string text)
{
  Console.Write(text + " ");
  return Convert.ToInt32(Console.ReadLine());;
}


// 3.2 ввод данных рандомно

public static int Rundom (int min, int max)
{
  int result = 0;
  result = new Random().Next(min, max);
  return result;
}

// 4. перемешивание массива

public static void MixArray (int[] NameArray)
{
  int index = 0;
  int temp = 0;
  int MixIndex = 0;
  int length = NameArray.Length;
  while (index < length-index)
  {
    MixIndex = new Random().Next(index+1, length);
    temp = NameArray[index];
    NameArray[index] = NameArray[MixIndex];
    NameArray[MixIndex] = temp;
    index++;
  }
}

// 5. Вывод массива

public static void WriteArray (int []NameArray)
{
  int index = 0;
  int length = NameArray.Length;
  while (index < length)
  {
  Console.Write(NameArray[index] + " ");
  index++;
  }
}


//Сравнение числа

public static int CompNumber (int num1, int num2)
{
  if(num1 == num2)
  return 1;
  else
  return 0;
}

//нахождение числа

public static int FindNumber (int []array, int numb)
{
  int index = 0;
  int summ = 0;
  while (index < array.Length)
  {
    if(numb == array[index])
    summ = summ + 1;
    index++;
  }
  return summ;
}

//проверка на повтор числа

public static int ProvNaPovtor(int []array, int numb)
{
  int index = 0;
  while (index < numb)
  {
    if(array[numb] == array[index])
    {
      return 1;
    }
    index++;
  }
  return 0;
}

//перебор массива со счетом колличества повторяющихся элементов

public static void Enumepatian (int[] array)
{
  int index = 0;
  while (index < array.Length)
  { 
    if (ProvNaPovtor(array, index) == 0)
    {
    Console.Write(array[index] + "");
    Console.Write("-" + FindNumber(array, array[index])+",");
    }
    index++;
  }
}
public static string Enumepatian1 (int[] array)
{
  string text = String.Empty;
  int index = 0;
  while (index < array.Length)
  { 
    if (ProvNaPovtor(array, index) == 0)
    {
    text = "-" + FindNumber(array, array[index])+",";
    }
    index++;
  }
  return text;
}
}

 

 
