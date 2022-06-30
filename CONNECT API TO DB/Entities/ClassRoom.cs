using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CONNECT_API_TO_DB.Entities
{
    public class ClassRoom
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "Varchar(20)")]
        public string? Name { get; set; }
        public Teacher Teacher { get; set; }    
    }
}
