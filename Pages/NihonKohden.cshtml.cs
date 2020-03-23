using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UnitedSleepInventoryForms.Helpers;

namespace UnitedSleepInventoryForms
{

    public class NihonKohdenPDF
    {

        [Required]
        public string Technician { get; set; }
        [Required]
        public string YG125TOnHand { get; set; }
        [Required]
        public string YG125TNeeded { get; set; }
        [Required]
        public string YG135TOnHand { get; set; }
        [Required]
        public string YG135TNeeded { get; set; }
        [Required]
        public string YG225TOnHand { get; set; }
        [Required]
        public string YG225TNeeded { get; set; }
        [Required]
        public string YG235TOnHand { get; set; }
        [Required]
        public string YG235TNeeded { get; set; }
        [Required]
        public string JB110AOnHand { get; set; }
        [Required]
        public string JB110ANeeded { get; set; }
        [Required]
        public string JL550T1OnHand { get; set; }
        [Required]
        public string JL550T1Needed { get; set; }
        [Required]
        public string TG921T3OnHand { get; set; }
        [Required]
        public string TG921T3Needed { get; set; }
        [Required]
        public string TL631T3OnHand { get; set; }
        [Required]
        public string TL631T3Needed { get; set; }
        [Required]
        public string JE915AOnHand { get; set; }
        [Required]
        public string JE915ANeeded { get; set; }
        [Required]
        public string JE915A683485BOnHand { get; set; }
        [Required]
        public string JE915A683485BNeeded { get; set; }

    }
    public class NihonKohdenModel : PageModel
    {
        [BindProperty]
        public NihonKohdenPDF PDFinfo { get; set; }



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
                sb.Append("<td> Nasal Adapter End Tidal USD(YG - 125T) </td><td>" + PDFinfo.YG125TOnHand + "</td><td>" + PDFinfo.YG125TNeeded + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Nasal Adapter Ped End Tidal USD(YG - 135T) </td>");
                sb.Append("<td>" + PDFinfo.YG135TOnHand + "</td>");
                sb.Append("<td>" + PDFinfo.YG135TNeeded + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Nasal Adapter Adult End Tidal NW(YG - 225T) </td>");
                sb.Append("<td>" + PDFinfo.YG225TOnHand + "</td>");
                sb.Append("<td>" + PDFinfo.YG225TNeeded + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Nasal Adapter Ped End Tidal NW(YG - 235T) </td>");
                sb.Append("<td>" + PDFinfo.YG235TOnHand + "</td>");
                sb.Append("<td>" + PDFinfo.YG235TNeeded + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Head - Box PSG 1100(JB - 110A) </td>");
                sb.Append("<td>" + PDFinfo.JB110AOnHand + "</td>");
                sb.Append("<td>" + PDFinfo.JB110ANeeded + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Sp02 Adapter(JL - 550T1) </td>");
                sb.Append("<td>" + PDFinfo.JL550T1OnHand + "</td>");
                sb.Append("<td>" + PDFinfo.JL550T1Needed + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> C02 Sensor(TG - 921T3) </td>");
                sb.Append("<td>" + PDFinfo.TG921T3OnHand + "</td>");
                sb.Append("<td>" + PDFinfo.TG921T3Needed + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Finger Probe Sensor(TL - 631T3) </td>");
                sb.Append("<td>" + PDFinfo.TL631T3OnHand + "</td>");
                sb.Append("<td>" + PDFinfo.TL631T3Needed + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Head Box JE - 915A </td>");
                sb.Append("<td>" + PDFinfo.JE915AOnHand + "</td>");
                sb.Append("<td>" + PDFinfo.JE915ANeeded + "</td>");
                sb.Append("</tr>");
                sb.Append("<tr>");
                sb.Append("<td> Cable for JE - 915A(683485B) </td>");
                sb.Append("<td>" + PDFinfo.JE915A683485BOnHand + "</td>");
                sb.Append("<td>" + PDFinfo.JE915A683485BNeeded + "</td>");
                sb.Append("</tr>");
                sb.Append("</table>");
                PDFHelper.GeneratePdf(sb.ToString(), HttpContext.Connection.RemoteIpAddress.ToString(), "Nihon Kohden Inventory Checklist");
                return Redirect("/Index");
            }
            catch (Exception e)
            {
                throw;
            }
        }


    }
}