using System;
using System.Collections.Generic;
using System.Text;
using BlueRice.Api.Common.Models;

namespace BlueRice.Api.Core.Logic
{
    public interface IStripLogic
    {
        Strip GetStrip(int id);
    }

    public class StripLogic : IStripLogic
    {
        public Strip GetStrip(int id)
        {
            var strip = new Strip()
            {
                Id = id
            };
            return strip;
        }
    }
}
