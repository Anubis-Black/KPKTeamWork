using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BalloonsPops
{
	public static class RandomGenerator
	{

		static Random randomGenerator = new Random();
		public static string GetRandomInt()
		{
			string legalChars = "1234";
			string builder = null;
			builder = legalChars[randomGenerator.Next(0, legalChars.Length)].ToString();
			return builder;
		}
	}
}
