using System.ComponentModel.DataAnnotations;

namespace FeedbackManagement.Models;

public class Feedback
{
    [Required(ErrorMessage = "Please enter your name.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters.")]
    [Display(Name = "Your name")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Please enter your email address.")]
    [EmailAddress(ErrorMessage = "Enter a valid email address.")]
    [Display(Name = "Email address")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "Please choose a rating.")]
    [Range(1, 5, ErrorMessage = "Choose a rating from 1 to 5.")]
    [Display(Name = "Rating")]
    public int Rating { get; set; }

    [Required(ErrorMessage = "Please write your comments.")]
    [StringLength(500, MinimumLength = 10, ErrorMessage = "Comments must be between 10 and 500 characters.")]
    [Display(Name = "Your comments")]
    public string Comments { get; set; } = "";

    public DateTime SubmittedAt { get; set; } = DateTime.Now;
}
