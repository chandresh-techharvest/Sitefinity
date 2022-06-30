using Microsoft.AspNetCore.Mvc;
using Progress.Sitefinity.AspNetCore.ViewComponents;
using Renderer.Entities;

namespace Renderer.ViewComponents
{

    [SitefinityWidget]
    public class CustomNewsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IViewComponentContext<CustomNewsEntity> context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            context.Entity.Title = "The importance of Leadership Conference in 2022";
            context.Entity.Body = "Leadership Event is one-page Bootstrap v5.1.3 CSS layout for your website. Thank you for choosing TemplateMo website where you can instantly download free CSS templates at no cost.";
            context.Entity.NewsDate = DateTime.Now;
            context.Entity.ScheduleLink = "#section_4";
            context.Entity.SpeakersLink = "#section_3";

            return this.View(context.Entity);
        }
    }
}

