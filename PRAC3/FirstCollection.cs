using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC3
{
    internal class FirstCollection
    {
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

        public static void QueueAndListTest()
        {
            Random rand2 = new Random();
            Queue<int> queue = new Queue<int> { };

            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(rand2.Next(1, 100));//Enqueue-метод для добавления эл-ов в очередь
            }

            Console.WriteLine("\nЭлементы очереди: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            int coutDel = rand2.Next(1, 5);
            Console.WriteLine($"\nИз очереди удалится {coutDel} элемент(а)(ов)");

            for (int i = 0; i < coutDel; i++)
            {
                queue.Dequeue();
            }

            Console.WriteLine("\nОчередь после удаления: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //Различные варианты добавления чисел в очередь
            queue.Enqueue(2);//обычный метод для добавления эл-ов в очередь

            //добавление из массива
            int[] values = { 5, 6, 7 };
            foreach (int v in values)
                queue.Enqueue(v);

            Console.WriteLine("\nОчередь после добавления различных элементов: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            //Работа со второй коллекцией
            List<int> numbers = new List<int>(queue);

            Console.WriteLine("\nСписок: ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //поиск значения
            Console.WriteLine($"\nПервое вхождение  \"2\": {numbers.IndexOf(2) + 1} позиция");
        }
    }
}
