using King.Blog.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace King.Blog.HttpApi.Hosting.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class BlogPageModel : AbpPageModel
    {
        protected BlogPageModel()
        {
            LocalizationResourceType = typeof(BlogResource);
        }
    }
}