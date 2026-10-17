using FeedbackManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackManagement.Controllers;

public class FeedbackController : Controller
{
    // Simple in-memory storage for this classroom demonstration.
    private static readonly List<Feedback> FeedbackEntries = [];

    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.FeedbackEntries = FeedbackEntries.OrderByDescending(item => item.SubmittedAt).ToList();
        return View(new Feedback());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(Feedback feedback)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.FeedbackEntries = FeedbackEntries.OrderByDescending(item => item.SubmittedAt).ToList();
            return View(feedback);
        }

        feedback.SubmittedAt = DateTime.Now;
        FeedbackEntries.Add(feedback);
        TempData["SuccessMessage"] = "Thank you! Your feedback has been submitted.";
        return RedirectToAction(nameof(Index));
    }
}
