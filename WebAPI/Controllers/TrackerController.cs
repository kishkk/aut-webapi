using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Xml;

namespace WebAPI.Controllers
{
    //www.xyz.com/api/Tracker/readxml
    [Route("[controller]")]
    [ApiController]
    public class TrackerController : ControllerBase
    {
        private readonly ITracker _tracker;

        public TrackerController(ITracker tracker)
        {
            _tracker = tracker;
        }

        [HttpPost("tracker")]
        public async Task<IActionResult> ReadXmlFromBody()
        {
            string requestBody;
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                requestBody = await reader.ReadToEndAsync();

            }
            var result = await _tracker.GetPackageType(requestBody);

            //var result = await RedirectToEndPoint(requestBody);

            return Ok(result);

        }

       //IValidateVersionRepository
       //IValidateVersionService

    }
}
