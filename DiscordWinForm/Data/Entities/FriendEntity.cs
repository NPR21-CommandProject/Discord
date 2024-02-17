using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordWinForm.Data.Entities
{
    [Table("tblFriends")]
    public class FriendEntity
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Friend1")]
        public int Friend1ID { get; set; }

        [ForeignKey("Friend2")]
        public int Friend2ID { get; set; }

        public virtual UserEntity Friend1 { get; set; }
        public virtual UserEntity Friend2 { get; set; }
    }
}
