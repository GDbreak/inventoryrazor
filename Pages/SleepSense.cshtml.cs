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
    public class SleepSensePDF
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


    }
    public class SleepSenseModel : PageModel
    {
        [BindProperty]
        public SleepSensePDF PDFinfo { get; set; }
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
                sb.Append("<td>  Thermocan Pressure Cannula (15807)</ td><td>" + PDFinfo.OnHand1 + "</td><td>" + PDFinfo.Needed1 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> HST Pressure Cannula (15805-FT) </ td><td>" + PDFinfo.OnHand2 + "</td><td>" + PDFinfo.Needed2 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> 9003-L60 Belt </td>");
                sb.Append("<td>" + PDFinfo.OnHand3 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed3 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> 9003-L90 Belt </td>");
                sb.Append("<td>" + PDFinfo.OnHand4 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed4 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> 9003-L120 Belt  </td>");
                sb.Append("<td>" + PDFinfo.OnHand5 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed5 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> 9003-L150 Belt </td>");
                sb.Append("<td>" + PDFinfo.OnHand6 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed6 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>9201-KIT Multi-RIP Module </td>");
                sb.Append("<td>" + PDFinfo.OnHand7 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed7 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td>Adb Belt (9101) </td>");
                sb.Append("<td>" + PDFinfo.OnHand8 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed8 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Chest Belt (9102)</ td>");
                sb.Append("<td>" + PDFinfo.OnHand9 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed9 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Thermocan (1475) </ td>");
                sb.Append("<td>" + PDFinfo.OnHand10 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed10 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Snore Mic. (1250)</ td>");
                sb.Append("<td>" + PDFinfo.OnHand11 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed11 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Pediatric Thermister (1401P) </ td><td>" + PDFinfo.OnHand12 + "</td><td>" + PDFinfo.Needed12 + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Pulse Oximetry for HST (8110-T100A090) </td>");
                sb.Append("<td>" + PDFinfo.OnHand13 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed13 + "</td>");
                sb.Append("</tr>");
                sb.Append("<td> 9010 Reusable Belt </td>");
                sb.Append("<td>" + PDFinfo.OnHand14 + "</td>");
                sb.Append("<td>" + PDFinfo.Needed14 + "</td>");
                sb.Append("</tr>");

                sb.Append("</table>");
                PDFHelper.GeneratePdf(sb.ToString(), HttpContext.Connection.RemoteIpAddress.ToString(), "SleepSense Inventory CheckList");
                return Redirect("/Index");
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }

}