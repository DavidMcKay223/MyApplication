﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public record UpdateAlbumDto(string Artist = "", List<UpdateCDDto>? CDs = null);
}
