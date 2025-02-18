using Microsoft.AspNetCore.Mvc;
using MyApp.Namespace; // Replace with your actual namespace
using Microsoft.Extensions.Logging; // Add this for logging (optional)
using System;

namespace MyApp.Namespace
{
    public class ContactController : Controller
    {
        // GET: ContactController
        public ActionResult Index()
        {
            return View();
        }

        // POST: Submit Contact Form
        [HttpPost]
        public IActionResult SubmitContactForm(string name, string email, string message)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(message))
                {
                    return Json(new { success = false, message = "All fields are required." });
                }

                // Simulate form submission logic (e.g., saving to database, sending email)
                // In a real application, you would implement logic here to process the contact form.

                // For now, we'll simulate success
                return Json(new { success = true, message = "Thank you for your message! We will get back to you shortly." });
            }
            catch (Exception ex)
            {
                // Log the error (optional)
                Console.WriteLine($"Error: {ex.Message}");

                // Return error response
                return Json(new { success = false, message = "An error occurred while submitting the form. Please try again later." });
            }
        }
    }
}
