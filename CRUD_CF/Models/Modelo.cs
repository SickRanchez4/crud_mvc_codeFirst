using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;


namespace CRUD_CF.Models
{
    public class Modelo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Description { get; set; }

        public int FileSize { get; set; }

        public string FileName { get; set; }

        public byte[] FileData { get; set; }

        [NotMapped]
        public HttpPostedFileBase File { get; set; }
        
    }
}