//
//Author: James Anthony Ortiz
//Date: 04/16/2021
//Description: 
//


using System;

namespace ExquisiteCorpse
{
      class Program
    {
        static void Main(string[] args)
        {
        /*
        GhostHead();
        GhostBody();
        GhostFeet();
        */

        //BuildACreature("ghost", "monster", "bug");
        //SwitchCase(1,1,1);
        RandomMode();

        
        }

        static void BuildACreature(string head, string body, string feet){
        string lhead = head.ToLower();
        string lbody = body.ToLower();
        string lfeet = feet.ToLower();
        int headNum, bodyNum, feetNum;

        headNum = TranslateToNumber(head);
        bodyNum = TranslateToNumber(body);
        feetNum = TranslateToNumber(feet);

        SwitchCase(headNum, bodyNum, feetNum);
        }

        static void RandomMode(){
        Random randomnumber = new Random();
        int randomHead = randomnumber.Next(1, 4);
        int randomBody = randomnumber.Next(1, 4);
        int randomFeet = randomnumber.Next(1, 4);

        SwitchCase(randomHead, randomBody, randomFeet);
        
        
        }

        static void SwitchCase(int head, int body, int feet){
        switch(head){
            case 1: GhostHead();
            break;
            case 2: BugHead();
            break;
            case 3: MonsterHead();
            break;
            default:Console.WriteLine("Wrong Input, please try again...");
            break;
        }

        switch(body){
            case 1: GhostBody();
            break;
            case 2: BugBody();
            break;
            case 3: MonsterBody();
            break;
            default:Console.WriteLine("Wrong Input, please try again...");
            break;

        }

        switch(feet){
            case 1: GhostFeet();
            break;
            case 2: BugFeet();
            break;
            case 3: MonsterFeet();
            break;
            default:Console.WriteLine("Wrong Input, please try again...");
            break;
        }
        }

        static int TranslateToNumber(string creature){
        switch(creature){
            case "ghost": return 1;
            break;
            case "bug": return 2;
            break;
            case "monster": return 3;
            break;
            default: return 1;
            break;
        }

        return 1;
        }

        static void GhostHead()
        {
        Console.WriteLine("     ..-..");
        Console.WriteLine("    ( o o )");
        Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
        Console.WriteLine("    |     |");
        Console.WriteLine("    |     |");
        Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
        Console.WriteLine("    |     |");
        Console.WriteLine("    |     |");
        Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
        Console.WriteLine("     /   \\");
        Console.WriteLine("     \\. ./");
        Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
        Console.WriteLine("  --|  |  |--");
        Console.WriteLine("  --|  |  |--");
        Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
        Console.WriteLine("     v   v");
        Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
        Console.WriteLine("     _____");
        Console.WriteLine(" .-,;='';_),-.");
        Console.WriteLine("  \\_\\(),()/_/");
        Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
        Console.WriteLine("   ,-/`~`\\-,___");
        Console.WriteLine("  / /).:.('--._)");
        Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
        Console.WriteLine("    |  Y  |");
        Console.WriteLine("   /   |   \\");
        Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
  }
}
