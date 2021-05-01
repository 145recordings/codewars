/*
Welcome. In this kata, you are asked to square every digit of a number and concatenate them.

For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

Note: The function accepts an integer and returns an integer

Solution:
*/




using System;

public class Kata
{
  public static int SquareDigits(int x)
  {
    string temp = "";
    string y = x.ToString();
            
    //for every digit in y, convert it into an int
    //multiply that int by itself to gain the square root
    //and store that number in a string
    for(int i = 0; i < y.Length; i++)
    {
      int z = Int32.Parse(y.Substring(i,1));                
      z = z * z;
      temp = temp + z;
    }
            
    //convert that string to in int and return it
    int final = Convert.ToInt32(temp);

    return final; 
    
    
  }
}
