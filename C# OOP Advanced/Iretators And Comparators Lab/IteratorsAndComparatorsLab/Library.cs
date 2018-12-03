﻿namespace IteratorsAndComparators
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        //public void Sort()
        //{
        //    this.books = this.books.OrderBy(x => x.Year).ToList();
        //}

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
        


        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books); 
            }

            public Book Current => this.books[this.currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose() { }


            public bool MoveNext() => ++this.currentIndex < this.books.Count;
            
            

            public void Reset()
            {
                this.currentIndex = -1;
            }
        }
    }
}
