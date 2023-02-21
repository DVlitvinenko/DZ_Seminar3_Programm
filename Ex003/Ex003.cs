using static Metods;
public class Ex003
{
// Напишите программу, которая принимает на вход 
//число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//получаем число
public static void Ex001_cubes()
{
int number = Input("Введите число: ");
//получаем таблицу кубов до max и выводим в консоль
ThreeCubed(number);
}
}