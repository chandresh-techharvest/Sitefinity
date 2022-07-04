using Microsoft.AspNetCore.Mvc;
using Progress.Sitefinity.AspNetCore.ViewComponents;
using Progress.Sitefinity.RestSdk;
using Progress.Sitefinity.RestSdk.Dto;
using Renderer.Entities;

namespace Renderer.ViewComponents
{
    [SitefinityWidget]
    public class NewsApiViewComponent : ViewComponent
    {
        // Invokes the view.
        
        private readonly IRestClient restClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="SitefinityDataViewComponent"/> class.
        /// </summary>
        /// <param name="restClient">The rest service.</param>
        public NewsApiViewComponent(IRestClient restClient)
        {
            this.restClient = restClient;
        }

        /// <summary>
        /// Invokes the view component.
        /// </summary>
        /// <param name="context">The view component context.</param>
        /// <returns>The view component result.</returns>
        public async Task<IViewComponentResult> InvokeAsync(IViewComponentContext<NewsAPIEntity> context)
        {
            var viewModels = await this.GetItems(context.Entity);
            return this.View(viewModels);
        }

        public async Task<IList<SdkItem>> GetItems(NewsAPIEntity entity)
        {
            // when using the OData client, the url is automatically prefixed with the value of web the service and the sitefinity instance url
            // we use an expand the get the related image
            // for more complex queries checkout this sample doc:
            // https://github.com/Sitefinity/sitefinity-aspnetcore-mvc-samples/blob/master/RestSDK.md

            var getAllCategoryArgs = new GetAllArgs
            {
                // required parameter, specifies the items to work with
                Type = RestClientContentTypes.Categories
            };
            //getAllCategoryArgs.Fields.Add("Title");
            var cateresponse = await this.restClient.GetItems<SdkItem>(getAllCategoryArgs);

            var category = cateresponse.Items.Where(w => w.GetValue<string>("Title") == "Sports").FirstOrDefault();
            string id = category != null ? category.Id.ToString() : string.Empty;

            var getAllArgs = new GetAllArgs
            {
                // required parameter, specifies the items to work with
                Type = RestClientContentTypes.News
            };

            // optional parameter, specifies the fields to be returned, if not specified
            // the default service response fields will be returned
            getAllArgs.Fields.Add("Title");
            getAllArgs.Fields.Add("Summary");
            getAllArgs.Fields.Add("Author");
            getAllArgs.Fields.Add("Banner");
            getAllArgs.Fields.Add("PublicationDate");
            getAllArgs.Fields.Add("Category");


            var response = await this.restClient.GetItems<SdkItem>(getAllArgs);
            return response.Items.Where(w => w.GetValue<string[]>("Category").Contains(id)).ToList();
        }

    }
}
