using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoOtomasyonV2.Data
{
    public class UrunStok
    {
        [Key]
        public int Id { get; set; }

        public int StokMiktari { get; set; }

        [ForeignKey("UrunVaryasyon")]
        public int UrunVaryasyonId { get; set; }
        public virtual UrunVaryasyon UrunVaryasyon { get; set; }
    }
}
