namespace Task5;
public class Stack<T>
{
    public List<T> lists = new List<T>();
    public void Push(T item)
    {
        lists.Add(item);
    }
    public T Pop()
    {
        var list = lists.Last();
        lists.Remove(list);
        return list;
        
    }
    public T Peek()
    {
        var list = lists.Last();
        return list;
    }
}
