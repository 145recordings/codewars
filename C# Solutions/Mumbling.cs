/*
This time no story, no theory. The examples below show you how to write function accum:

Examples:

accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"
The parameter of accum is a string which includes only letters from a..z and A..Z.

Solution:
*/


using System;

public class Accumul 
{
	public static String Accum(string s) 
  {
      s = s.ToLower();
        char[] S = new char[s.Length];
        string temp = "";

        //fills array S with the char of string s
        for (int i = 0; i < s.Length; i++)
        {
            S[i] = s[i];
        }
        //for every char in S
        for (int i = 0; i < S.Length; i++)
        {
            //x goes up to wherever i is at incrementally
            for(int x = 0; x <= i; x++)
            {
                //if x is 0 and i is 0. its the first incrementation and first char in S
                if(x == 0 && i == 0)
                {
                    temp = temp + char.ToUpper(S[i]);
                    temp = temp + "-";
                    continue;
                }
                //this accounts for the first char of every letter after the first letter
                if(x == 0 && i != 0)
                {
                    temp = temp + char.ToUpper(S[i]);
                    continue;
                }
                //if x is i, then its the last iteration of a letter, so the last letter is added to the string and a "-" is added
                else if(x == i)
                {
                    //do this as long as its not the very last char in S
                    if (i != S.Length - 1)
                    {
                        temp = temp + S[i];
                        temp = temp + "-";
                        break;
                    }
                }
                //if no if statements are triggered, its a middle letter
                temp = temp + S[i];
            }           
        }       
        return temp;
  }
}