using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Models
{
    public class UserSocialProvider
    {
        public int UserId { get; set; }
        public int SocialProviderId { get; set; }
        public string ConnectUrl { get; set; }

        public SocialProvider SocialProvider { get; set; }
        public User User { get; set; }
    }
}
