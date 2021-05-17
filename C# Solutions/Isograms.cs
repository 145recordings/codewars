/*
An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether 
a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

isIsogram "Dermatoglyphics" == true
isIsogram "aba" == false
isIsogram "moOse" == false -- ignore letter case

Solution:
*/

using System;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    string myStr = str.ToLower();
    int counter = 0;
    
    for(int i = 0;i < myStr.Length; i++){
      for(int j = 0; j < myStr.Length; j++){
        if(myStr == null){
          return true;
        }
        
        if(myStr[i] == myStr[j]){
          counter = counter + 1;
        }                      
      }     
    }
     if(counter > myStr.Length){
          return false;
        }
        else 
          return true;
    
  }
}