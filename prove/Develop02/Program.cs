using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();

        PromptGen prompt1 = new PromptGen();

        Entry entry1 = new Entry();

        prompt1.GivePrompt();

    }
}