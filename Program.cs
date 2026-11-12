namespace _1_LinqTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {

             //--------------- part1 - 1-------------

            //var books1 = LibraryData.BookList.Where(b => b.CopiesInStock > 0);
            var books1 = from b in LibraryData.BookList
                         where b.CopiesInStock > 0
                         select b;
            //foreach (var book in books)
            //{
            //    Console.WriteLine(book);
            //}



           

            //--------------- part1 - 2-------------

            //var books2 = LibraryData.BookList.Where(b=> b.Genre == "Programming" && b.CopiesInStock > 0);
            var books2 = from b in LibraryData.BookList
                         where b.Genre == "Programming" && b.CopiesInStock > 0
                         select b;

            //foreach (var item in books2)
            //{
            //    Console.WriteLine(item);
            //}


            //--------------- part1 - 3-------------
            //var books3 = LibraryData.BookList.Where(b => b.Title.StartsWith('C'));
            var books3 =  from b in LibraryData.BookList
                          where b.Title.StartsWith('C')
                          select b;
            //foreach (var item in books3)
            //{
            //    Console.WriteLine(item);
            //}


            //--------------- part2 - 4-------------

            //var bookTitles = LibraryData.BookList.Select(b => b.Title);
            var bookTitles= from b in LibraryData.BookList
                            select b.Title;

            //foreach (var item in bookTitles)
            //Console.WriteLine(item);

            //--------------- part2 - 5-------------
            //var books5 = LibraryData.BookList.Select(b => new
            //{
            //    Id = b.BookId,
            //    Title = b.Title
            //});

            var books5 = from b in LibraryData.BookList
                         select new
                         {
                             Id = b.BookId,
                             Title = b.Title
                         };

            //foreach (var item in books5)
            //{
            //    Console.WriteLine(item);
            //}


            //--------------- part2 - 6-------------
            //var books6 =LibraryData.BookList.Select(b => $"{b.BookId} {b.Title} - {b.Genre} "); 
            var books6 = from b in LibraryData.BookList
                         select $"{b.BookId} {b.Title} - {b.Genre} ";

            //foreach (var item in books6)
            //{
            //    Console.WriteLine(item);
            //}

            //--------------- part3 - 7-------------
            //var loans1 = LibraryData.MemberList.SelectMany(m => m.Loans);
            var loans1 = from m in LibraryData.MemberList
                         from l in m.Loans
                         select l;

                                  // *************** not correct *****************
            //var loans1 = from m in LibraryData.MemberList
            //             select m.Loans; // -- return List<loan> as objects -- number of objects = number of members
          
            //foreach (var item in loans1)
            //{
            //    Console.WriteLine(item);
            //}


            // --------------- part3 - 8-------------
            //var loans2 = LibraryData.MemberList.Where(m => m.City=="Cairo").SelectMany(m => m.Loans);
            var  loans2 = from m in LibraryData.MemberList
                          where m.City == "Cairo"
                          from l in m.Loans
                          select l;

            //foreach (var item in loans2)
            //{
            //    Console.WriteLine(item);
            //}

            // --------------- part3 - 9-------------
            var loans3 = LibraryData.MemberList.Select(m => m.Loans);
            //var loans3 = from m in LibraryData.MemberList       
            //select m.Loans;

            //foreach (var item in loans3)
            //    Console.WriteLine(item);

            //IEnumerable<IEnumerable<Loan>> vs IEnumerable<Loan>.
            // IEnumerable<IEnumerable<Loan>> ---> this will return list of list of loans for each member /---> need to access each list to access every loan in it.
            // IEnumerable<Loan> ---> this will return list of loans for all members --------> give me all loans of all members

            // -------------- --- part4 - 10-------------
            var books7 = LibraryData.BookList.Where(b => b.BookId > 35);
            LibraryData.BookList.Add(new Book { BookId = 41, Title = "C# in Depth", Genre = "Programming", CopiesInStock = 5 });
            //foreach (var item in books7)
            //{
            //    Console.WriteLine(item);
            //}
            //                                    Did the new book appear? Why ?
            // yes new book appear , because it is Deffered Execution ---> the Query executed wen it is called not before it 

            // -------------- --- part4 - 11-------------

            var books8 = LibraryData.BookList.Where(b => b.BookId > 35).ToList();
            LibraryData.BookList.Add(new Book { BookId = 42, Title = "C## in Depth", Genre = "Programming", CopiesInStock = 55 });
            foreach (var item in books8)
            {
                Console.WriteLine(item);
            }

            var books = LibraryData.BookList.ToList();
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
            //                  Compare the result.
            // new book not appear because it is Imediate Execution/Eager ---> the Query executed when it is called and the result stored in memory and not affected by any changes after that.
        }
    }
}
