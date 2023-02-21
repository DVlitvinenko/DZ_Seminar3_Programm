
public class Metods
{
  // 1. Создание массива

public static int []CreateArray (int size)
{
  return new int[size];
}



//2.получаем таблицу кубов до max
public static void ThreeCubed (int max)
{
  Console.Write(max + " -> 1");
  for (int i = 2; i <= max; i++)
  {
    Console.Write(", " + i*i*i);
  }
}
}

 
