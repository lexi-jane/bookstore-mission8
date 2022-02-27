using System;
namespace Bookstore.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPage { get; set; }

        //calculates how many pages are needed
        public int TotalPages => (int) Math.Ceiling((double) TotalNumBooks / BooksPerPage);




    }
}
