namespace MLabs.ConvertToPcl.Extension
{
    static class Extensions
    {
        public static string Or(this string text, string alternative)
        {
            return string.IsNullOrWhiteSpace(text) ? alternative : text;
        }
    }
}