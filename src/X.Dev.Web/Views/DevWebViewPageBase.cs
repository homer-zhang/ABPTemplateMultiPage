using Abp.Web.Mvc.Views;

namespace X.Dev.Web.Views
{
    public abstract class DevWebViewPageBase : DevWebViewPageBase<dynamic>
    {

    }

    public abstract class DevWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected DevWebViewPageBase()
        {
            LocalizationSourceName = DevConsts.LocalizationSourceName;
        }
    }
}