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
            var storage = new Storage();
            storage.AddSubscriber(manager);
            storage.AddSubscriber(supplier);
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
        public int Stuff { get; private set; }

        List<IStuffObserver> observers;

        public Storage()
        {
            Stuff = 10;
            observers = new List<IStuffObserver>();
        }

        public void AddSubscriber(IStuffObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveSubscriber(IStuffObserver observer)
        {
            observers.Remove(observer);
        }
        private void NotifySubscribers()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }

        public void AddStuff()
        {
            Stuff += new Random().Next(1, 4);
            NotifySubscribers();
        }

        public void RemoveStuff()
        {
            Stuff -= new Random().Next(1, 4);
            if (Stuff < 0)
            {
                Stuff = 0;
            }
            NotifySubscribers();
        }

        public void PrintStuffStatus()
        {
            Console.WriteLine($"We have {Stuff} stuff");
        }
    }

    interface IStuffObserver
    {
        void Update(Storage storage);
    }

    class Manager : IStuffObserver
    {
        public void OutOfStuff()
        {
            Console.WriteLine("Manager: We must buy stuff");
        }

        public void Update(Storage storage)
        {
            if (storage.Stuff < 5)
            {
                OutOfStuff();
            }
        }
    }

    class Supplier : IStuffObserver
    {
        public void StopNewOrders()
        {
            Console.WriteLine("Supplier: I'm not going to send more stuff");
        }

        public void Update(Storage storage)
        {
            if (storage.Stuff > 15)
            {
                StopNewOrders();
            }
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
