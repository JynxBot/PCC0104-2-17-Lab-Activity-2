using System;

class Program {
  public static void Main (string[] args) {
    string joint = "";
    string word;
    do{
      Console.Write("Enter Something: ");
      word = Console.ReadLine();
      joint += word + " ";
      Console.WriteLine(joint);
    } while (word != "exit");
    Console.WriteLine("Closing Program...");
  }
}