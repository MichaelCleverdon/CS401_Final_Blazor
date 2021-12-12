using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS401_Final_Blazor.Data
{
    public class BlogModel
    {
        public BlogModel()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
    }
}
