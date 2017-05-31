﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchDesktop.Model.DAO
{
    public class AuthResponse
    {
        public string access_token { get; set; }
        public string refresh_token { get; set; }
        public List<string> scope { get; set; }
    }
}
