﻿using Microsoft.AspNetCore.Identity;

namespace AppointmentScheduling.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
