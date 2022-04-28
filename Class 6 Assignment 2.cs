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
        	bool flag = false;
		    while (flag == false)
		    {
	        	Console.Write("Enter a number: ");
			    int number = Int32.Parse(Console.ReadLine());
		    
		    	int check = 0;
		    	check = number % (3 * 7);
		    	if (check == 0)
		    	{
		    		Console.Write("The number {0}, is divisible by 3 and 7", number);
		    		flag=true;
		    	}
		    	else
		    	{
		    		Console.Write("The number {0}, is not divisible by 3 and 7, please try another number", number);
		    	}
		    }
        }
    }
}