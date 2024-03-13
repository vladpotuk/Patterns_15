using System;

public class Client
{
    public void Run()
    {
        ConcreteAggregate<int> aggregate = new ConcreteAggregate<int>();
        aggregate.AddItem(1);
        aggregate.AddItem(2);
        aggregate.AddItem(3);

        IIterator<int> iterator = aggregate.CreateIterator();

        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}
