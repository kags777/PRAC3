using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PRAC3
{
    public class Observable
    {
        ObservableCollection<BaseVehicle> even;
        public Observable()
        {
            even = new ObservableCollection<BaseVehicle>();
            even.CollectionChanged += Cars_CollectionChanged;
        }
       
        public static void Cars_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (var item in e.NewItems)
                {
                    Console.WriteLine($"Добавлен элемент:\n{item}");
                }
            }

            if (e.OldItems != null)
            {
                foreach (var item in e.OldItems)
                {
                    Console.WriteLine($"Удалён элемент:\n{item}");
                }
            }
        }

        public static void WorkObservable()
        {
            Console.WriteLine("\nТеперь создаю и работаю с наблюдаемым списком: ");
            Observable myObservable = new Observable();

            // Добавление элементов
            myObservable.even.Add(new BaseVehicle("BMW","X5", 2020, 15000000));
            myObservable.even.Add(new BaseVehicle("Audi","A7", 2025, 7000000));
            
            // Удаление элемента
            myObservable.even.RemoveAt(0);
        }
    }
}
