using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagment.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Rating { get; set; }

    }
}
