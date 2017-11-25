using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlueRice.Api.Common.Models;

namespace BlueRice.Api.Data
{
    public interface IStripData
    {
        Strip GetStrip(int id);
    }

    public class StripData : IStripData
    {
        public Strip GetStrip(int id)
        {
            throw new NotImplementedException();
        }
    }
}
