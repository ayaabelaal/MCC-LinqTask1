using System;
using System.Collections.Generic;
using System.Text;

namespace _1_LinqTask1
{
    class Book
    {
        public long BookId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int CopiesInStock { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is not Book upcoming)
                return false;

            if (BookId == upcoming.BookId
                && Title == upcoming.Title
                && Genre == upcoming.Genre
                && Price == upcoming.Price
                && CopiesInStock == upcoming.CopiesInStock)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.BookId.GetHashCode() ^ this.Title.GetHashCode()
               ^ this.Genre.GetHashCode()
               ^ this.Price.GetHashCode()
               ^ this.CopiesInStock.GetHashCode();
        }

        public override string ToString()
            => $"BookId:{BookId},Title:{Title},Genre :: {Genre},Price:{Price},CopiesInStock:{CopiesInStock}";

    }
    class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Loan[] Loans { get; set; }
        public Member(int memberID, string memberName)
        {
            Id = memberID;
            Name = memberName;
            Loans = new Loan[10];
        }
        public Member()
        {

        }
        public override string ToString()
            => $"{Id}, {Name}, {Address}, {City}, {PostalCode}, {Country}, {Phone}, {Email}";
    }
    class Loan
    {
        public int Id { get; set; }
        public DateTime LoanDate { get; set; }
        public double Fee { get; set; }

        public Loan(int loanID, DateTime loanDate, double fee)
        {
            Id = loanID;
            LoanDate = loanDate;
            Fee = fee;
        }
        public Loan()
        {

        }

        public override string ToString()
            => $"Loan Id: {Id}, Date: {LoanDate.ToShortDateString()}, Fee: {Fee}";
    }
    internal static class LibraryData
    {
        public static List<Book> BookList { get; set; }
        public static List<Member> MemberList { get; set; }

        static LibraryData()
        {
            BookList = new List<Book>()
            {
              new Book { BookId = 1, Title = "Clean Code", Genre = "Programming", Price = 45.00M, CopiesInStock = 12 },
              new Book { BookId = 2, Title = "The Pragmatic Programmer", Genre = "Programming", Price = 50.00M, CopiesInStock = 8 },
              new Book { BookId = 3, Title = "C# in Depth", Genre = "Programming", Price = 55.5000M, CopiesInStock = 6 },
              new Book { BookId = 4, Title = "Design Patterns", Genre = "Programming", Price = 60.0000M, CopiesInStock = 4 },
              new Book { BookId = 5, Title = "Refactoring", Genre = "Programming", Price = 52.7500M, CopiesInStock = 0 },
              new Book { BookId = 6, Title = "Introduction to Algorithms", Genre = "Programming", Price = 89.9900M, CopiesInStock = 3 },
              new Book { BookId = 7, Title = "A Brief History of Time", Genre = "Science", Price = 18.5000M, CopiesInStock = 20 },
              new Book { BookId = 8, Title = "Cosmos", Genre = "Science", Price = 22.0000M, CopiesInStock = 14 },
              new Book { BookId = 9, Title = "The Selfish Gene", Genre = "Science", Price = 19.9900M, CopiesInStock = 9 },
              new Book { BookId = 10, Title = "Sapiens", Genre = "History", Price = 27.0000M, CopiesInStock = 31 },
              new Book { BookId = 11, Title = "Guns, Germs, and Steel", Genre = "History", Price = 25.5000M, CopiesInStock = 11 },
              new Book { BookId = 12, Title = "The Silk Roads", Genre = "History", Price = 30.0000M, CopiesInStock = 7 },
              new Book { BookId = 13, Title = "Ancient Egypt: A Short History", Genre = "History", Price = 16.2500M, CopiesInStock = 25 },
              new Book { BookId = 14, Title = "The Fall of Constantinople", Genre = "History", Price = 21.0000M, CopiesInStock = 0 },
              new Book { BookId = 15, Title = "Children of the Alley", Genre = "Fiction", Price = 14.0000M, CopiesInStock = 40 },
              new Book { BookId = 16, Title = "The Yacoubian Building", Genre = "Fiction", Price = 15.5000M, CopiesInStock = 33 },
              new Book { BookId = 17, Title = "Palace Walk", Genre = "Fiction", Price = 17.7500M, CopiesInStock = 18 },
              new Book { BookId = 18, Title = "1984", Genre = "Fiction", Price = 12.0000M, CopiesInStock = 50 },
              new Book { BookId = 19, Title = "Brave New World", Genre = "Fiction", Price = 12.5000M, CopiesInStock = 28 },
              new Book { BookId = 20, Title = "The Alchemist", Genre = "Fiction", Price = 11.0000M, CopiesInStock = 60 },
              new Book { BookId = 21, Title = "One Hundred Years of Solitude", Genre = "Fiction", Price = 16.0000M, CopiesInStock = 15 },
              new Book { BookId = 22, Title = "Crime and Punishment", Genre = "Fiction", Price = 13.5000M, CopiesInStock = 0 },
              new Book { BookId = 23, Title = "Atomic Habits", Genre = "Self-Development", Price = 24.0000M, CopiesInStock = 45 },
              new Book { BookId = 24, Title = "Deep Work", Genre = "Self-Development", Price = 23.0000M, CopiesInStock = 22 },
              new Book { BookId = 25, Title = "Thinking, Fast and Slow", Genre = "Self-Development", Price = 26.5000M, CopiesInStock = 17 },
              new Book { BookId = 26, Title = "The 7 Habits of Highly Effective People", Genre = "Self-Development", Price = 20.0000M, CopiesInStock = 35 },
              new Book { BookId = 27, Title = "Man's Search for Meaning", Genre = "Self-Development", Price = 13.0000M, CopiesInStock = 29 },
              new Book { BookId = 28, Title = "Mindset", Genre = "Self-Development", Price = 18.0000M, CopiesInStock = 0 },
              new Book { BookId = 29, Title = "The Little Prince", Genre = "Children", Price = 9.5000M, CopiesInStock = 70 },
              new Book { BookId = 30, Title = "Charlotte's Web", Genre = "Children", Price = 8.7500M, CopiesInStock = 38 },
              new Book { BookId = 31, Title = "Matilda", Genre = "Children", Price = 9.0000M, CopiesInStock = 0 },
              new Book { BookId = 32, Title = "Kalila and Dimna for Kids", Genre = "Children", Price = 7.5000M, CopiesInStock = 55 },
              new Book { BookId = 33, Title = "The Gruffalo", Genre = "Children", Price = 6.9900M, CopiesInStock = 42 },
              new Book { BookId = 34, Title = "Where the Wild Things Are", Genre = "Children", Price = 8.0000M, CopiesInStock = 19 },
              new Book { BookId = 35, Title = "Pro ASP.NET Core", Genre = "Programming", Price = 65.0000M, CopiesInStock = 5 },
              new Book { BookId = 36, Title = "Entity Framework Core in Action", Genre = "Programming", Price = 58.0000M, CopiesInStock = 0 },
              new Book { BookId = 37, Title = "The Phoenix Project", Genre = "Programming", Price = 28.0000M, CopiesInStock = 13 },
              new Book { BookId = 38, Title = "Astrophysics for People in a Hurry", Genre = "Science", Price = 15.0000M, CopiesInStock = 26 },
              new Book { BookId = 39, Title = "The Gene: An Intimate History", Genre = "Science", Price = 29.0000M, CopiesInStock = 10 },
              new Book { BookId = 40, Title = "The History of Cairo", Genre = "History", Price = 34.5000M, CopiesInStock = 2 }

            };

            MemberList = new List<Member>()
            {
                 new Member
            {
                Id = 101,
                Name = "Omar Hassan",
                Address = "12 Tahrir Street",
                City = "Cairo",
                PostalCode = "11511",
                Country = "Egypt",
                Phone = "02-25761234",
                Email = "omar.hassan@example.com",
                Loans = new Loan[]
                {
                    new Loan { Id = 5001, LoanDate = new DateTime(2024, 1, 14), Fee = 15.50 },
                    new Loan { Id = 5007, LoanDate = new DateTime(2024, 2, 3), Fee = 8.00 },
                    new Loan { Id = 5013, LoanDate = new DateTime(2024, 3, 21), Fee = 22.75 },
                    new Loan { Id = 5026, LoanDate = new DateTime(2024, 5, 9), Fee = 5.00 },
                    new Loan { Id = 5031, LoanDate = new DateTime(2024, 6, 30), Fee = 12.25 },
                }
            },
            new Member
            {
                Id = 102,
                Name = "Salma Mostafa",
                Address = "45 Corniche El Nil",
                City = "Alexandria",
                PostalCode = "21500",
                Country = "Egypt",
                Phone = "03-48675432",
                Email = "salma.mostafa@example.com",
                Loans = new Loan[]
                {
                    new Loan { Id = 5004, LoanDate = new DateTime(2024, 1, 28), Fee = 10.00 },
                    new Loan { Id = 5019, LoanDate = new DateTime(2024, 4, 2), Fee = 18.40 },
                    new Loan { Id = 5022, LoanDate = new DateTime(2024, 4, 25), Fee = 6.60 },
                    new Loan { Id = 5035, LoanDate = new DateTime(2024, 7, 11), Fee = 30.00 },
                }
            },
            new Member
            {
                Id = 0, // Default value for non-integer ID
                Name = "Youssef Kamal",
                Address = "7 Al-Geish Road",
                City = "Mansoura",
                PostalCode = "35511",
                Country = "Egypt",
                Phone = "050-2234455",
                Loans = new Loan[]
                {
                    new Loan { Id = 5009, LoanDate = new DateTime(2024, 2, 12), Fee = 9.75 },
                    new Loan { Id = 5015, LoanDate = new DateTime(2024, 3, 29), Fee = 14.20 },
                    new Loan { Id = 5020, LoanDate = new DateTime(2024, 4, 15), Fee = 27.00 },
                    new Loan { Id = 5028, LoanDate = new DateTime(2024, 5, 20), Fee = 11.30 },
                    new Loan { Id = 5033, LoanDate = new DateTime(2024, 7, 2), Fee = 19.90 },
                    new Loan { Id = 5038, LoanDate = new DateTime(2024, 8, 8), Fee = 7.45 },
                }
            }
            };
        }
    }
        }
