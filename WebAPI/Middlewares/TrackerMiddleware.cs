using System.Text;
using System.Xml;

namespace WebAPI.Middlewares
{
    public class TrackerMiddleware
    {
        private readonly RequestDelegate _next;

        public TrackerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            string requestBody;

            using (StreamReader reader = new StreamReader(context.Request.Body, Encoding.UTF8))
            {
                requestBody = await reader.ReadToEndAsync();
            }

            if (string.IsNullOrEmpty(requestBody)) return;

            PackageType(requestBody, context);
            await _next(context);
        }

        private string PackageType(string requestBody, HttpContext context)
        {
            string packageType = string.Empty;

            StreamReader reader = new StreamReader(requestBody);
            String data = reader.ReadToEnd();
            
            //clsAUTWeb autTracker = new clsAUTWeb();

            if (data[0].ToString() == "<") // test to see if data is an XML
            {
                // Get XML document from header
                XmlDocument xmlDomDoc = new XmlDocument();
                xmlDomDoc.LoadXml(requestBody);

                // Determine package type received
                string strPackageType = xmlDomDoc.GetElementsByTagName("PackageType").Item(0).InnerText;
                string strPackageVersion = xmlDomDoc.GetElementsByTagName("PackageVersion").Item(0).InnerText;

                if (strPackageType == "CurrentVersionPost")
                {
                    context.Response.Redirect("/api/CurrentVersionPost");
                }
                else if (strPackageType == "UsageStatisticsPost")
                {
                    context.Response.Redirect("/api/UsageStatisticsPost");

                }
                else if (strPackageType == "ValidateEngCodePost")
                {
                    context.Response.Redirect("/api/ValidateEngCodePost");
                }
                else if (strPackageType == "ValidateEngCodeServiceCodePost")
                {
                    context.Response.Redirect("/api/ValidateEngCodeServiceCodePost");
                }
                else if (strPackageType == "CurrentVersionGroupPost")
                {
                    context.Response.Redirect("/api/CurrentVersionGroupPost");
                }
                else if (strPackageType == "NewEntityPost")
                {
                    context.Response.Redirect("/api/NewEntityPost");
                }
                else if (strPackageType == "SelectEntityPost")
                {
                    context.Response.Redirect("/api/SelectEntityPost");
                }
                else if (strPackageType == "ValidateLocatorPost")
                {
                    context.Response.Redirect("/api/ValidateLocatorPost");
                }
                if (xmlDomDoc == null)
                {
                    // context.Response.Redirect("/api/UsageStatisticsPost");
                }

                string strReturn = xmlDomDoc.OuterXml;


            }
            else
            {
                //this.lblXMLPost.Text = "This input is neither JSON or XML. Please submit a valid input!";
            }
            return packageType;
        }
    }
}
