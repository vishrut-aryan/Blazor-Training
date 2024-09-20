using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class UserProfile
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string ProfilePictureContentType { get; set; }
    }

}
