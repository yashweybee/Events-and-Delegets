

internal class Program
{
    delegate void printDelegate(string text);

    public void printAnything(printDelegate p)
    {
        p("asdfasdasdfasdfas");
    }


    private static void Main(string[] args)
    {
        printDelegate p1 = A.TextPrint;
        printDelegate p2 = B.MyTextPrint;

        printDelegate p3 = new printDelegate(B.MyTextPrint);
        //p3("hajs");
        B b = new B();
        printDelegate p5 = b.greeting;



    }

}

public class A
{
    public static void TextPrint(string txt)
    {
        Console.WriteLine(txt);
    }
}
public class B
{
    public static void MyTextPrint(string txt)
    {
        Console.WriteLine(txt);
    }

    public void greeting(string txt)
    {
        Console.WriteLine("gm!! " + txt);
    }
}