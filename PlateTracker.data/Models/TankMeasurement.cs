﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PlateTracker.data.Models
{
    public partial class TankMeasurement
    {
        public long TankMeasurementId { get; set; }
        public int TankMeasurementTypeId { get; set; }
        public int TankMeasurementTankTypeId { get; set; }
        public decimal Value { get; set; }
        public string Notes { get; set; }
        public int TankMeasurementEmployeeId { get; set; }
        public DateTime TankMeasurementDatetime { get; set; }
        public DateTime DatetimeCreated { get; set; }
        public DateTime DatetimeUpdated { get; set; }
        public bool Deleted { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual TankMeasurementTankType TankMeasurementTankType { get; set; }
        public virtual TankMeasurementType TankMeasurementType { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
