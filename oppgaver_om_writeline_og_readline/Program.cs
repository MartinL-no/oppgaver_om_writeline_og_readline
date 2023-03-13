using System;

namespace oppgaver_om_writeline_og_readline
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hei, hva heter du?");

      var Name = Console.ReadLine();

      Console.WriteLine("Velkommen " + Name);

    }
  }
}