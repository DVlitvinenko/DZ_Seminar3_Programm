
public class Metods
{
  // 1. Создание массива

public static int []CreateArray (int size)
{
  return new int[size];
}

// 2. Заполнение массива рандомно

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

// 2.1 Заполнение массива с клавиатуры

public static void FillArrayKeyboard (int []NameArray)
{
  for(int index = 0; index < NameArray.Length; index++)
  {
    NameArray[index] = Input($"Введите координату {index+1} точки: ");
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

// Проверка является ли число пятизначным

public static int ProvNaFifth ()
{
  int number = Input("Введите 5-тизначное число: ");
  while (number < 9999 || number > 100000)
  {
    Console.WriteLine("Число не пятизначное!");
    number = Input("Введите 5-тизначное число");
  }
  return number;
}

//Проверка на палиндром пятизначного числа
public static void Palindrom5th (int number1)
{
  int number2 = (number1 / 10000 - number1 % 10) + (number1 % 10000 / 1000 - number1 % 100 / 10);
  if (number2 == 0) 
  Console.WriteLine("Палиндром");
  else 
  Console.WriteLine("Не палиндром");
}

// Расстояние между двумя точками по трем координатам
//  Формула: l = √ (x 2 - x 1)^2+ (y 2 - y 1)^2+ (z 2 - z 1)^2
// Math.Sqrt() - метод сишарп кеоторый выводит квадратный корень

public static double LengthBetwinPoints(int []array1, int[] array2)
{
  int length = 0;
  for(int i = 0; i < array1.Length; i++)
  {
    length = length + (array1[i] - array2[i])*(array1[i] - array2[i]);
  }
  double lengthBetwin = Convert.ToDouble(Math.Sqrt(length));
  return lengthBetwin;
}


//получаем таблицу кубов до max
public static void ThreeCubed (int max)
{
  Console.Write(max + " -> 1");
  for (int i = 2; i <= max; i++)
  {
    Console.Write(", " + i*i*i);
  }
}
}

 
