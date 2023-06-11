using Microsoft.AspNetCore.Mvc;

namespace Hangfire.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HangfireController : ControllerBase
    {
        [HttpPost]
        [Route("[action]")]
        // Fire-and-forget Jobs
        public IActionResult Welcome()
        {
            var jobId = BackgroundJob.Enqueue(() => SendWelcomeEmail("Welcome to our app"));
            return Ok($"Job ID: {jobId} Welcome email sent to the user!");
        }

        [HttpPost]
        [Route("[action]")]
        // Delayed Jobs
        public IActionResult Discount()
        {
            var jobId = BackgroundJob.Schedule(() => SendWelcomeEmail("Welcome to our app"), TimeSpan.FromSeconds(30));
            return Ok($"Job ID: {jobId} Discount email will be sent in 30 seconds!");
        }

        [HttpPost]
        [Route("[action]")]
        // Recurring Jobs
        public IActionResult DatabaseUpdate()
        {
            RecurringJob.AddOrUpdate(() => Console.WriteLine("Database updated"), Cron.Minutely);
            return Ok($"Database check job initiated");
        }

        [HttpPost]
        [Route("[action]")]
        // Continuous Jobs
        public IActionResult Confirm()
        {
            var parentJobId = BackgroundJob.Schedule(() => SendWelcomeEmail("You asked to be unsubscribed!"), TimeSpan.FromSeconds(30));

            BackgroundJob.ContinueJobWith(parentJobId, () => Console.WriteLine("You were unsubscribed"));

            return Ok($"Confirmation job created");
        }

        public void SendWelcomeEmail(string text)
        {
            Console.WriteLine(text);
        }
    }
}