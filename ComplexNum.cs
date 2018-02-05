using System;

namespace ComplexNumbers
{
    class ComplexNum
    {

        public double re = 0;

        public double im = 0;

        public ComplexNum(double re, double im)
        {

            this.re = re;

            this.im = im;

        }

        public static ComplexNum add(ComplexNum num1, ComplexNum num2)
        {

            return new ComplexNum(num1.re + num2.re, num1.im + num2.im);

        }

        public static ComplexNum subtract(ComplexNum num1, ComplexNum num2)
        {

            return new ComplexNum(num1.re - num2.re, num1.im - num2.im);

        }

        public static ComplexNum multiply(ComplexNum num1, ComplexNum num2)
        {

            return new ComplexNum(num1.re * num2.re - num1.im * num2.im,
                                  num1.re * num2.im + num1.im * num2.re);

        }

        public static ComplexNum conjugate(ComplexNum num)
        {

            return new ComplexNum(num.re, -num.im);

        }

        public static double modulus(ComplexNum num)
        {

            return Math.Sqrt(num.re * num.re + num.im * num.im);
           

        }

        public static ComplexNum divide(ComplexNum num1, ComplexNum num2)
        {
            ComplexNum result = multiply(num1, conjugate(num2));

            double modNum2 = num2.re * num2.re + num2.im * num2.im;

            return new ComplexNum(result.re / modNum2, result.im / modNum2);

        }

        public static double argument(ComplexNum num)
        {

            if (num.re == 0 && num.im == 0) return 0;
            else if (num.re >= 0 && num.im >= 0) return Math.Asin(num.im / modulus(num));
            else if (num.re <= 0 && num.im >= 0) return Math.Acos(num.re / modulus(num));
            else if (num.re <= 0 && num.im <= 0) return Math.Acos(num.re / modulus(num));
            else return Math.Asin(num.im / modulus(num));

        }

        public static void printNum(ComplexNum num)
        {
            if (num.re != 0)
            {
                
                if (num.im > 0) Console.WriteLine(num.re + "+" + num.im + "i");
                else if (num.im == 0) Console.WriteLine(num.re);
                else if (num.im < 0) Console.WriteLine(num.re + "" + num.im + "i");

            } else if (num.re == 0)
            {

                if (num.im > 0) Console.WriteLine(num.im + "i");
                else if (num.im == 0) Console.WriteLine(num.re);
                else if (num.im < 0) Console.WriteLine(num.im + "i");

            }
        }

    }
}
