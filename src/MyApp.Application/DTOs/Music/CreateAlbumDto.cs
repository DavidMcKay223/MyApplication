﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Music
{
    public record CreateAlbumDto(string Artist, List<CreateCDDto> CDs);
}
