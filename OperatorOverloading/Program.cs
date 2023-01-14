using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECIMAL NUMBER EXAMPLE
            DecimalNumber number1 = new DecimalNumber(10);
            DecimalNumber number2 = new DecimalNumber(20);

            var newNumber = number1 + number2;

            Console.WriteLine(newNumber.Value);
            Console.WriteLine(number1 == number2);
            if (number1)
            {
                //greater than zero
            }
            Console.ReadLine();


            //USER EXAMPLE

            User userDb = new User()
            {
                Id = 1,
                FullName = "Yasin Çoban"
            };

            User userApi = new User()
            {
                Id = 2,
                FullName = "Yasin Çoban"
            };

            if (userDb == userApi)
            {
                //id leri eşit değil
            }

        }
        private static void Sample()
        {
            /*
            * +   -   *   /
            * == != < > <= >=
            * true false
            * && || ?? ? += -= *= /=
            * 
            */

            int number1 = 1;
            int number2 = 2;

            int newNumber = number1 + number2;
            newNumber = number1 - number2;
            newNumber = number1 * number2;
            newNumber = number1 / number2;


            var eq = number1 == number2;
            eq = number1 != number2;
            eq = number1 > number2;
            eq = number1 < number2;

            if (eq)
            {

            }
        }
    }
    public class DecimalNumber
    {
        public decimal Value { get; set; }
        public int Precision { get; set; }
        public DecimalNumber(decimal val)
        {
            this.Value = val;

        }
        public static DecimalNumber operator +(DecimalNumber number1, DecimalNumber number2)
        {
            return new DecimalNumber(number1.Value + number2.Value);
        }
        public static DecimalNumber operator +(DecimalNumber number1, int number2)
        {
            return new DecimalNumber(number1.Value + number2);
        }
        public static bool operator ==(DecimalNumber number1, DecimalNumber number2)
        {
            return number1.Value == number2.Value && number1.Precision == number2.Precision;
        }
        public static bool operator !=(DecimalNumber number1, DecimalNumber number2)
        {
            return number1.Value != number2.Value;
        }
        public static bool operator true(DecimalNumber number) => number.Value > 0;
        public static bool operator false(DecimalNumber number) => number.Value <= 0;

    }

    public class User
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public static bool operator ==(User u1, User u2) => u1.Id == u2.Id;
        public static bool operator !=(User u1, User u2) => u1.Id != u2.Id;

    }
}
