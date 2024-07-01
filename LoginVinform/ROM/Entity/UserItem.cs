using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace LoginVinform.ROM.Entity
{
    public class UserItem : BaseEntity
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
        List<StaffItem> StaffItems = new List<StaffItem>();
    }
}
