using System.Xml.Serialization;

namespace DMR.NET.Entities.Enums;

public enum OwnershipType
{
    Unknown,
    
    [XmlEnum("1")]
    Owner = 1,
    
    [XmlEnum("2")]
    User = 2,
    
    [XmlEnum("3")]
    SubleaseProvider = 3
}