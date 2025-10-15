using System.Collections;
using System.Collections.Generic;

class APP
{

    static void Main()
    {
        ArrayListTest();
    }


    public static void ArrayListTest()
    {
        Random rand1 = new Random();
        ArrayList list = new ArrayList();

        for (int i = 0; i < 5; i++)
        {
            list.Add(rand1.NextInt64(1, 100));
        }


        list.Add("Пицца");
        list.RemoveAt(2);//удаляем 3-й элемент
        Console.WriteLine($"Количество элементов: {list.Count}");
        Console.WriteLine("\nЭлементы необощенной коллекции:");


        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"\nПервое вхождение слова \"пицца\": {list.IndexOf("Пицца")}"); ;
    }

    public static void QueueTest() 
    {
        Random rand2 = new Random();
        Queue<int> queue = new Queue<int> {};

        for (int i = 0; i < 5; i++)
        {
            queue.Enqueue(rand2.Next(1, 100));//Enqueue-метод для добавления эл-ов в очередь
        }

        Console.WriteLine("Элементы очереди: ");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

    }

}