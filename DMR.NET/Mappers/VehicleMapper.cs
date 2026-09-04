using DMR.NET.Entities.Enums;
using DMR.NET.Entities.Models;
using XmlModels  = DMR.NET.Models.Deserialization;

namespace DMR.NET.Mappers;

internal static class VehicleMapper
{
    internal static Vehicle MapVehicle(this XmlModels.XmlDmrEntry xmlModel)
    {
        var details = xmlModel.StructuredVehicleDetails;

        var make = details.StructuredVehicleDescription?.Make ?? string.Empty;
        var model = details.StructuredVehicleDescription?.Model?.ModelName ?? string.Empty;
        var variant = details.StructuredVehicleDescription?.Variant?.VariantName;
        var modelYear = details.ModelYear.ParseNullableInt();
        var vin = details.Vin ?? string.Empty;
        var vinLocation = details.VinLocation;
        var color = MapVehicleColor(details.StructuredVehicleColor?.StructuredColorType?.VehicleColor);
        var chassisType = MapChassisType(details.StructuredVehicleChassis?.Name);
        var condition = MapCondition(details.VehicleCondition);
        var topSpeed = details.TopSpeed.ParseNullableInt();
        var status = MapStatus(details.Status);
        var firstRegistrationDate = details.FirstRegistrationDate;
        var manufacturer = details.Manufacturer;
        var euVariant = details.EUVariant;
        var euVersion = details.EUVersion;
        var rimTire = details.RimTire;
        var commissioningDate = details.CommissioningDate;
        var otherEquipment = details.OtherEquipment;
        var attachedSidecarVin = details.AttachedSidecarVin;
        var veteran = details.Veteran;
        var trafficDamage = details.TrafficDamage;
        var suitableForTaxi = details.SuitableForTaxi;
        var thirtyPercentVan = details.ThirtyPercentVan;
        var ncapTest = details.NCAPTest;
        var engine = MapEngine(details.StructuredVehicleEngine);
        var emission = MapEmission(details.StructuredVehicleEmission, details.StructuredVehicleEnvironmentDetails?.ParticleFilter ?? false);
        var weight = MapWeight(details);
        var capacity = MapCapacity(details);

        return new Vehicle
        {
            Make = make,
            Model = model,
            Variant = variant,
            ModelYear = modelYear,
            Vin = vin,
            VinLocation = vinLocation,
            Color = color,
            ChassisType = chassisType,
            Condition = condition,
            TopSpeed = topSpeed,
            Status = status,
            FirstRegistrationDate = firstRegistrationDate,
            Manufacturer = manufacturer,
            EUVariant = euVariant,
            EUVersion = euVersion,
            RimTire = rimTire,
            CommissioningDate = commissioningDate,
            OtherEquipment = otherEquipment,
            AttachedSidecarVin = attachedSidecarVin,
            Veteran = veteran,
            TrafficDamage = trafficDamage,
            SuitableForTaxi = suitableForTaxi,
            ThirtyPercentVan = thirtyPercentVan,
            NCAPTest = ncapTest,
            Engine = engine,
            Emission = emission,
            Weight = weight,
            Capacity = capacity
        };
    }

    /// <remarks>
    /// XmlSerializer throws InvalidOperationException when a numeric/string code has no matching
    /// XmlEnum member, and real DMR data contains codes beyond what any of these enums define
    /// (e.g. PowerSourceType "9"). Every code coming out of the XML layer is therefore a raw
    /// string, matched here with a safe fallback to Unknown instead of a strict XmlEnum binding.
    /// </remarks>
    private static VehicleColor MapVehicleColor(string? code)
    {
        return code switch
        {
            "2" => VehicleColor.White,
            "3" => VehicleColor.Grey,
            "4" => VehicleColor.Black,
            "5" => VehicleColor.Red,
            "6" => VehicleColor.Brown,
            "7" => VehicleColor.Yellow,
            "8" => VehicleColor.Green,
            "9" => VehicleColor.Blue,
            "10" => VehicleColor.Orange,
            "11" => VehicleColor.PurpleViolet,
            _ => VehicleColor.Unknown
        };
    }

