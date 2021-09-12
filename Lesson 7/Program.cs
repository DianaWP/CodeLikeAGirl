using System;
using System.Collections.Generic;

namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var member1 = new Member  {
                firstName = "Diana",
                lastName = "McKinlay", 
                favouriteBook  = "The Lost Get back boogie",
            }; 

            var member2 = new Member {
                firstName = "Nicholas",
                lastName = "Londey",
                favouriteBook = "Honor Harrington",
            };

            var member3 = new Member {
                firstName = "Brian",
                lastName = "McKinlay",
                favouriteBook = "The Night Fire",
            };

            var  member4 = new Member {
                firstName = "Gillian",
                lastName = "McKinlay",
                favouriteBook = "The Yield",
            };
    

            var members = new List<Member> {
                member1, member2, member3, member4 
            };

            foreach (var member in members) {
                member.DisplayDetails(); 
            };

            var book1 = new Book {
                title = "Lost Get Back Boogie",
                author = "James Lee Burke",
            };
            
            var book2  = new Book {
                title = "The Steel Kiss",
                author = "Jeffery Deaver",
            };

            var book3  = new Book {
                title = "Cry Baby",
                author = "Mark Billingham",
            };

            var book4  = new Book {
                title = "Instead of a Letter",
                author = "Diana Athill",
            };

            var book5  = new Book {
                title = "Slow Days, Fast Company",
                author = "Eve Babitz",
            };

            var book6  = new Book {
                title = "All Who Live on Islands",
                author = "Rose Lu",
            };

            var books = new List<Book> {
                book1, book2, book3, book4, book5, book6
            };    

            foreach (var book in books) {
                book.DisplayDetails();
            };
        }

        public class Book {

            public string title;

            public string author;

            public void DisplayDetails() {
                Console.WriteLine($"Books we have in stock include {title} by {author}");
            }  

        };

        public class Member {

            public string firstName;

            public string lastName;

            public string favouriteBook;

            public void DisplayDetails() {
                Console.WriteLine($"Meet {firstName} {lastName} their favourite book is {favouriteBook}");
            }
        };
            
        
    }
}
