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
    public class ResMedPDF
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
        [Required]
        public string OnHand18 { get; set; }
        [Required]
        public string Needed18 { get; set; }
        [Required]
        public string OnHand19 { get; set; }
        [Required]
        public string Needed19 { get; set; }
        [Required]
        public string OnHand20 { get; set; }
        [Required]
        public string Needed20 { get; set; }
        [Required]
        public string OnHand21 { get; set; }
        [Required]
        public string Needed21 { get; set; }
        [Required]
        public string OnHand22 { get; set; }
        [Required]
        public string Needed22 { get; set; }
        [Required]
        public string OnHand23 { get; set; }
        [Required]
        public string Needed23 { get; set; }
        [Required]
        public string OnHand24 { get; set; }
        [Required]
        public string Needed24 { get; set; }
        [Required]
        public string OnHand25 { get; set; }
        [Required]
        public string Needed25 { get; set; }
        [Required]
        public string OnHand26 { get; set; }
        [Required]
        public string Needed26 { get; set; }
        [Required]
        public string OnHand27 { get; set; }
        [Required]
        public string Needed27 { get; set; }
        [Required]
        public string OnHand28 { get; set; }
        [Required]
        public string Needed28 { get; set; }
        [Required]
        public string OnHand29 { get; set; }
        [Required]
        public string Needed29 { get; set; }
        [Required]
        public string OnHand30 { get; set; }
        [Required]
        public string Needed30 { get; set; }
        [Required]
        public string OnHand31 { get; set; }
        [Required]
        public string Needed31 { get; set; }
        [Required] 
        public string OnHand32 { get; set; }
        [Required]
        public string Needed32 { get; set; }
        [Required]
        public string OnHand33 { get; set; }
        [Required]
        public string Needed33 { get; set; }
    }
    public class ResMedModel : PageModel
    {
        [BindProperty]
        public ResMedPDF PDFinfo { get; set; }
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
                sb.Append("<th> Medical Supplies </th><th> Amount Onhand </th><th> Amount Needed </th>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Mirage Quattro FFM Size Small (61233) </ td><td>" + PDFinfo.OnHand1 + "</td><td>" + PDFinfo.Needed1 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Mirage Quattro FFM Size Medium (61234)  </td>");
                sb.Append("<td>" + PDFinfo.OnHand2 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed2 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Mirage Quattro FFM Size Large (61235) </td>");
                sb.Append("<td>" + PDFinfo.OnHand3 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed3 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Swift FX SLM (61508)  </td>");
                sb.Append("<td>" + PDFinfo.OnHand4 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed4 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Quattro FX Size Small (61715) </td>");
                sb.Append("<td>" + PDFinfo.OnHand5 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed5 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>Quattro FX Size Medium (61716) </td>");
                sb.Append("<td>" + PDFinfo.OnHand6 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed6 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Quattro FX Size Large (61717) </td>");
                sb.Append("<td>" + PDFinfo.OnHand7 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed7 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Mirage FX Nasal Standard (62104) </ td>");
                sb.Append("<td>" + PDFinfo.OnHand8 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed8 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Mirage FX Nasal Wide (62119) </ td>");
                sb.Append("<td>" + PDFinfo.OnHand9 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed9 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Airfit P10 SLM (62925) </td>");
                sb.Append("<td>" + PDFinfo.OnHand10 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed10 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> AirTouch F20 Size Small (63005) </ td><td>" + PDFinfo.OnHand11 + "</td><td>" + PDFinfo.Needed11 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>AirTouch F20 Size Medium (63006) </ td>");
                sb.Append("<td>" + PDFinfo.OnHand12 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed12 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> AirTouch F20 Size Large (63007) </td>");
                sb.Append("<td>" + PDFinfo.OnHand13 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed13 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> AirFit F10 FFM SLM Size Small (63129)</td>");
                sb.Append("<td>" + PDFinfo.OnHand14 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed14 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> AirFit F10 FFM SLM Size Medium (63130)</td>");
                sb.Append("<td>" + PDFinfo.OnHand15 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed15 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> AirFit F10 FFM SLM Size Large (63131) </td>");
                sb.Append("<td>" + PDFinfo.OnHand16 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed16 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> AirFit F20 Size Small (63445) </td>");
                sb.Append("<td>" + PDFinfo.OnHand17 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed17 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>AirFit F20 Size Medium (63446) </td>");
                sb.Append("<td>" + PDFinfo.OnHand18 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed18 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> AirFit F20 Size Large (63447) </td>");
                sb.Append("<td>" + PDFinfo.OnHand19 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed19 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>AirFit N20 Size Small (63504)s</td>");
                sb.Append("<td>" + PDFinfo.OnHand20 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed20 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> AirFit N20 Size Medium (63506)</ td><td>" + PDFinfo.OnHand21 + "</td><td>" + PDFinfo.Needed21 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>AirFit N20 Size Large (63507)</td>");
                sb.Append("<td>" + PDFinfo.OnHand22 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed22 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> AirFit F30 Size Small (64104)</td>");
                sb.Append("<td>" + PDFinfo.OnHand23 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed23 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> AirFit F30 Size Medium (64105) </td>");
                sb.Append("<td>" + PDFinfo.OnHand24 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed24 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> XPOD (22305) </ td>");
                sb.Append("<td>" + PDFinfo.OnHand25 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed25 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> EasySense Respiratory Effort Sensor (22321) </td>");
                sb.Append("<td>" + PDFinfo.OnHand26 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed26 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> XPOD Clip (22371) </td>");
                sb.Append("<td>" + PDFinfo.OnHand27 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed27 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>Apnea Link Air Bag (22373)  </td>");
                sb.Append("<td>" + PDFinfo.OnHand28 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed28 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>Upload Cable for Apnea Link Plus (629051)</td>");
                sb.Append("<td>" + PDFinfo.OnHand29 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed29 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>Reusable Belt (629052)</td>");
                sb.Append("<td>" + PDFinfo.OnHand30 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed30 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Battery Cover (19683)</ td><td>" + PDFinfo.OnHand31 + "</td><td>" + PDFinfo.Needed31 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> F30i Medium</ td><td>" + PDFinfo.OnHand32 + "</td><td>" + PDFinfo.Needed32 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Chin Strap</ td><td>" + PDFinfo.OnHand33 + "</td><td>" + PDFinfo.Needed33 + "</td>");
                sb.Append("</tr>");
                sb.Append("</table>");
                PDFHelper.GeneratePdf(sb.ToString(), HttpContext.Connection.RemoteIpAddress.ToString(), "ResMed Inventory CheckList");
                return Redirect("/Index");
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}