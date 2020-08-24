using King.Blog.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace King.Blog.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class BlogController : AbpController
    {
        protected BlogController()
        {
            LocalizationResource = typeof(BlogResource);
        }
    }
}