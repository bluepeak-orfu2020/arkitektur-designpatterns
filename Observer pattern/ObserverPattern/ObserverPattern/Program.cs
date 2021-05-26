using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            var supplier = new Supplier();
            var storage = new Storage(manager, supplier);
            var commands = new Dictionary<string, IStorageCommand>() {
                { "a", new AddCommand(storage) },
                { "r", new RemoveCommand(storage) }
            };

            string line;
            while ((line = Console.ReadLine()) != "")
            {
                if (commands.ContainsKey(line))
                {
                    commands[line].Execute();
                    storage.PrintStuffStatus();
                }
                else
                {
                    Console.WriteLine("Unknonw command");
                }
            }
        }
    }

    class Storage
    {
        int stuff;
        Manager manager;
        Supplier supplier;

        public Storage(Manager manager, Supplier supplier)
        {
            stuff = 10;
            this.manager = manager;
            this.supplier = supplier;
        }

        public void AddStuff()
        {
            stuff += new Random().Next(1, 4);
            if (stuff > 15)
            {
                supplier.StopNewOrders();
            }
        }

        public void RemoveStuff()
        {
            stuff -= new Random().Next(1, 4);
            if (stuff < 0)
            {
                stuff = 0;
            }
            if (stuff < 5)
            {
                manager.OutOfStuff();
            }
        }

        public void PrintStuffStatus()
        {
            Console.WriteLine($"We have {stuff} stuff");
        }
    }

    class Manager
    {
        public void OutOfStuff()
        {
            Console.WriteLine("Manager: We must buy stuff");
        }
    }

    class Supplier
    {
        public void StopNewOrders()
        {
            Console.WriteLine("Supplier: I'm not going to send more stuff");
        }
    }















    interface IStorageCommand
    {
        void Execute();
    }

    class BaseStorageCommand
    {
        protected Storage storage;
        public BaseStorageCommand(Storage storage)
        {
            this.storage = storage;
        }
    }

    class AddCommand : BaseStorageCommand, IStorageCommand
    {
        public AddCommand(Storage storage) : base(storage) { }

        public void Execute()
        {
            storage.AddStuff();
        }
    }
    
    class RemoveCommand : BaseStorageCommand, IStorageCommand
    {
        public RemoveCommand(Storage storage) : base(storage) { }

        public void Execute()
        {
            storage.RemoveStuff();
        }
    }
}
