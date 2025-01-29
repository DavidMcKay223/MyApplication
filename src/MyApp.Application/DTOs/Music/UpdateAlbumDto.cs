﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public class UpdateAlbumDto
    {
        public required string Artist { get; set; }
        public List<UpdateCDDto>? CDs { get; set; }
    }
}
