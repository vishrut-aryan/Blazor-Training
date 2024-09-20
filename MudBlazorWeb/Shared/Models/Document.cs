using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public string Title { get; set; }
        public byte[] FileData { get; set; }
        public string FileContentType { get; set; }
        public DateTime UploadedOn { get; set; }
    }

}
