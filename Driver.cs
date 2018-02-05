using System;
using ComplexNumbers;

public class Driver
{
  
    public static void Main(String[] args)
    {

        ComplexNum a = new ComplexNum(2, 0);
        ComplexNum b = new ComplexNum(0, 7);

        ComplexNum.printNum(a);
        ComplexNum.printNum(b);

        ComplexNum c = ComplexNum.add(a, b);
        ComplexNum.printNum(c);

        c = ComplexNum.subtract(a, b);
        ComplexNum.printNum(c);

        c = ComplexNum.multiply(a, b);
        ComplexNum.printNum(c);

        c = ComplexNum.divide(a, b);
        ComplexNum.printNum(c);

        c = ComplexNum.conjugate(a);
        ComplexNum.printNum(c);

        double d = ComplexNum.argument(b);
        Console.WriteLine(d);

        d = ComplexNum.modulus(a);
        Console.WriteLine(d);

    }


}

