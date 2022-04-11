// See https://aka.ms/new-console-template for more information
class Program{
    static void Main(string[] args){
        Calculator calculator = new Calculator();
        IntToVoid f = percentDone => Console.WriteLine($"Calculating ... {percentDone}% done");
        calculator.ProgressReporter += f;
        //calculator.ProgressReporter -= f;
        calculator.ResultReceiver += result => Console.WriteLine($"the result is: {result}");

        calculator.SomeCalculation();
        Thread.Sleep(20000);
    }
}
public delegate void IntToVoid(int integer);

public class Calculator{
    public event IntToVoid ProgressReporter;
    public event IntToVoid ResultReceiver;

    public void SomeCalculation(){
        new Task(DoCalculation).Start();
    }

    private void DoCalculation() {
        for(int i = 0; i < 100; i++){
            Thread.Sleep(100);
            ProgressReporter?.Invoke(i);
        }
        ResultReceiver(42);
    }
}
