using System;
using System.Collections.Generic;
using WebApplication1.Domain.Entities.Enums;

namespace WebApplication1.Web.Models
{
    public class UserData
    {
        public string Username { get; set; }
        
        public URole Level { get; set; }
    }
}