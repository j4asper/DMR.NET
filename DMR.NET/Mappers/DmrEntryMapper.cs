using DMR.NET.Entities.Enums;
using DMR.NET.Entities.Models;
using XmlModels  = DMR.NET.Models.Deserialization;

namespace DMR.NET.Mappers;

internal static class DmrEntryMapper
{
    internal static DmrEntry MapToDmrEntry(this XmlModels.XmlDmrEntry xmlModel)
    {
        return new DmrEntry
        {
            Id = xmlModel.Id ?? string.Empty,
            Registration = xmlModel.MapRegistration(),
            Vehicle = xmlModel.MapVehicle(),
            Inspection = xmlModel.StructuredInspectionResult?.MapVehicleInspection(),
            Type = MapVehicleType(xmlModel.Type),
            Usage = MapVehicleUsage(xmlModel.StructuredVehicleUsage?.Usage),
            LeasingValidFrom = xmlModel.LeasingValidFrom,
            LeasingValidTo = xmlModel.LeasingValidTo,
        };
    }

    private static VehicleType MapVehicleType(string? code)
    {
        return code switch
        {
            "1" => VehicleType.PassengerCar,
            "2" => VehicleType.LargePassengerCar,
            "3" => VehicleType.Van,
            "4" => VehicleType.Truck,
            "5" => VehicleType.Trailer,
            "6" => VehicleType.SemiTrailer,
            "7" => VehicleType.Motorcycle,
            "8" => VehicleType.Tractor,
            "9" => VehicleType.TractorTrailer,
            "10" => VehicleType.Caravan,
            "11" => VehicleType.TowingEquipment,
            "12" => VehicleType.MotorEquipment,
            "16" => VehicleType.LargeMoped,
            "17" => VehicleType.SmallMoped,
            "91" => VehicleType.MotorizedBlockTrailer,
            "92" => VehicleType.BlockSemiTrailer,
            "93" => VehicleType.BlockTrailer,
            "94" => VehicleType.BlockDolly,
            "95" => VehicleType.BlockModule,
            "96" => VehicleType.BlockTrailerOnly,
            _ => VehicleType.Unknown
        };
    }

    private static VehicleUsageType MapVehicleUsage(string? code)
    {
        return code switch
        {
            "1" => VehicleUsageType.PrivatePassengerTransport,
            "20" => VehicleUsageType.FreightTransport,
            "21" => VehicleUsageType.TaxiTransport,
            "22" => VehicleUsageType.MedicalTransport,
            "23" => VehicleUsageType.AmbulanceTransport,
            "25" => VehicleUsageType.RouteTransport,
            "26" => VehicleUsageType.HearseTransport,
            "27" => VehicleUsageType.CrewMaterialTransport,
            "28" => VehicleUsageType.FireRescueTransport,
            "29" => VehicleUsageType.PrivateBusTransport,
            "30" => VehicleUsageType.BusTransport,
            "31" => VehicleUsageType.TractorPowerForSemiTrailer,
            "32" => VehicleUsageType.SpecialUse,
            "33" => VehicleUsageType.ForestryAgricultureHorticultureTransport,
            "34" => VehicleUsageType.ResidentialUse,
            "35" => VehicleUsageType.WorkTransport,
            "38" => VehicleUsageType.FreightTransportHalfVolume,
            "40" => VehicleUsageType.CommercialFreightTransport,
            "41" => VehicleUsageType.PrivateOrCommercialFreightTransport,
            "42" => VehicleUsageType.PrivateFreightTransport,
            "43" => VehicleUsageType.ApprovedForForestryAgricultureHorticultureOnly,
            "44" => VehicleUsageType.ApprovedForRouteTransportOnly,
            "45" => VehicleUsageType.SpecialTransport,
            "46" => VehicleUsageType.LimousineService,
            "47" => VehicleUsageType.DrivingForPublicAuthority,
            _ => VehicleUsageType.Unknown
        };
    }
}
