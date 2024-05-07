﻿using Microsoft.AspNetCore.Identity;

namespace ChamCong_BackEnd.Server.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

    }
}
