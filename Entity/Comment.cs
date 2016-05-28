using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Comment
    {
        public int Id { get; set; }

        [DisplayName("Kullanıcı Adı")]
        public string Nickname { get; set; }

        [DisplayName("Yorum")]
        [Required(ErrorMessage = "Yorum boş geçilemez.")]
        public string yorum { get; set; }

        public List<Blog> BlogList { get; set; }

        [DisplayName("Yorum Yapılacak Kitap ")]
        [Required(ErrorMessage = "Kitap ismi boş geçilemez.")]
        public int Blog_Id { get; set; }

    }
}
