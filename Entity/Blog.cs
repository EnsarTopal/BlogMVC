using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entity
{
    public class Blog
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public string Detail { get; set; }

        public bool isPopular { get; set; }

        public bool isPublish { get; set; }

        public DateTime PublishDate { get; set; }

        public Category category { get; set; }

        public int category_Id { get; set; }
        
        public Author author { get; set; }

        public int Author_id { get; set; }

        //public Yorum Comment { get; set; }

        //public int comment_ıd { get; set; }

    }
}
