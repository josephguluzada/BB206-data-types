namespace BB206
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //a = 1;

            //int num1 = 5;
            //var num2 = 10;

            //byte age = 19;

            //double num5 = 10.4;
            //float num3 = 6.7f;
            //decimal num4 = 7.8m;

            //bool check = false;

            //char character = 'a'; // 16bit

            //string name = "ali123"; // 16*6=96bit

            //Console.WriteLine(name);

            double number1 = 6;
            double number2 = 7;

            double sum = number1 + number2;
            sum = number1 - number2;
            sum = number1 * number2;
            sum = number1 / number2;

            var a = 13;
            var b = 10;

            var evenNumber = a % 2 == 0; // cut eded
            var oddNumber = a % 2 == 1; // tek eded

            a++;
            //a = a + 1;
            a--;
            //a = a - 1;

            //sum = ++a + 3; 

            a += 5; // a = a + 5
            a -= 3; // a = a - 3
            a *= 3; // a = a * 3
            a /= 15; // a = a / 15

            //Console.WriteLine(a);

            //Console.WriteLine(sum);

            bool check = !(a == 3 && a > 10) && (a == 3 || a < 1);

            Console.WriteLine(check);

        }
    }
}