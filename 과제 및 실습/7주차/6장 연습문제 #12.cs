interface SimpleList<T>
{
    void insert(T t);
    void delete(T t);
    T find(T t);
    int currentCount();
}

class GericClass<T> : SimpleList<T>
{
    private List<T> list;
    public GericClass()
    {
        list = new List<T>();
    }
    public void insert(T t)
    {
        list.Add(t);
    }
    public void delete(T t)
    {
        list.Remove(t);
    }
    public T find(T t)
    {
        foreach (T sub in list)
        {
            if (sub.Equals(t))
                return sub;
        }
        return default(T);
    }
    public int currentCount()
    {
        return list.Count;
    }
}
class Program
{
    static void Main(string[] args)
    {
        GericClass<int> g1 = new GericClass<int>();
        g1.insert(1);
        Console.WriteLine(g1.currentCount());
        g1.insert(2);
        Console.WriteLine(g1.currentCount());
        g1.insert(3);
        Console.WriteLine(g1.currentCount());
        g1.delete(2);
        Console.WriteLine(g1.currentCount());
        Console.WriteLine(g1.find(1));
        Console.WriteLine(g1.find(2));
    }
}