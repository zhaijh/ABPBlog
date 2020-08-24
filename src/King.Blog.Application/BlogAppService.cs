using System;
using System.Collections.Generic;
using System.Text;
using King.Blog.Localization;
using Volo.Abp.Application.Services;

namespace King.Blog
{
    /* Inherit your application services from this class.
     */
    public abstract class BlogAppService : ApplicationService
    {
        protected BlogAppService()
        {
            LocalizationResource = typeof(BlogResource);
        }
    }
}
