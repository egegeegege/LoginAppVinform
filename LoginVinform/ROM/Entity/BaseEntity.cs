using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace LoginVinform.ROM.Entity
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool Aktifmi { get; set; }
    }
}
