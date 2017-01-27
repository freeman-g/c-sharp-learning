using System;

public class FizzBuzz {
	
	//Write a program that prints the numbers from 1 to 100. 
	//But for multiples of three print “Fizz” instead of the number 
	//and for the multiples of five print “Buzz”. 
	//For numbers which are multiples of both three and five print “FizzBuzz”."

	public static void Main() {

		for (int i = 1; i <= 100; i++) {

			string fizzBuzz = getFizzBuzz(i);

			if (fizzBuzz != null) {
				Console.WriteLine(fizzBuzz);
			} else {
				Console.WriteLine(i);
			}
			
		}
	}

	private static string getFizzBuzz(int i) {
		
		if (i % 3 == 0 && i % 5 == 0) {
			return "FizzBuzz";
		}

		if (i % 3 == 0) {
			return "Fizz";
		} 

		if (i % 5 == 0) {
			return "Buzz";
		}

		return null;

	}
}