using PRAC3;
using System;
using System.Collections;
using System.Collections.Generic;

internal class APP
{
    static void Main()
    {
        FirstCollection.ArrayListTest();
        for (int i = 0; i < 50; i++)
        {
            Console.Write("-");
        }
        FirstCollection.QueueAndListTest();
        for (int i = 0; i < 50; i++)
        {
            Console.Write("-");
        }
        Manager.VehicleQueue();
        for (int i = 0; i < 50; i++)
        {
            Console.Write("-");
        }
        Manager.VehicleList();
        for (int i = 0; i < 50; i++)
        {
            Console.Write("-");
        }
        Observable.WorkObservable();
    }
}