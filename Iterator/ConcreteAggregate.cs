using System.Collections.Generic;

public class ConcreteAggregate<T> : IAggregate<T>
{
    private List<T> collection = new List<T>();

    public void AddItem(T item)
    {
        collection.Add(item);
    }

    public IIterator<T> CreateIterator()
    {
        return new ConcreteIterator<T>(this);
    }

    public int Count()
    {
        return collection.Count;
    }

    public T GetItem(int index)
    {
        return collection[index];
    }
}
