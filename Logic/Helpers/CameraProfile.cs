using CsvHelper.Configuration;
using Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Helpers
{
    public class CameraProfile : ClassMap<CameraModel>
    {
        public CameraProfile()
        {
            Map(m => m.Camera).Index(0).Name("Camera");
            Map(m => m.Latitude).Index(1).Name("Latitude");
            Map(m => m.Longitude).Index(2).Name("Longitude");
        }
    }
}
