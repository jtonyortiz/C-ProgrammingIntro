//
//Author: James Anthony Ortiz
//Date: 04/13/2021
//Description: A password checker program implmented with C#
//This program takes in imput from the user and ranks the 
//quality of the password from input.

using PasswordChecker; //Useing the Class "Tools" in the Tools.cs file.
using System; //Used for System I/O

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "#?!";


      Console.WriteLine("Please enter a password: ");
      string passwordInput = Console.ReadLine();
      int score = 0;

      //Check for minimum length in the input:
      if(passwordInput.Length >= minLength){
        score++;
      }

      //Check for uppercase letters in input:
      if(Tools.Contains(passwordInput, uppercase)){
        score++;
      }

      //Check for lowercase letters in input:
      if(Tools.Contains(passwordInput, lowercase)){
        score++;
      }

      //Check for digits in input:
      if(Tools.Contains(passwordInput, digits)){
        score++;
      }

      if(Tools.Contains(passwordInput, specialChars)){
        score++;
      }

      if(passwordInput == "password" || passwordInput == "1234"){
        score = 0;
      }

      switch(score){
        case 5: 
          Console.WriteLine("Password is extremely strong");
        break;
        case 4:
          Console.WriteLine("Password is extremely strong");
        break;
        case 3:
          Console.WriteLine("password is strong");
        break;
        case 2:
          Console.WriteLine("password is medium");
        break;
        case 1:
          Console.WriteLine("password is weak");
        break;
        default:
          Console.WriteLine("Password doesn't meet any of the standards");
        break;
      }      

    }
  }
}
