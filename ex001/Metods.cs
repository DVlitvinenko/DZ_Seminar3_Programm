
public class Metods
{
  // 1. Создание массива

public static int []CreateArray (int size)
{
  return new int[size];
}

// 2. Ввод данных

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


// 4. Проверка является ли число пятизначным

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

//5.Проверка на палиндром пятизначного числа
public static void Palindrom5th (int number1)
{
  int number2 = (number1 / 10000 - number1 % 10) + (number1 % 10000 / 1000 - number1 % 100 / 10);
  if (number2 == 0) 
  Console.WriteLine("Палиндром");
  else 
  Console.WriteLine("Не палиндром");
}
}

 
