using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_advanced___homework.Exercise2
{
    internal class Book
    {
        private string _title;
        private string _author;
        private int _pageCount;
        private int _currentPage;

        public Book(string title, string author, int pageCount)
        {
            _title = title;
            _author = author;
            _pageCount = pageCount;
            _currentPage = 1;
          
        }

        public string Title { get { return _title; } set { _title = value; } }
        public string Author { get { return _author; } set { _author = value; } }


        public string GetTitle()
        {
            return Title;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public int GetPageCount()
        {
            return _pageCount;
        }

        public int GetCurrentPage()
        {
            return _currentPage;
        }

        public int NextPage()
        {
            return _currentPage++;
        }

        public int PreviousPage()
        {
            return _currentPage--;
        }
    }
}
