﻿using JwtAspNetCoreWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtAspNetCoreWebApi.Services
{
    public interface IUserService
    {
        Task<string> RegisterAsync(RegisterModel model);
    }
}
