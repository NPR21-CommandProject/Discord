using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Data.Entities
{
    [Table("tblUsers")]
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Email { get; set; }
        [Required, StringLength(20)]
        public string Password { get; set; }
        public string Phone { get; set; }
        [Required, StringLength(255)]
        public string FirstName { get; set; }
        [Required, StringLength(200)]
        public string LastName { get; set; }
        [Required, StringLength(20)]
        public DateTime DateCreated { get; set; }
    }
}
