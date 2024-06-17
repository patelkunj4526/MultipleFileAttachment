using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleFileAttachment.Models
{
    public class Product
    {
        public string Name { get; set; }
        public IList<IFormFile> photos { get; set; }
    }
}
