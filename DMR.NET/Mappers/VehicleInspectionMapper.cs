using DMR.NET.Entities.Enums;
using DMR.NET.Entities.Models;
using XmlModels  = DMR.NET.Models.Deserialization;

namespace DMR.NET.Mappers;

internal static class VehicleInspectionMapper
{
    internal static VehicleInspection MapVehicleInspection(this XmlModels.StructuredInspectionResult xmlModel)
    {
        return new VehicleInspection
        {
            Date = xmlModel.InspectionDate.DateTime,
            Result = MapInspectionResult(xmlModel.InspectionResult),
            Type = MapInspectionType(xmlModel.InspectionType)
        };
    }

    private static InspectionResult MapInspectionResult(string? code)
    {
        return code switch
        {
            "1" => InspectionResult.PrivatePassengerUse,
            "Godkendt" => InspectionResult.Approved,
            "IkkeGodkendt" => InspectionResult.NotApproved,
            "KanGodkendesVedOmsynAfOmsynsvirksomhed" => InspectionResult.CanBeApprovedAfterReinspectionByInspectionCompany,
            "KanGodkendesVedOmsynAfSynsvirksomhed" => InspectionResult.CanBeApprovedAfterReinspectionBySynCompany,
            "IkkeGodkendtKanGenfremstilles" => InspectionResult.NotApprovedCanBeReproduced,
            "IkkeFuldstaendigtSyn" => InspectionResult.NotFullyInspected,
            _ => InspectionResult.Unknown
        };
    }

    private static InspectionType MapInspectionType(string? code)
    {
        return code switch
        {
            "KontrolSyn" => InspectionType.Control,
            "MOT" => InspectionType.MOT,
            "PeriodiskSyn" => InspectionType.Periodic,
            "RegistreringsSyn" => InspectionType.Registration,
            "RegistreringssynToldsyn" => InspectionType.RegistrationInspectionCustoms,
            _ => InspectionType.Unknown
        };
    }
}
