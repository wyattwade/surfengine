﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySurfboardsMVP.Models
{
    public class Surfboard
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Shape { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Volume { get; set; }
        public int Price { get; set; }
        public string Link { get; set; }
        public string Image { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Email { get; set; }
        public bool FromInternalUser { get; set; }
        public int TotalRows { get; set; }
    }
}