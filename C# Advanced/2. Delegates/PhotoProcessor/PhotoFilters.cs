using System;

namespace PhotoProcessor
{
    public class PhotoFilters
    {
        public static void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public static void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public static void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }
}
