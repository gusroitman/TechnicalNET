using TecNET.Shared.Models;

namespace TecNET.Client.Services
{
    public partial class QuestionsService
    {
        private readonly List<Questions> _entries = new List<Questions>
        {
            new Questions { Id = 1, Title = "What is an object in C#?", Category = ".NET", Content = "Blazor is a web framework for building client-side web applications using .NET and C#. You can use Blazor to write interactive UI components that run entirely in the browser, or you can use it to build full-featured single-page applications (SPAs) that communicate with a server-side API." },
            new Questions { Id = 2, Title = "What is a class in C#?", Category = ".NET", Content = "Entity Framework Core (EF Core) is a lightweight, extensible, and cross-platform version of the popular Entity Framework data access technology. EF Core allows you to work with relational databases using a strongly-typed, LINQ-based API that abstracts away many of the low-level details of working with databases." },
            new Questions { Id = 3, Title = "What is the difference between object and class?", Category = ".NET", Content = "You can use HTML in Blazor by using the <Markup> component. This component allows you to include raw HTML in your Blazor components. Here's an example: <Markup><p>This is some <b>bold</b> text</p></Markup>" },


            new Questions
            {
                Id = 4,
                Title = "What are the pillars of OOP?",
                Category = ".NET",
                Content = "<p>You can use HTML in Blazor by using the <code>&lt;Markup&gt;</code> component. This component allows you to include raw HTML in your Blazor components.</p><p>Here's an example:</p><pre><code>&lt;Markup&gt;&lt;p&gt;This is some &lt;b&gt;bold&lt;/b&gt; text&lt;/p&gt;&lt;/Markup&gt;</code></pre>"
            }
        };
    }
}
