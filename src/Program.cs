using System;
using Muse.SourceLink.Library;

namespace Muse.SourceLink.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new Messenger().GenerateMessage("Somebody");
            Console.WriteLine(message);
        }
    }
}
