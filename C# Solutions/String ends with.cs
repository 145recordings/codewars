/*
Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

Examples:

solution('abc', 'bc') // returns true
solution('abc', 'd') // returns false

Solution:
*/







public class Kata
{
  public static bool Solution(string str, string ending)
  {
     if(ending == ""){
        return true;
      }
    
    int counter = 0;
    //so str[] can start where ending would begin
    int x = str.Length - ending.Length;
    
    for(int i = 0; i < ending.Length; i++){
      
      if(str.Length < ending.Length){
        return false;
      }
             
      if(str[x] == ending[i]){
        //counting how many times we get a match
        counter++;
      }
      else{
        return false;
      }
      //if the amount of matche equals the whole length of ending return true
      if(counter == ending.Length){
        return true;
      }
      x++;
    }
    return false;
  }
}