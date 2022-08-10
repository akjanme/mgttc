using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using ITI.Web.Data;
using ITI.Models;

namespace ITI.Web.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Feedback()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Feedback(FeedbackModel model)
        //{
        //    var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
        //    var message = new MailMessage();
        //    message.To.Add(new MailAddress("recipient@gmail.com"));  // replace with valid value 
        //    message.From = new MailAddress("sender@outlook.com");  // replace with valid value 
        //    message.Subject = "Your email subject";
        //    message.Body = string.Format(body, model.email, model.name, model.massage);
        //    message.IsBodyHtml = true;

        //    using (var smtp = new SmtpClient())
        //    {
        //        var credential = new NetworkCredential
        //        {
        //            UserName = "user@outlook.com",  // replace with valid value
        //            Password = "password"  // replace with valid value
        //        };
        //        smtp.Credentials = credential;
        //        smtp.Host = "smtp-mail.outlook.com";
        //        smtp.Port = 587;
        //        smtp.EnableSsl = true;
        //        smtp.SendMailAsync(message);
        //        return RedirectToAction("Sent");
        //    }
        //    return View();
        //}
    }
}