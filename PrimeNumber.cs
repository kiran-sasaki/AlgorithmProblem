using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimeNumber
    {
        public void PrimeCheck()
        {
            int x = 1,y= 1000,C,rev,temp,num,i;
            Boolean IsPrime = true; ;

            Console.WriteLine("Prime numbers between "
            + x + " and " + y);
            for (num=x ;num <=y; num++)
            {
                //  loop the iterations for k times
                temp = num;
                C = 0;
                rev = 0;
                for(i=1;i<=temp;i++)
                {
                    if(temp%i==0)
                        C++;
                }
                if(C==2)
                {
                    while(temp>0)
                    {
                        rev=rev*10+(temp%10);
                        temp=temp/10;
                    }
                    if (rev == num)
                        Console.WriteLine(num+" Is Plaindrome");
                }
            }
        }
    }
}
