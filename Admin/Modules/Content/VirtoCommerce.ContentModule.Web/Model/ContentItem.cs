﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtoCommerce.ContentModule.Web.Model
{
    using Newtonsoft.Json;

    public class ContentItem
    {
        public string Id { get; set; }

        public string Content { get; set; }

        public DateTime LastUpdated { get; set; }

        public string Status { get; set; }

        [JsonIgnore]
        public string Filename { get; set; }
    }
}
