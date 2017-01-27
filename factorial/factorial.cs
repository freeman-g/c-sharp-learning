using System;

public class Factorial {
	
	//Using the C# language, have the function FirstFactorial(num) take the num parameter 
	//being passed and return the factorial of it (e.g. if num = 4, return (4 * 3 * 2 * 1)). 
	//For the test cases, the range will be between 1 and 18 and the input will always be an integer. 

	public static void Main() {

		int actual = FirstFactorial(2);
		int expected = 2;
		if (actual != expected) {
			Console.WriteLine("Expected " + expected + " but was " + actual);
		}


		actual = FirstFactorial(3);
		expected = 6;

		if (actual != expected) {
			Console.WriteLine("Expected " + expected + " but was " + actual);
		}

		actual = FirstFactorial(5);
		expected = 120;

		if (actual != expected) {
			Console.WriteLine("Expected " + expected + " but was " + actual);
		}

	}

	private static int FirstFactorial(int i) {
		
		int answer = 1;

		for (int j = 1; j <= i; j++) {
			answer *= j;
		}

		return answer;

	}
}