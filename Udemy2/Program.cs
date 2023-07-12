namespace Udemy2;

class Program
{
    static void Main(string[] args)
    {
        double myDouble = 13.37;
        int myInt;
        //explicit conversion
        //cast double to int
        myInt = (int)myDouble;

        //implicit conversion
        int num = 147832344;
        long bigNum = num;

        float myFloat = 13.37f;
        double myNewDouble = myFloat;


        //implicit cpnversion with boolean values
        bool sunIsShining = true;


        //type conversion

        string myIntString = myInt.ToString();
        string bigNumString = bigNum.ToString();
        string myNumString = num.ToString();
        string myFloatString = myFloat.ToString();
        string myString = myDouble.ToString();
        string sunIsShiningString = sunIsShining.ToString();



        Console.WriteLine(myFloatString);
        Console.WriteLine(bigNumString);
        Console.WriteLine(myNumString);
        Console.WriteLine(myIntString);
        Console.WriteLine(sunIsShining);

        Console.Read();


    }
}

