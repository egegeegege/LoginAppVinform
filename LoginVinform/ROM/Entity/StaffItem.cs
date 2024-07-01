using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginVinform.ROM.Entity
{
    public class StaffItem : BaseEntity
    {
        [Required]
        public string KullanıcıAdı { get; set; }
        [Required]
        public string TelefonNo { get; set; }
        [Required]
        public string Sifre { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Adres { get; set; }
        List<UserItem> UserItems = new List<UserItem>();
    }
}
