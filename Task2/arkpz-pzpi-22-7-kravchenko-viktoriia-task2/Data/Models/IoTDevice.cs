using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaTrack.Data.Models
{
    public class IoTDevice
    {
        [Key]
        public int DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string Status { get; set; }

        // Зв’язок із таблицею Limits
        public ICollection<Limit> Limits { get; set; }
    }
}
