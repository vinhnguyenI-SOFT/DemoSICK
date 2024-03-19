using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataLoggerTempAndVibrationDemo.Model
{
    public class DeviceData : DbContext
    {
        public int DeviceId { get; set; }
        public string DiviceName { get; set; }
        public string DeviceCode { get; set; }
        public double TempValues { get; set; }
        public double VibrValues { get; set; }
        public double Shocks {get; set; }
    
    }
}
