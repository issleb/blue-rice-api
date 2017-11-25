using System;
using System.Collections.Generic;
using System.Text;

namespace BlueRice.Api.Common.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Strip> Strips { get; protected set; }

        public Tag() { }
    }
}
