using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json.Linq;

namespace Wsdot.Wzdx.v4.Devices.Converters
{
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    [SuppressMessage("CodeQuality", "IDE0079:Remove unnecessary suppression", Justification = "Suppressing unused type loaded by reflection")]
    internal sealed class DynamicMessageSignFieldDeviceConverter : IFieldDeviceConverter
    {
        public IFieldDevice Read(JObject value)
        {
            return value.ToObject<DynamicMessageSign>();
        }

        public bool CanConvert(FieldDeviceCoreDetails details)
        {
            return details.DeviceType == FieldDeviceType.DynamicMessageSign;
        }
    }
}