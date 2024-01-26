using System.Web;
using System.Web.Mvc;

namespace HotelFuen31.BackEnd.Site
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
