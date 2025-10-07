using System.Collections;

class APP
{

    static void Main()
    {
        ArrayListTest();
    }


    public static void ArrayListTest()
    {
        Random rand = new Random();
        ArrayList list = new ArrayList();

        for (int i = 0; i < 5; i++)
        {
            list.Add(rand.NextInt64(1, 100));
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
        Queue<int> queue = new Queue<int> { };
    }

}