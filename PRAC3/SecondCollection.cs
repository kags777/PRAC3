using PRAC3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC3
{
    public class BaseVehicle : IComparable<BaseVehicle>, ICloneable
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public BaseVehicle() { }

        // Конструктор с параметрами и значениями по умолчанию
        public BaseVehicle(string brand = "", string model = "", int year = 0, double price = 0.0)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }

        public int CompareTo(BaseVehicle other)
        {
            if (other == null) return 1;
            return Year.CompareTo(other.Year); // сравнение по возрасту
        }

        public object Clone()
        {
            return new BaseVehicle
            {
                Brand = this.Brand,
                Model = this.Model,
                Year = this.Year,
                Price = this.Price
            };
        }
        public override string ToString()
        {
            return $"{Brand,-10} {Model,-20} {Year}  {Price:N0} руб.";
        }
    }

    public class Manager
    {
        public static Queue<BaseVehicle> queue = new Queue<BaseVehicle>();
        public static void VehicleQueue()
        {
            Random rand = new Random();


            queue.Enqueue(new BaseVehicle("Audi", "Q7", 2020, 5000000));
            queue.Enqueue(new BaseVehicle("Mercedes", "GLS", 2021, 6200000));
            queue.Enqueue(new BaseVehicle("Toyota", "Land Cruiser 300", 2022, 7800000));
            queue.Enqueue(new BaseVehicle("Lada", "Vesta", 2023, 1500000));
            queue.Enqueue(new BaseVehicle("Nissan", "GTR", 2018, 5500000));

            Console.WriteLine("\nОчередь из машин:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            int coutDel = rand.Next(1, 5);
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

            //добавление чисел в очередь
            queue.Enqueue(new BaseVehicle("Lexus", "RX", 2022, 4800000));
            queue.Enqueue(new BaseVehicle("Volkswagen", "Touareg", 2018, 3700000));
            queue.Enqueue(new BaseVehicle("Volkswagen", "Touareg", 2018, 3700000));


            Console.WriteLine("\nОчередь после добавления различных элементов: ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }

        public class CarComparer : IComparer<BaseVehicle>
        {
            public int Compare(BaseVehicle x, BaseVehicle y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return -1;
                if (y == null) return 1;

                int result = string.Compare(x.Brand, y.Brand);
                if (result != 0) return result;

                result = string.Compare(x.Model, y.Model);
                if (result != 0) return result;

                result = x.Year.CompareTo(y.Year);
                if (result != 0) return result;

                return x.Price.CompareTo(y.Price);
            }
        }

        


        public static string CompareCars(BaseVehicle car1, BaseVehicle car2)
        {
            CarComparer comparer = new CarComparer();
            int result = comparer.Compare(car1, car2);
            return result == 0 ? "одинаковые" : "разные";
        }

        public static void VehicleList()
        {
            CarComparer comparer = new CarComparer();
            List<BaseVehicle> car = new List<BaseVehicle>(queue);

            Console.WriteLine("\nСписок: ");
            foreach (var item in car)
            {
                Console.WriteLine(item);
            }

            int index = car.FindIndex(v => v.Brand == "Volkswagen");
            if (index != -1)
                Console.WriteLine($"\nПервое вхождение \"Volkswagen\": {index + 1} позиция");
            else
                Console.WriteLine("\nVolkswagen не найден");



            string result1 = CompareCars(car[car.Count - 1], car[car.Count - 2]);
            Console.WriteLine($"\nМашины под номерами {car.Count - 1} и {car.Count - 2} {result1}");

            string result2 = CompareCars(car[car.Count - 2], car[car.Count - 3]);
            Console.WriteLine($"\nМашины под номерами {car.Count - 2} и {car.Count - 3} {result2}");

            Console.WriteLine($"\nСписок машин, после сортировки по году: ");
            car.Sort();

            foreach (var item in car)
            {
                Console.WriteLine(item);
            }

            List<BaseVehicle> carClone = car.Select(c => (BaseVehicle)c.Clone()).ToList();
            Console.WriteLine($"\nКопия списка машин: ");
            foreach (var item in car)
            {
                Console.WriteLine(item);
            }

        }
    }


}
