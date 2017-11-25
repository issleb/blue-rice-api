using System;
using System.Collections.Generic;
using System.Text;

namespace BlueRice.Api.Common.Models
{
    public class Strip
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public DateTime PublishDate { get; set; }
        public string Description { get; set; }

        public bool IsNew { get; set; }
        public bool IsPublished { get; }

        public virtual IList<Tag> Tags { get; protected set; }

        public Strip() { }
    }
}
