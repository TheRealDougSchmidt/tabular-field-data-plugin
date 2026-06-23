using FieldDataPluginFramework.DataModel;
using FieldDataPluginFramework.DataModel.DischargeActivities;

namespace BlazorTestDrive.Components
{
    public static class VisitHelpers
    {
        public static string Measurement(Measurement measurement)
        {
            if (measurement == null) return "";

            return Measurement(measurement.Value, measurement.UnitId);
        }

        public static string Measurement(double? value, string unitId)
        {
            if (!value.HasValue) return "";

            return $"{value} ({unitId})";
        }

        public static string MeasurementDevice(MeasurementDevice device)
        {
            if (device == null) return "";

            var list = new List<string>();
            if (!string.IsNullOrEmpty(device.Manufacturer)) list.Add($"Manufacturer: {device.Manufacturer}");
            if (!string.IsNullOrEmpty(device.Model)) list.Add($"Model: {device.Model}");
            if (!string.IsNullOrEmpty(device.SerialNumber)) list.Add($"Serial Number: {device.SerialNumber}");
            return string.Join(", ", list);
        }

        public static string Grade(Grade? grade)
        {
            if (grade == null) return "";

            return grade.Code.HasValue ? $"{grade.Code}" : grade.DisplayName;
        }
    }
}
