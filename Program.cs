using System;
using System.Collections.Generic;

namespace GestiuneBibloteca
{
 
    
    public abstract class User
    {
       
        protected string name;

        public User(string name)
        {
            this.name = name;
        }

        public abstract void DisplayInfo();
    }

   
    public class Member : User
    {
        private int memberId;

        public Member(string name, int id) : base(name)
        {
            this.memberId = id;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Member] Name: {name} | ID: {memberId}");
        }
    }

   
    public class Book
    {
        private string title;
        private string author;
        private bool isAvailable;

        public string Title => title;
        public bool IsAvailable
        {
            get => isAvailable;
            set => isAvailable = value;
        }

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.isAvailable = true;
        }
    }

    

    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Title = "Library Management System - UML Lab";

           
            Member currentMember = new Member("John Doe", 101);
            Book labBook = new Book("UML Distilled", "Martin Fowler");

            Console.WriteLine("== LIBRARY MANAGEMENT SYSTEM ===");
            currentMember.DisplayInfo();
            Console.WriteLine($"Checking availability for: {labBook.Title}...");
            Console.WriteLine("-");

         
            if (labBook.IsAvailable)
            {
               
                labBook.IsAvailable = false;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SUCCESS: The book has been successfully borrowed.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: The book is already checked out.");
            }

          
            Console.ResetColor();
            Console.WriteLine("------");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
