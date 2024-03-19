using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoggerTempAndVibrationDemo.Model
{
    public class SettingDevice
    {
        public int MinTemp {  get; set; }
        public int MaxTemp { get; set; }
        public int MinVib {  get; set; }
        public int MaxVib { get; set; }
        public int CalibTemp {  get; set; }
        public int CalibVib { get; set; }

    }
}
