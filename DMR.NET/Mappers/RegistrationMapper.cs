using DMR.NET.Entities.Models;
using XmlModels  = DMR.NET.Models.Deserialization;

namespace DMR.NET.Mappers;

internal static class RegistrationMapper
{
    internal static Registration MapRegistration(this XmlModels.XmlDmrEntry xmlModel)
    {
        return new Registration
        {
            Expiration = xmlModel.RegistrationNumberExpiration?.DateTime,
            RegistrationNumber = xmlModel.RegistrationNumber,
            Status = xmlModel.RegistrationStatus ?? string.Empty
        };
    }
}