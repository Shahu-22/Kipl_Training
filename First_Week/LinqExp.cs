using System;
using System.Collections.Generic;
using System.Linq;
class LinqExp{
    public static void Main(){
    List<int> numbers=new List<int>{1,2,3,4,5,6,7,8,9};

    //Finding even numbers
     Console.WriteLine("Even Numbers : ");
    var evens=numbers.Where(n=> n%2==0);
    foreach(var n in evens){
        Console.WriteLine(n);
    }
    Console.WriteLine("Odd Numbers : ");
    //Finding odd numbers
     var odd=from i in numbers where i%2!=0 select i;
      foreach(var i in odd){
        Console.WriteLine(i);
    } 
    
    //Greater than three
     Console.WriteLine("Greater than three Numbers : ");
    var greaterNum=numbers.Where(n=>n>3);
    foreach(var n in greaterNum){
        Console.WriteLine(n);
    }
      //Square each number
     Console.WriteLine("Squres Numbers : ");
    var Squares=numbers.Select(n=>n*n);
    foreach(var n in Squares){
        Console.WriteLine(n);
    }

    //Order by descending
     Console.WriteLine("Descending Numbers : ");
    var Rev=numbers.OrderByDescending(n=>n);
    foreach(var n in Rev){
        Console.WriteLine(n);
    }
    
    //FirstorDefault()
   Console.WriteLine("First Even Number : ");
   var FirstEven=numbers.FirstOrDefault(n=>n%2==0);
  Console.WriteLine("First Even Number : "+FirstEven);
}
}
