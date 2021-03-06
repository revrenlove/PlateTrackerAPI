﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PlateTracker.data.Models
{
    public partial class LineType
    {
        public LineType()
        {
            TankMeasurementTankTypes = new HashSet<TankMeasurementTankType>();
        }

        public int LineTypeId { get; set; }
        public string LineTypeName { get; set; }
        public string LineTypeDescription { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public DateTime DatetimeUpdated { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<TankMeasurementTankType> TankMeasurementTankTypes { get; set; }
    }
}
