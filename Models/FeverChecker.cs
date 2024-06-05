using System;

namespace Assignment_01.Models
{
    public static class FeverChecker
    {
        public static string EvaluateFever(double? Temperature)
        {
            if (Temperature.HasValue)
            {
                bool hasFever = Temperature.Value >= 37.5;
                return hasFever ? "You have a fever." : "No fever detected.";
            }
            else
            {
                return string.Empty;
            }
        }
        public static string EvaluateHypothermia(double? Temperature)
        {
            if (Temperature.HasValue)
            {
                bool hasHypothermia = Temperature.Value <= 35;
                return hasHypothermia ? "You have hypothermia risk." : "";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
