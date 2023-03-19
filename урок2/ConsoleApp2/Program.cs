using System.Collections.Immutable;
using System.ComponentModel.Design;

public static class program
{
    public static void Main()
    {
          Console.Write($"Введите количество элементов массива:\t");
        int elements;
        bool result = int.TryParse(Console.ReadLine(), out elements);
        if (result == false)
        {
            Console.WriteLine("Недопустимо вводить буквы");
            return;
        }
        if (elements <= 1 )
        {
            Console.WriteLine($"Экий вы простофиля, введите значение больше 1");
            return;
        }
       
        int[] array = new int[elements];

        for (int i = 0; i < elements; i++)
        {
            Console.Write($"Введите {i + 1} значение элемента массива\t");
            try
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Недопустимое значение");
                return;
            }

        }
        int max = array[0];
        int secondmax = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                secondmax = max;
                max = array[i];

            }
            else
                  if (array[i] > secondmax && array[i] != max)
            {
                secondmax = array[i];
            }
        }

        if (secondmax != 0)
        {
            Console.WriteLine($"второй максимальный элемент: {secondmax}");
        }
        else
        {
            Console.WriteLine("второго максимального элемента не существует");
        }
    }
}