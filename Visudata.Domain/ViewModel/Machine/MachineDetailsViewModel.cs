﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI.Domain.ViewModel.Machine
{
    public class MachineDetailsViewModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string SerialNumber { get; set; }
        public string Tag { get; set; }
        public string StatusName { get; set; }
        public double RealTimeTemp { get; set; }
        public double RealTimeVibration { get; set; }
        public double RealTimeNoise { get; set; }
        
    }
}