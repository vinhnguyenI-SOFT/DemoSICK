using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoggerTempAndVibrationDemo.Model
{
    public class MasterData : DataContext
    {
        [Key]
        public int Id { get; set; }
        public string NameDevice { get; set; }
        public double TempValue { get; set; }
        public double VibrValue { get; set; }
        public DateTime Updated { get; set; }

    }
}
