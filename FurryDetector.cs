namespace FurryDetector
{
    public sealed class Detect
    {
        public static bool IsAFurry(string text)
        {
            return text.ToLower().Contains("owo") || text.ToLower().Contains("uwu");
        }
    }
}