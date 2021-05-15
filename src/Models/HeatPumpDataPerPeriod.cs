﻿using System;
using StiebelEltronDashboard.Models.Shared;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace StiebelEltronDashboard.Models
{
    public partial class HeatPumpDataPerPeriod : ValueObject
    {
        [IgnoreMember]     
        public int Id { get; set; }
        public double ReturnTemperatureMin { get; set; }
        public double ReturnTemperatureMax { get; set; }
        public double ReturnTemperatureAverage { get; set; }
        public double InletTemperatureMin { get; set; }
        public double InletTemperatureMax { get; set; }
        public double InletTemperatureAverage { get; set; }
        public double AntiFreezeTemperatureMin { get; set; }
        public double AntiFreezeTemperatureMax { get; set; }
        public double AntiFreezeTemperatureAverage { get; set; }
        public double OutdoorTemperatureMin { get; set; }
        public double OutdoorTemperatureMax { get; set; }
        public double OutdoorTemperatureAverage { get; set; }
        public double ExhaustAirTemperatureMin { get; set; }
        public double ExhaustAirTemperatureMax { get; set; }
        public double ExhaustAirTemperatureAverage { get; set; }
        public double EvaporatorTemperatureMin { get; set; }
        public double EvaporatorTemperatureMax { get; set; }
        public double EvaporatorTemperatureAverage { get; set; }
        public double TotalPowerConsumptionStart { get; set; }
        public double TotalPowerConsumptionEnd { get; set; }
        public double TotalPowerConsumptionDelta { get; set; }
        public double CompressorInletTemperatureMin { get; set; }
        public double CompressorInletTemperatureMax { get; set; }
        public double CompressorInletTemperatureAverage { get; set; }
        public double IntermediateInjectionTemperatureMin { get; set; }
        public double IntermediateInjectionTemperatureMax { get; set; }
        public double IntermediateInjectionTemperatureAverage { get; set; }
        public double HotGasTemperatureMin { get; set; }
        public double HotGasTemperatureMax { get; set; }
        public double HotGasTemperatureAverage { get; set; }
        public double CondenserTemperatureMin { get; set; }
        public double CondenserTemperatureMax { get; set; }
        public double CondenserTemperatureAverage { get; set; }
        public double OilSumpTemperatureMin { get; set; }
        public double OilSumpTemperatureMax { get; set; }
        public double OilSumpTemperatureAverage { get; set; }
        public double LowPressureMin { get; set; }
        public double LowPressureMax { get; set; }
        public double LowPressureAverage { get; set; }
        public double PressureMediumMin { get; set; }
        public double PressureMediumMax { get; set; }
        public double PressureMediumAverage { get; set; }
        public double HighPressureMin { get; set; }
        public double HighPressureMax { get; set; }
        public double HighPressureAverage { get; set; }
        public double WaterVolumeCurrentMin { get; set; }
        public double WaterVolumeCurrentMax { get; set; }
        public double WaterVolumeCurrentAverage { get; set; }
        public double VoltageInverterMin { get; set; }
        public double VoltageInverterMax { get; set; }
        public double VoltageInverterAverage { get; set; }
        public double ActualSpeedDensifierMin { get; set; }
        public double ActualSpeedDensifierMax { get; set; }
        public double ActualSpeedDensifierAverage { get; set; }
        public double SettingSpeedCompressedMin { get; set; }
        public double SettingSpeedCompressedMax { get; set; }
        public double SettingSpeedCompressedAverage { get; set; }
        public double FanPowerRelMin { get; set; }
        public double FanPowerRelMax { get; set; }
        public double FanPowerRelAverage { get; set; }
        
        [Column("VaporizerHeatQuantityHeatingDayMin")]
        public double VaporizerHeatQuantityHeatingDayMin { get; set; }
        [Column("VaporizerHeatQuantityHeatingDayMax")]
        public double VaporizerHeatQuantityHeatingDayMax { get; set; }
        [Column("VaporizerHeatQuantityHeatingDayAverage")]
        public double VaporizerHeatQuantityHeatingDayAverage { get; set; }
        public double VaporizerHeatQuantityHeatingTotalStart { get; set; }
        public double VaporizerHeatQuantityHeatingTotalEnd { get; set; }
        public double VaporizerHeatQuantityHeatingTotalDelta { get; set; }
        [Column("VaporizerHeatQuantityHotWaterDayMin")]
        public double VaporizerHeatQuantityHotWaterDayMin { get; set; }
        [Column("VaporizerHeatQuantityHotWaterDayMax")]
        public double VaporizerHeatQuantityHotWaterDayMax { get; set; }
        [Column("VaporizerHeatQuantityHotWaterDayAverage")]
        public double VaporizerHeatQuantityHotWaterDayAverage { get; set; }
        public double VaporizerHeatQuantityHotWaterTotalStart { get; set; }
        public double VaporizerHeatQuantityHotWaterTotalEnd { get; set; }
        public double VaporizerHeatQuantityHotWaterTotalDelta { get; set; }
        public double ReheatingStagesHeatQuantityHeatingSumStart { get; set; }
        public double ReheatingStagesHeatQuantityHeatingSumEnd { get; set; }
        public double ReheatingStagesHeatQuantityHeatingSumDelta { get; set; }
        public double ReheatingStagesHeatQuantityHotWaterTotalStart { get; set; }
        public double ReheatingStagesHeatQuantityHotWaterTotalEnd { get; set; }
        public double ReheatingStagesHeatQuantityHotWaterTotalDelta { get; set; }
        [Column("PowerConsumptionHeatingDayMin")]
        public double PowerConsumptionHeatingDayMin { get; set; }
        [Column("PowerConsumptionHeatingDayMax")]
        public double PowerConsumptionHeatingDayMax { get; set; }
         [Column("PowerConsumptionHeatingDayAverage")]
        public double PowerConsumptionHeatingDayAverage { get; set; }
        public double PowerConsumptionHeatingSumStart { get; set; }
        public double PowerConsumptionHeatingSumEnd { get; set; }
        public double PowerConsumptionHeatingSumDelta { get; set; }
        [Column("PowerConsumptionHotWaterDayMin")]
        public double PowerConsumptionHotWaterDayMin { get; set; }
        [Column("PowerConsumptionHotWaterDayMax")]
        public double PowerConsumptionHotWaterDayMax { get; set; }
        [Column("PowerConsumptionHotWaterDayAverage")]
        public double PowerConsumptionHotWaterDayAverage { get; set; }
        public double PowerConsumptionHotWaterSumStart { get; set; }
        public double PowerConsumptionHotWaterSumEnd { get; set; }
        public double PowerConsumptionHotWaterSumDelta { get; set; }
        public double RuntimeVaporizerHeatingStart { get; set; }
        public double RuntimeVaporizerHeatingEnd { get; set; }
        public double RuntimeVaporizerHeatingDelta { get; set; }
        public double RuntimeVaporizerHotWaterStart { get; set; }
        public double RuntimeVaporizerHotWaterEnd { get; set; }
        public double RuntimeVaporizerHotWaterDelta { get; set; }
        public double RuntimeVaporizerDefrostStart { get; set; }
        public double RuntimeVaporizerDefrostEnd { get; set; }
        public double RuntimeVaporizerDefrostDelta { get; set; }
        public double ReheatingStages1Start { get; set; }
        public double ReheatingStages1End { get; set; }
        public double ReheatingStages1Delta { get; set; }
        public double ReheatingStages2Start { get; set; }
        public double ReheatingStages2End { get; set; }
        public double ReheatingStages2Delta { get; set; }
        public double DefrostTimeStart { get; set; }
        public double DefrostTimeEnd { get; set; }
        public double DefrostTimeDelta { get; set; }
        public double DefrostStartsStart { get; set; }
        public double DefrostStartsEnd { get; set; }
        public double DefrostStartsDelta { get; set; }
        public double Year { get; set; }
        public string PeriodKind { get; set; }
        public int PeriodNumber { get; set; }
        [IgnoreMember]  
        public DateTime DateUpdated { get; set; }
        [IgnoreMember]  
        public DateTime DateCreated { get; set; }
        public DateTime First { get; set; }
        public DateTime Last { get; set; }
    }
}
