using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWinForm.Data.Entities
{
    [Table("tblUsers")]
    public class UserEntity
    {
        [Key]
        public int ID { get; set; }

        [Required, StringLength(256)]
        public string Username { get; set; }

        [Required, StringLength(128)]
        public string Nickname { get; set; }

        [Required, StringLength(256), RegularExpression(@"^(?=.*[0-9])(?=.*[A-Za-z]).{8,}$")]
        public string Password { get; set; }

        [StringLength(2048)]
        public string Picture { get; set; }

        [Required, StringLength(128)]
        public string IP { get; set; }

    }

    

}
