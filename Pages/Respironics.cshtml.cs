using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UnitedSleepInventoryForms.Helpers;

namespace UnitedSleepInventoryForms
{
    public class RespironicsPDF
    {

        [Required]
        public string Technician { get; set; }
        [Required]
        public string OnHand1 { get; set; }
        [Required]
        public string Needed1 { get; set; }
        [Required]
        public string OnHand2 { get; set; }
        [Required]
        public string Needed2 { get; set; }
        [Required]
        public string OnHand3 { get; set; }
        [Required]
        public string Needed3 { get; set; }
        [Required]
        public string OnHand4 { get; set; }
        [Required]
        public string Needed4 { get; set; }
        [Required]
        public string OnHand5 { get; set; }
        [Required]
        public string Needed5 { get; set; }
        [Required]
        public string OnHand6 { get; set; }
        [Required]
        public string Needed6 { get; set; }
        [Required]
        public string OnHand7 { get; set; }
        [Required]
        public string Needed7 { get; set; }
        [Required]
        public string OnHand8 { get; set; }
        [Required]
        public string Needed8 { get; set; }
        [Required]
        public string OnHand9 { get; set; }
        [Required]
        public string Needed9 { get; set; }
        [Required]
        public string OnHand10 { get; set; }
        [Required]
        public string Needed10 { get; set; }
        [Required]
        public string OnHand11 { get; set; }
        [Required]
        public string Needed11 { get; set; }
        [Required]
        public string OnHand12 { get; set; }
        [Required]
        public string Needed12 { get; set; }
        [Required]
        public string OnHand13 { get; set; }
        [Required]
        public string Needed13 { get; set; }
        [Required]
        public string OnHand14 { get; set; }
        [Required]
        public string Needed14 { get; set; }
        [Required]
        public string OnHand15 { get; set; }
        [Required]
        public string Needed15 { get; set; }
        [Required]
        public string OnHand16 { get; set; }
        [Required]
        public string Needed16 { get; set; }
        [Required]
        public string OnHand17 { get; set; }
        [Required]
        public string Needed17 { get; set; }


    }
    public class RespironicsModel : PageModel
    {
        [BindProperty]
        public RespironicsPDF PDFinfo { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<h1>Submitted by: " + PDFinfo.Technician + "</h1>");
                sb.Append("</br>");
                sb.Append("</br>");
                sb.Append("<table border=\"1\">");
                sb.Append("<tr>");
                sb.Append("<th> Medical Supplies  </th><th> Amount Onhand </th><th> Amount Needed </th>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>  Amara View w/ Headgear Small (1090622)</ td><td>" + PDFinfo.OnHand1 + "</td><td>" + PDFinfo.Needed1 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Amara View w/ Headgear Medium (1090623) </ td><td>" + PDFinfo.OnHand2 + "</td><td>" + PDFinfo.Needed2 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Amara View w/ Headgear Large (1090624)  </td>");
                sb.Append("<td>" + PDFinfo.OnHand3 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed3 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Nuance with Headgear (1105160) </td>");
                sb.Append("<td>" + PDFinfo.OnHand4 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed4 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Nuance Pro with Headgear (1105167)  </td>");
                sb.Append("<td>" + PDFinfo.OnHand5 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed5 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Wisp Youth Fabric P/SM/L (1109298) </td>");
                sb.Append("<td>" + PDFinfo.OnHand6 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed6 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>Wisp Fabric Frame SM/L/XL (1137360) </td>");
                sb.Append("<td>" + PDFinfo.OnHand7 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed7 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Wisp Clear Frame SM/L/XL (1137361) </td>");
                sb.Append("<td>" + PDFinfo.OnHand8 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed8 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Dreamwear Fitpack Nasal S/M/L/MW (1137380) </ td>");
                sb.Append("<td>" + PDFinfo.OnHand9 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed9 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Dreamwear Fitpack Pillow S/M/L (1137400) </ td>");
                sb.Append("<td>" + PDFinfo.OnHand10 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed10 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Dreamwear Fitpack Full S/M/L/MW (1137430) </td>");
                sb.Append("<td>" + PDFinfo.OnHand11 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed11 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Cable, High Level Output, (P1080) </ td><td>" + PDFinfo.OnHand12 + "</td><td>" + PDFinfo.Needed12 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> PTAF2 Module (P1287) </td>");
                sb.Append("<td>" + PDFinfo.OnHand13 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed13 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Lightweight Disposable Tubing 6' (532316) (63129)</td>");
                sb.Append("<td>" + PDFinfo.OnHand14 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed14 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Premium Chin Strap (1012911) (63130)</td>");
                sb.Append("<td>" + PDFinfo.OnHand15 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed15 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Tubing 6' (1032907) </ td>");
                sb.Append("<td>" + PDFinfo.OnHand16 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed16 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> DreamWisp (1137953) </ td>");
                sb.Append("<td>" + PDFinfo.OnHand17 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed17 + "</td>");
                sb.Append("</tr>");

                sb.Append("</table>");
                PDFHelper.GeneratePdf(sb.ToString(), HttpContext.Connection.RemoteIpAddress.ToString(), "Respironics Inventory CheckList");
                return Redirect("/Index");
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
