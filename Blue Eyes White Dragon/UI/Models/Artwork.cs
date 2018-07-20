﻿using System.Collections.Generic;
using System.IO;
using Blue_Eyes_White_Dragon.Business;
using Blue_Eyes_White_Dragon.Utility;
using Newtonsoft.Json;

namespace Blue_Eyes_White_Dragon.UI.Models
{
    public class Artwork
    {
        /// <summary>
        /// GameImage is referred to as GI
        /// </summary>
        public FileInfo GameImageFile { get; set; }
        [JsonIgnore] public string GameImageFilePath => GameImageFile?.FullName ?? Constants.StringError;
        [JsonIgnore] public string GameImageFileName => GameImageFile?.Name ?? Constants.StringError;
        public string GameImageMonsterName { get; set; }
        public DirectoryInfo GameImagesDir { get; set; }
        [JsonIgnore] public int GameImageHeight { get; set; }
        [JsonIgnore] public int GameImageWidth { get; set; }

        /// <summary>
        /// ReplacementImage is reffered to as RI
        /// </summary>
        public FileInfo ReplacementImageFile { get; set; }
        [JsonIgnore] public string ReplacementImageFilePath => ReplacementImageFile?.FullName ?? Constants.StringError;
        [JsonIgnore] public string ReplacementImageFileName => ReplacementImageFile?.Name ?? Constants.StringError;
        public string ReplacementImageMonsterName { get; set; }
        public DirectoryInfo ReplacementImagesDir { get; set; }
        [JsonIgnore] public int ReplacementImageHeight { get; set; }
        [JsonIgnore] public int ReplacementImageWidth { get; set; }

        public bool IsMatched { get; set; }
        public List<FileInfo> AlternateReplacementImages { get; set; } = new List<FileInfo>();

        public override string ToString()
        {
            return $"GameImageFilePath:{GameImageFilePath} GameImageMonsterName:{GameImageMonsterName} " +
                   $"ReplacementImageFilePath:{ReplacementImageFilePath} ReplacementImageMonsterName:{ReplacementImageMonsterName}";
        }
    }
}

