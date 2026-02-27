// Define the namespace for all models in this project
namespace Mission5HobbyTracker.Models
{
    // ErrorViewModel holds data displayed on the Error view when an unhandled exception occurs
    public class ErrorViewModel
    {
        // Nullable string property that stores the unique request ID for tracing the error
        public string? RequestId { get; set; }

        // Computed property that returns true when RequestId has a value, used to conditionally show the ID in the view
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
