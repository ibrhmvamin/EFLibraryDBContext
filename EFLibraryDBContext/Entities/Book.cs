using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibraryDBContext.Entities
{
    public class Book: BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public ICollection<Student> Students { get; set; }
        public Author Author { get; set; }
        public int AuthorID { get; set; }
        public BookType BookType { get; set; }
        public int BookTypeID { get; set; }
    }
}
