using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlueRice.Api.Common.Models;
using BlueRice.Api.Data;

namespace BlueRice.Api.Core
{
    public interface IStripLogic
    {
        Strip GetStrip(int id);
    }

    public class StripLogic : IStripLogic
    {
        private readonly IStripData _stripData;

        public StripLogic(IStripData stripData)
        {
            _stripData = stripData;
        }

        public Strip GetStrip(int id)
        {
            var strip = _stripData.GetStrip(id);

            return strip;
        }
    }
}
