using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableStructPrac
{
    class Program
    {
        static void Main(string[] args)
        {

            int? nullableOne = 5;
            Nullable<int> nullableTwo = 6;
            int? sum = nullableOne + nullableTwo;
            Console.WriteLine(sum);


            //Compiler works
            MyNullable<int> myNullable = new MyNullable<int>(5);
            MyNullable<int> myNullableTwo = new MyNullable<int>(6);
            MyNullable<int> mySum =
                //if (myNullable.HasValue && myNullableTwo.HasValue)
                (myNullable.HasValue && myNullableTwo.HasValue) ?
                new MyNullable<int>(myNullable.Value + myNullableTwo.Value) :
                new MyNullable<int>();
            Console.WriteLine(mySum);

        }
    }
}
