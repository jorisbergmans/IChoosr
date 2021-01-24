using Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Services
{
    public interface ISearchHandler
    {
        List<CameraModel> ShowCamerasByName(string name);
        List<CameraModel> GetNames(string name);
    }
}
