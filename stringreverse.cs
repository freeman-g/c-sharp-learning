using System;
 
public class StringReverse
{

	//reverse a string and test the result
    public static void Main ()
    {

    	string actual = Reverse("world");
    	string expected = ("dlrow");

    	if (actual == expected) {
    		Console.WriteLine("Pass");
    		} else {
    			Console.WriteLine("Error:  Expected " + expected + " but was " + actual);
    		}

    }

    private static string Reverse(string s) {

    	string reversed = null;

    	for (int i = 0; i < s.Length; i++)
        {
        	reversed = s[i] + reversed;
        }

    	return reversed;
    }
}