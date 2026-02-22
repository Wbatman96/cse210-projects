using System;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        Menu menu = new Menu(journal, promptGenerator);
        menu.Display();
    }
}