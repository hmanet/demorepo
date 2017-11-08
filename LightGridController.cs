using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Wells.Carina.Web.API.Models;
using Newtonsoft.Json;

namespace Wells.Carina.Web.API
{
    public class LightGridController : ApiController
    {
        public LightGridController()
        { }

        [Route("api/LightGridController/GetGridComponentSpec")]
        [HttpGet]
        public GridComponentSpec GetGridComponentSpec()
        {
            return new GridComponentSpec() {DisplayRowCount = 10,GridRunTimeId = 21234,GridType = "Showcase",RowHeight=20,TotalRowCount = 100};
        }

        
        [Route("api/LightGridController/GetSnapShot")]
        [HttpGet]
        public SnapShot GetSnapShot([FromUri]ViewPort viewPort)
        {
            var snapshot = CarinaSnapShotBuilder.GetSnapShot(viewPort);
            var output = JsonConvert.SerializeObject(snapshot);
            return snapshot;
        }

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
