using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Authenticate.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [Column(TypeName="varchar(20)")]
        public string Kullanici { get; set; }
        [Column(TypeName ="varchar(10)")]
        public string sifre { get; set; }

    }
}
