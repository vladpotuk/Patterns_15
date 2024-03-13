public class ConcreteIterator<T> : IIterator<T>
{
    private ConcreteAggregate<T> aggregate;
    private int currentIndex = 0;
    public ConcreteIterator(ConcreteAggregate<T> aggregate)
    {
        this.aggregate = aggregate;
    }

    public bool HasNext()
    {
        return currentIndex < aggregate.Count();
    }

    public T Next()
    {
        if (HasNext())
        {
            return aggregate.GetItem(currentIndex++);
        }
        else
        {
            throw new System.Exception("Немає наступного елемента.");
        }
    }
}
