﻿using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace SnakeGame
{
    public static class Images
    {
        public readonly static ImageSource Empty = LoadImages("Empty.png");
        public readonly static ImageSource Body = LoadImages("Body.png");
        public readonly static ImageSource Head = LoadImages("Head.png");
        public readonly static ImageSource Food = LoadImages("Food.png");
        public readonly static ImageSource DeadBody = LoadImages("DeadBody.png");
        public readonly static ImageSource DeadHead = LoadImages("DeadHead.png");

        private static ImageSource LoadImages(string fileName)
        {
            return new BitmapImage(new Uri($"Assets/{fileName}",UriKind.Relative));
        }
    }
}
