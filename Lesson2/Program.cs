// See https://aka.ms/new-console-template for more information
A a = new A();
A b = new B();
a.M();
b.M();


public class A {
    public virtual void M() {
        Console.WriteLine("1");
    }
}

public class B : A {
    public override void M() {
        Console.WriteLine("2");
    }
}