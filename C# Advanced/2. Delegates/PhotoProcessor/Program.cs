using System;

namespace PhotoProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoEditor = new PhotoEditor();

            Action<Photo> filterHandler = PhotoFilters.ApplyBrightness;
            filterHandler += PhotoFilters.ApplyContrast;
            filterHandler += PhotoFilters.Resize;

            photoEditor.Process("C:/", filterHandler);
        }
    }
}
