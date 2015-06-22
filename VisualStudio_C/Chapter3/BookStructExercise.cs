using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualStudio_C.Chapter3 {
    class BookStructExercise {
        public struct Book {
            public string title;
            public string category;
            public string author;
            public int numberOfPages;
            public int currentPage;
            public string ISBN;
            public string coverStyle;

            public Book(string title, string category, string author, int numberOfPages, int currentPage, string ISBN,
                        string coverStyle) {
                this.title = title;
                this.category = category;
                this.author = author;
                this.numberOfPages = numberOfPages;
                this.currentPage = currentPage;
                this.ISBN = ISBN;
                this.coverStyle = coverStyle;
            }

            public void Nextpage() {
                this.currentPage++;
            }

            public void PreviousPage() {
                this.currentPage--;
            }
        }
        static void MainBookStructExercise(string[] args) {
            var book = new Book("Test Book", "Comedy", "Thiago Avelino", 500, 250, "ISBN-0903183", "cover style");
            Console.WriteLine(String.Format("Book Title: {0}", book.title));
            Console.WriteLine(String.Format("Book Category: {0}", book.category));
            Console.WriteLine(String.Format("Book Authr: {0}", book.author));
            Console.WriteLine(String.Format("Book Number Of Pages: {0}", book.numberOfPages));
            Console.WriteLine(String.Format("Book Current Page: {0}", book.currentPage));
            Console.WriteLine(String.Format("Book ISBN: {0}", book.ISBN));
            Console.WriteLine(String.Format("Book Cover Style: {0}", book.coverStyle));
            book.Nextpage();
            Console.WriteLine(String.Format("Book Current Page: {0}", book.currentPage));
            book.PreviousPage();
            Console.WriteLine(String.Format("Book Current Page: {0}", book.currentPage));
            Console.ReadKey();
        }
    }
}
