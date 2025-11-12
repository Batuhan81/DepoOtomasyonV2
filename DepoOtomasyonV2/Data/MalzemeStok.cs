using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class MalzemeStok
    {
        [Key]
        public int Id { get; set; }

        public decimal StokMiktari { get; set; }

        [ForeignKey("Malzeme")]
        public int MalzemeId { get; set; }
        public virtual Malzeme Malzeme { get; set; }
    }
}
