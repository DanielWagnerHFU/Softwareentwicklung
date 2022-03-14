MyClass i = new MyClass{value = 42};
MyClass j = i;
i.value = 43;
Console.WriteLine(j.value);
public class MyClass
{
    public int value;
}
