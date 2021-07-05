using System;
using System.Linq; 

class MainClass {
  public static void Main (string[] args) {

    int[] total = new int[10];
    int evencounter = 0;
    int oddcounter = 0;
    
    for (int i = 0; i < total.Length; i++) {
      Console.WriteLine("Enter a number");
      int entry = Convert.ToInt32(Console.ReadLine());
      total[i] = entry;
      if (total[i] % 2 == 0) {
        //determine size of even array
        evencounter++;
      } else {
        //determine size of odd array
        oddcounter++;
      }
       
     } 
     //evencounter does not work when input as size for int[] EvenNum, so i had to multiply it by two for it to work
     int evenarraysize = evencounter * 2;
     //oddcounter does not work when input as size for int[] OddNum, so i had to multiply it by two for it to work
     int oddarraysize = oddcounter * 2;
     int[] EvenNum = new int[evenarraysize];
     int[] OddNum = new int[oddarraysize];
     
     for (int i = 0; i < total.Length; ++i) {
       if (total[i] % 2 == 0) {
         EvenNum[i] = total[i];
       } else {
         OddNum[i] = total[i];        
       }
     } 
     Array.Sort(EvenNum);
     Console.WriteLine("Here's the even number array in ascending order:");
     foreach (int x in EvenNum)
     {
       Console.WriteLine(x);
     }
     Array.Reverse(OddNum);
     Console.WriteLine("Here's the odd number array in descending order:");
     foreach (int x in OddNum)
     {
       Console.WriteLine(x);
     }
     Console.WriteLine("The sum of the odd numbers is " + OddNum.Sum());
     Console.WriteLine("The sum of the even numbers is " + EvenNum.Sum());


    
  }
}