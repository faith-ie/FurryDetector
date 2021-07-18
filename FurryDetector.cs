namespace FurryDetector
{
    public sealed class Detect
    {
        public static bool IsAFurry(string text)
        {
            if (text.ToLower().Contains("owo") || text.ToLower().Contains("uwu"))
                return true;
            else return false;
        }
    }
}