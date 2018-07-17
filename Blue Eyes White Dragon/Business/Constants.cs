﻿using System;
using System.Configuration;

namespace Blue_Eyes_White_Dragon.Business
{
    public static class Constants
    {
        public static string GameImagesLocation => ConfigurationManager.AppSettings["GameImagesLocation"];
        public static string ReplacementImagesLocation => ConfigurationManager.AppSettings["ReplacementImagesLocation"];
        public static string Jpg => Enum.GetName(typeof(Constants.SupportedImageTypes), Constants.SupportedImageTypes.jpg);
        public static string Png => Enum.GetName(typeof(Constants.SupportedImageTypes), Constants.SupportedImageTypes.png);

        public static int ConsoleLimit = 20000;
        public static string ArtworkMatchFileName = "ArtworkMatch.json";

        public static readonly string StringError = "Internal Error";

        public enum SupportedImageTypes
        {
            jpg,
            png,
        }
    }
}
