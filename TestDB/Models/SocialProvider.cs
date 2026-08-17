using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepik.Models
{
    public class SocialProvider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }

        public List<UserSocialProvider> UserSocialProviders { get; set; }
    }
}
