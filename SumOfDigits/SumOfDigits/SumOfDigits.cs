using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SumOfDigits
{
	public class SumOfDigits
	{
		public static long sumMethod(long input)
		{

			/* 
			Given n, take the sum of the digits of n.If that value has more than one digit, 
			continue reducing in this way until a single-digit number is produced.
			This is only applicable to the natural numbers. 

			examples:

			16-- > 1 + 6 = 7
			 942-- > 9 + 4 + 2 = 15-- > 1 + 5 = 6
			132189-- > 1 + 3 + 2 + 1 + 8 + 9 = 24-- > 2 + 4 = 6
			493193-- > 4 + 9 + 3 + 1 + 9 + 3 = 29-- > 2 + 9 = 11-- > 1 + 1 = 2 
			*/



			long sum = input;
			int result = 0;

			while (sum.ToString().Length > 1) { 
				for (int i = 0; i < sum.ToString().Length; i++)
				{
					result += int.Parse(sum.ToString()[i].ToString());

				}
				sum = result;
				result = 0;
			}
			return sum;
		}		

	}

}

