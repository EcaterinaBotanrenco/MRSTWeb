using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Domain.Enums;

namespace WebApplication1.Domain.Entities.User.Global
{
    public class LevelStatus
    {
        public LevelAcces Level {  get; set; }
        public DateTime SessionTime { get; set; }
    }
}
