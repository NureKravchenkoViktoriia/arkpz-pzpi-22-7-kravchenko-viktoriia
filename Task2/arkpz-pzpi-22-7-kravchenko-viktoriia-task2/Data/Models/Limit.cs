using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquaTrack.Data.Models
{
    public class Limit
    {
        [Key]
        public int LimitId { get; set; }           // Унікальний ідентифікатор ліміту
        public decimal LimitValue { get; set; }   // Максимальне значення споживання води
        public DateTime StartDate { get; set; }   // Дата початку дії ліміту
        public DateTime EndDate { get; set; }     // Дата закінчення дії ліміту

        // Зовнішні ключі
        public int UserId { get; set; }           // Зв'язок із користувачами
        public User User { get; set; }            // Навігаційна властивість

        public int DeviceId { get; set; }         // Зв'язок із IoT-пристроями
        public IoTDevice IoTDevice { get; set; }  // Навігаційна властивість
    }
}
