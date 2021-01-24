using Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Logic.Services.Implementations
{
    public class SearchHandler : ISearchHandler
    {
        private readonly ILogger<SearchHandler> logger;
        private readonly ICSVHelper csvHelper;
        public SearchHandler(ILogger<SearchHandler> logger, ICSVHelper csvHelper)
        {
            this.logger = logger;
            this.csvHelper = csvHelper;
        }

        public List<CameraModel> ShowCamerasByName(string name)
        {
            return GetNames(name);
        }
        public List<CameraModel> GetNames(string name)
        {
            try
            {
                var cameras = csvHelper.GetListFromCSV<CameraModel>();
                var filteredCamerasByName = cameras.Where(c => c.Camera.ToLower().Contains(name.ToLower())).ToList();
                
                return filteredCamerasByName;
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                throw ex;
            }
        }
    }
}
