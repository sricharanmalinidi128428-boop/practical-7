# Experiment 7 — Feedback Management

Beginner-friendly ASP.NET Core MVC example showing a shared layout, a partial view, HTML Helpers, and validation.

## Open in Visual Studio

Open `Practical7.sln` from the workspace folder. Set **FeedbackManagement** as the startup project, then press **F5**. The feedback page opens at `/`.

## Main files

- `Models/Feedback.cs` — feedback fields and validation attributes.
- `Controllers/FeedbackController.cs` — displays the form, checks submitted values, and adds valid feedback to a simple in-memory list.
- `Views/Shared/_Layout.cshtml` — common header and footer.
- `Views/Shared/_FeedbackForm.cshtml` — reusable form partial made with `Html.BeginForm`, `LabelFor`, `TextBoxFor`, `DropDownListFor`, `TextAreaFor`, and validation helpers.
- `Views/Feedback/Index.cshtml` — page that displays the form and submitted feedback.

Submitted items are stored in memory for demonstration, so they reset when the application stops. No database is required.
