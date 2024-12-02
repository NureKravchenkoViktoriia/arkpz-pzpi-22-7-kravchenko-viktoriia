using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaTrack.Data.Models
{
    public class WaterUsage
    {
        [Key]
        public int UsageId { get; set; }         // Унікальний ідентифікатор запису
        public decimal UsageValue { get; set; } // Кількість спожитої води
        public DateTime Timestamp { get; set; } // Дата та час вимірювання

        // Зовнішній ключ
        public int DeviceId { get; set; }       // Зв'язок із IoT-пристроями
        public IoTDevice IoTDevice { get; set; } // Навігаційна властивість
    }
}
