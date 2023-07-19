﻿namespace ThinkElectric.Web.ViewModels.Scooter;

using System.ComponentModel.DataAnnotations;
using Product;
using static ThinkElectric.Common.EntityValidationConstants.Scooter;

public class ScooterCreateViewModel
{
    public ProductCreateViewModel Product { get; set; } = null!;
    
    [Required]
    [StringLength(BrandMaxLength, MinimumLength = BrandMinLength)]
    public string Brand { get; set; } = null!;

    [Required]
    [StringLength(ModelMaxLength, MinimumLength = ModelMinLength)]
    public string Model { get; set; } = null!;

    [Required]
    [StringLength(ColorMaxLength, MinimumLength = ColorMinLength)]
    public string Color { get; set; } = null!;

    [Required]
    [StringLength(BatteryMaxLength, MinimumLength = BatteryMinLength)]
    public string Battery { get; set; } = null!;

    [Range(ScooterTypeMinValue, ScooterTypeMaxValue)]
    [Display(Name = "Scooter Type")]
    public int ScooterType { get; set; }

    [Range(EngineTypeMinValue, EngineTypeMaxValue)]
    [Display(Name = "Engine Type")]
    public int EngineType { get; set; }

    [Range(BrakesTypeMinValue, BrakesTypeMaxValue)]
    [Display(Name = "Brakes Type")]
    public int BrakesType { get; set; }

    [Range(RangeMinValue, RangeMaxValue)]
    public int Range { get; set; }

    [Range(TopSpeedMinValue, TopSpeedMaxValue)]
    [Display(Name = "Top Speed")]
    public int TopSpeed { get; set; }

    [Range(WeightMinValue, WeightMaxValue)]
    public int Weight { get; set; }

    [Range(MaxLoadMinValue, MaxLoadMaxValue)]
    [Display(Name = "Max Load")]
    public int MaxLoad { get; set; }

    [Range(TireSizeMinValue, TireSizeMaxValue)]
    [Display(Name = "Tire Size")]
    public int TireSize { get; set; }

    [Range(ChargingTimeMinValue, ChargingTimeMaxValue)]
    [Display(Name = "Charging Time")]
    public int ChargingTime { get; set; }

    [Range(EnginePowerMinValue, EnginePowerMaxValue)]
    [Display(Name = "Engine Power")]
    public int EnginePower { get; set; }
}
