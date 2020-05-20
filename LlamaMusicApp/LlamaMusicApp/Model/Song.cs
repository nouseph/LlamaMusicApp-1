﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace LlamaMusicApp.Model
{
    public class Song
    {
        private string _audioFilePath;
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public string ImagePath { get; set; }
        public string AudioFilePath
        { 
            get { return _audioFilePath; }
            set { _audioFilePath = value; }
        }

        //Constructors
        public Song(string title, string artist, string audioFilePath)
        {
            Title = title;
            Artist = artist;
            AudioFilePath = audioFilePath;
            ImagePath = "/Assets/LlamaMusicLogo.png";
        }

        public Song(string title, string artist)
        {
            Title = title;
            Artist = artist;
            ImagePath = "/Assets/LlamaMusicLogo.png";
        }

        public Song(string audioFilePath)
        {
            AudioFilePath = audioFilePath;
            ImagePath = "/Assets/LlamaMusicLogo.png";
        }

        public Song(Song source)
        {
            Title = source.Title;
            Artist = source.Artist;
            Genre = source.Genre;
            Album = source.Album;
            ImagePath = source.ImagePath;
            AudioFilePath = source.AudioFilePath;
        }
    }
}