    /// <remarks>
    /// The DMR feed exposes body type as a free-text name (KarrosseriTypeNavn), not a numeric
    /// code, so this matches on the known Danish/English labels rather than an XmlEnum.
    /// </remarks>
    private static VehicleChassisType MapChassisType(string? name)
    {
        return name switch
        {
            "Stationcar" => VehicleChassisType.StationWagon,
            "Coupe" => VehicleChassisType.Coupe,
            "Cabriolet" => VehicleChassisType.Cabriolet,
            "Hatchback" => VehicleChassisType.Hatchback,
            "Sedan" => VehicleChassisType.Sedan,
            "MPV" => VehicleChassisType.MPV,
            "Stationcar-pickup" => VehicleChassisType.StationPickup,
            "Uden karrosseri" => VehicleChassisType.NoBody,
            "3-hjulet, åben" => VehicleChassisType.ThreeWheeledOpen,
            "3-hjulet, lukket" => VehicleChassisType.ThreeWheeledClosed,
            _ => VehicleChassisType.Unknown
        };
    }

    private static VehicleCondition MapCondition(string? code)
    {
        return code switch
        {
            "Middel" => VehicleCondition.Average,
            "UnderMiddel" => VehicleCondition.BelowAverage,
            "OverMiddel" => VehicleCondition.AboveAverage,
            _ => VehicleCondition.Unknown
        };
    }

    private static VehicleStatus MapStatus(string? code)
    {
        return code switch
        {
            "UnderOprettelse" => VehicleStatus.UnderCreation,
            "Oprettet" => VehicleStatus.Created,
            "Registreret" => VehicleStatus.Registered,
            "Afmeldt" => VehicleStatus.Deregistered,
            "Eksportmarkering" => VehicleStatus.ExportMarked,
            "Skrottet" => VehicleStatus.Scrapped,
            "Eksporteret" => VehicleStatus.Exported,
            "AdministrativOprettelse" => VehicleStatus.AdministrativeCreation,
            "Erklæretafimportør" => VehicleStatus.DeclaredByImporter,
            "Erklæretafimportørogforhandler" => VehicleStatus.DeclaredByImporterAndDealer,
            "Slettet" => VehicleStatus.Deleted,
            "HarGennemførtRegistreringssyn" => VehicleStatus.CompletedRegistrationInspection,
            "DelvistOprettet" => VehicleStatus.PartiallyCreated,
            _ => VehicleStatus.Unknown
        };
    }

    private static VehicleEngine MapEngine(XmlModels.StructuredVehicleEngine? xmlModel)
    {
        return new VehicleEngine
        {
            PowerSources = MapPowerSources(xmlModel?.StructuredVehiclePowerSourceCollection),
            CylinderCount = xmlModel?.CylinderCount.ParseNullableInt(),
            Mileage = xmlModel?.Mileage.ParseNullableInt(),
            InnovativeTechnology = xmlModel?.InnovativeTechnology
        };
    }

    private static VehiclePowerSource[] MapPowerSources(XmlModels.StructuredVehiclePowerSourceCollection? xmlModel)
    {
        var items = xmlModel?.VehiclePowerSourceCollection;

        if (items is null || items.Length == 0)
            return [];

        return items.Select(MapPowerSource).ToArray();
    }

    private static VehiclePowerSource MapPowerSource(XmlModels.VehiclePowerSourceCollection? xmlModel)
    {
        var structuredType = xmlModel?.StructuredPowerSourceType;

        return new VehiclePowerSource
        {
            Type = MapPowerSourceType(structuredType?.PropulsionPowerSourceType?.PowerSourceType),
            KmPerLiter = structuredType?.StructuredVehicleFuel?.KmPerLiter.ParseNullableDouble(),
            IsPrimary = structuredType?.PrimarilyEnginePowered ?? false
        };
    }

    private static PowerSourceType MapPowerSourceType(string? code)
    {
        return code switch
        {
            "1" => PowerSourceType.Petrol,
            "2" => PowerSourceType.Diesel,
            "3" => PowerSourceType.FGas,
            "4" => PowerSourceType.Electric,
            "5" => PowerSourceType.Petroleum,
            "6" => PowerSourceType.NaturalGas,
            "7" => PowerSourceType.Hydrogen,
            _ => PowerSourceType.Unknown
        };
    }

