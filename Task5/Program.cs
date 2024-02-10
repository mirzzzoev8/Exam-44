using Task5;
try
{
    var stack = new Task5.Stack<int>();
    stack.Push(2);
    stack.Push(3);
    System.Console.WriteLine(stack.Pop());
    System.Console.WriteLine("Last element deleted");
    System.Console.WriteLine(stack.Peek());
}
catch (System.Exception)
{
    System.Console.WriteLine(" Xato kadestay dodarjon ");
}



