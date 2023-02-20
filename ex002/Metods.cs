
public class Metods
{
  // 1. Создание массива

public static int []CreateArray (int size)
{
  return new int[size];
}


// 2 Заполнение массива с клавиатуры

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



// 3. Вывод массива

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
}

 
