using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Infrastructure.Respositories
{
    public class Tracker : ITracker
    {
        public Task<string> GetPackageType(string requestBody)
        {

            return null;
        }
    }
}
