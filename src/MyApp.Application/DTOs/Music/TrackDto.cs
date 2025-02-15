﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public class TrackDto
    {
        public int ID { get; set; }
        public required int Number { get; set; }
        public required string Title { get; set; }
        public required TimeSpan Length { get; set; }
    }
}
