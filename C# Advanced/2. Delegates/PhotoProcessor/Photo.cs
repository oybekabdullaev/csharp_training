﻿using System;

namespace PhotoProcessor
{
    public class Photo
    {
        public static Photo Load(string path)
        {
            return new Photo();
        }

        public void Save()
        {
            Console.WriteLine("Photo is saved");
        }
    }
}
