using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold
{
    public static class Program 
    {         
        public static void Main()
        {
            
            Console.WriteLine("Enter n1"); 
          
            int i= int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter n2"); 
            int z= int.Parse(Console.ReadLine()); 
            Console.WriteLine("Prime numbers from n1 to n2 :"); 
            int x; 
            for(i=i;i<=z;i++) 
            {  
             for(x=2;x<=i;x++) 
             { 
              if(i%x==0) 
              break; 
             } 
             if(i==x) 
             Console.WriteLine(i);
            }
        }
    }
}