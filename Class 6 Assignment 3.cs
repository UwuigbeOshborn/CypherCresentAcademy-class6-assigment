using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program 
    {
        public static void Main() 
        {
	        	Console.Write("Enter a number from range 1 to N: ");
			    int number = Int32.Parse(Console.ReadLine());
		    
		    	for(int i=1; i <= number; i++)
		    	{
			    	int check = 0;
			    	check = i % (7);
			    	int check2 = 0;
			    	check2 = i % (5*7);
			    	if ((check == 0) && (check2 != 0))
			    	{
			    		Console.Write("The number {0}, is divisible by 7\n", i);
			    	}
		    	}
        }
    }
}