    private static VehicleEmission MapEmission(XmlModels.StructuredVehicleEmission? xmlModel, bool particleFilter)
    {
        return new VehicleEmission
        {
            Standard = MapEmissionStandard(xmlModel?.StructuredEmissionType?.EmissionStandard),
            ParticleFilter = particleFilter
        };
    }

    private static EmissionStandard MapEmissionStandard(string? code)
    {
        return code switch
        {
            "1" => EmissionStandard.NoStandard,
            "24" => EmissionStandard.Year2000EnvironmentalStandard,
            "25" => EmissionStandard.Year2005EnvironmentalStandard,
            "26" => EmissionStandard.NonEuro,
            "27" => EmissionStandard.EuroI,
            "28" => EmissionStandard.EuroII,
            "29" => EmissionStandard.EuroIII,
            "46" => EmissionStandard.EuroIV,
            "47" => EmissionStandard.EuroV,
            "48" => EmissionStandard.EEV,
            "49" => EmissionStandard.EuroVI,
            "50" => EmissionStandard.EuroVII,
            "77" => EmissionStandard.EnvironmentalStandard2006Over150ccm,
            "78" => EmissionStandard.EnvironmentalStandard2006Max150ccm,
            "79" => EmissionStandard.Euro5Plus,
            "80" => EmissionStandard.Euro1,
            "81" => EmissionStandard.Euro2,
            "82" => EmissionStandard.Euro3,
            "83" => EmissionStandard.Euro4,
            "84" => EmissionStandard.Euro5A,
            "85" => EmissionStandard.Euro5B,
            "86" => EmissionStandard.Euro6B,
            "87" => EmissionStandard.Euro6C,
            "88" => EmissionStandard.Euro6DTemp,
            "89" => EmissionStandard.Euro6D,
            "90" => EmissionStandard.Euro6E,
            "91" => EmissionStandard.Euro7,
            "92" => EmissionStandard.Euro5,
            "94" => EmissionStandard.Euro6,
            _ => EmissionStandard.Unknown
        };
    }

    private static VehicleWeight MapWeight(XmlModels.StructuredVehicleDetails xmlModel)
    {
        return new VehicleWeight
        {
            GrossWeight = xmlModel.GrossWeight.ParseNullableInt(),
            CurbWeight = xmlModel.Weight.ParseNullableInt(),
            MinimumCurbWeight = xmlModel.MinimumCurbWeight.ParseNullableInt(),
            MaximumCurbWeight = xmlModel.MaximumCurbWeight.ParseNullableInt(),
            TechnicalGrossWeight = xmlModel.TechnicalGrossWeight.ParseNullableInt(),
            TowingPossible = xmlModel.VehicleTowingPossibility,
            TowingWeightWithoutBrakes = xmlModel.TowingWeightWithoutBrakes.ParseNullableInt(),
            TowingWeightWithBrakes = xmlModel.TowingWeightWithBrakes.ParseNullableInt()
        };
    }

    private static VehicleCapacity MapCapacity(XmlModels.StructuredVehicleDetails xmlModel)
    {
        return new VehicleCapacity
        {
            DoorCount = xmlModel.DoorCount.ParseNullableInt(),
            AxleCount = xmlModel.AxleCount.ParseNullableInt(),
            DrivingAxles = xmlModel.DrivingAxles.ParseNullableIntArray(),
            GearCount = xmlModel.GearCount.ParseNullableInt(),
            PassengerCount = xmlModel.PassengerCount.ParseNullableInt(),
            MinimumSeats = xmlModel.MinimumSeats.ParseNullableInt(),
            MaximumSeats = xmlModel.MaximumSeats.ParseNullableInt(),
            MinimumStandingSpots = xmlModel.MinimumStandingSpots.ParseNullableInt(),
            MaximumStandingSpots = xmlModel.MaximumStandingSpots.ParseNullableInt(),
            TrackWidthFront = xmlModel.TrackWidthFront.ParseNullableInt(),
            TrackWidthBack = xmlModel.TrackWidthBack.ParseNullableInt()
        };
    }
}
