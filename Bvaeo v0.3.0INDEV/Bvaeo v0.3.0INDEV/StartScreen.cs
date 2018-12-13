using System;
using System.Diagnostics;
namespace StartScreen
{
  class StartScreen
  {
    static void Main()
    {
      string Welcome = @"
      Bvaeo v1.1
      Copyright 2015-2016
      By Will Nilges
      Written in C# using Atom 1.6.0
      ";
      Console.WriteLine(Welcome);
      Console.WriteLine("Use the keyboard to select.");
      Console.WriteLine("1 - Battle | 2 - About | 3 - Exit");
      if (Console.Readkey("1"))
      {
        System.Diagnostic.Process.Start("BattleSelectScreen.exe");
      }
      else if (Console.ReadKey(2))
      {
        System.Diagnostic.Process.Start("AboutScreen");
      }
      else
      {
        Console.Exit();
      }
    }
  }
}
