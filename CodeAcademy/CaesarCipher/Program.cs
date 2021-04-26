//
//Author: James Anthony Ortiz
//Date: 04/22/2021
//Description: An implementation of the Caesar Cipher, a program that  
//creates an encrypted message from input by shifting characters
//by 3 places, with english letters on a fixed cirular structure of characters
//
//



using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            string input;
            Console.WriteLine("Please enter a secret message: ");
            input = Console.ReadLine();
            input.ToLower(); //Place input to lower-case letters

            char[] secretMessage = input.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            //Loop through each character of secretMessage:
            for(int i = 0; i < secretMessage.Length; i++){
                char letter = secretMessage[i];

                //Find the position of the character in the 
                //index of the alphabet array
                int position = Array.IndexOf(alphabet,letter);
                
                //Incretment 3 to position - declared as new_position
                //Send the position around through the use of mod 26:
                int new_position = (position + 3) % 26;
                
                //Assign the newly encrepyted char in the alphbet array:
                char newEncrypted_char = alphabet[new_position];

                //Add encrypted char to array encryptedMessage:
                encryptedMessage[i] = newEncrypted_char;


            }

            string newMessage = String.Join("", encryptedMessage);

            Console.WriteLine($"The encrypted message is: {newMessage}");
        }
    }
}
