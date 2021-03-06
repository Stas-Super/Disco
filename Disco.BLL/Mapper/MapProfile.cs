﻿using AutoMapper;
using Disco.BLL.DTO;
using Disco.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Disco.BLL.Mapper
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            this.CreateMap<User, UserDTO>();
        }
    }
}
