using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedSleepInventoryForms.Helpers
{



    public static class PDFHelper
    {
        private static Dictionary<string, string> GetIPPairs()
        {
            return new Dictionary<string, string>
            {
                {"192.168.9.", "Manhattan"},
                { "192.168.1.", "Garden City" },
                {"192.168.7.", "Bayridge" },
                  {"192.168.3.", "Bayside"},
                { "192.168.2.", "Commack" },
                {"192.168.18.", "Mercy" },
                {"192.168.19.", "Northwell"},
                { "192.168.8.", "Parkslope" },
                {"192.168.5.", "Rockland" },
                 {"192.168.4.", "Shirley"},
                { "192.168.10.", "StJoseph" },
                {"192.168.20.", "StCharles" },
                {"192.168.21.", "StCatherine" },
            };
        
        }

        public static void GeneratePdf(string htmlPdf, string dns, string pdftype)
        {
            try
            {


                var pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);
                var htmlparser = new HTMLWorker(pdfDoc);
                using (var memoryStream = new MemoryStream())
                {
                    var writer = PdfWriter.GetInstance(pdfDoc, memoryStream);
                    pdfDoc.Open();
                    htmlparser.Parse(new StringReader(htmlPdf));
                    pdfDoc.Close();
                    StringBuilder sb = new StringBuilder();
                    if (GetIPPairs().ContainsKey(dns.Substring(0, dns.LastIndexOf(".") + 1)))
                    {
                        sb.Append(GetIPPairs()[dns.Substring(0, dns.LastIndexOf(".") + 1)]);
                    }
                    else
                    {
                        sb.Append("Unknown Location");
                    }
                    sb.Append("_");
                    sb.Append(DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss-ms"));
                    sb.Append("_"+pdftype+".pdf");
                    byte[] bytes = memoryStream.ToArray();
                    System.IO.Directory.CreateDirectory(@"\\usdfileserver\sleeptech\Inventory\Sleep Lab Inventory Logs");
                    System.IO.File.WriteAllBytes(@"\\usdfileserver\Sleeptech\Inventory\Sleep Lab Inventory Logs\" + sb.ToString(), bytes);
                    memoryStream.Close();
                }

            }

            catch
            {
                throw;
            }

        }

    }
}
