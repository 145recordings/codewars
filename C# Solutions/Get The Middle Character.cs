/* 
You are going to be given a word. Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.

#Examples:

Kata.getMiddle("test") should return "es"

Kata.getMiddle("testing") should return "t"

Kata.getMiddle("middle") should return "dd"

Kata.getMiddle("A") should return "A"
#Input

A word (string) of length 0 < str < 1000 (In javascript you may get slightly more than 1000 in some test cases due to an error in the test cases). You do not need to test for this. This is only here to tell you that you do not need to worry about your solution timing out.

#Output

The middle character(s) of the word represented as a string.

Solution:
*/

using System;

public class Kata
{
  string s;
  
  public Kata(string s){
    this.s = s;
    
  }
  
  
  public static string GetMiddle(string s)
  {
    if(s.Length % 2 == 0)
            {
                double temp = (double)s.Length / 2.0;

                int x = (int)temp;

                string partone = Char.ToString(s[x - 1]);
                string parttwo = Char.ToString(s[x]);

                string result = partone + parttwo;               

                return result;
            }
            else
            {
                double temp = (double)s.Length / 2.0;
                Math.Round(temp,0, MidpointRounding.AwayFromZero);
                int n = (int)temp;

                char C = s[n];
                string S = Char.ToString(C);


                return S;
                
            }
  }
  
  
}