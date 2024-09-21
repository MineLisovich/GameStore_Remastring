using Microsoft.AspNetCore.Mvc.Razor;

namespace GameStore.WEB.Infrastrcture
{
    /// <summary>
    /// Класс для рассширенного поиска частичный представлений
    /// </summary>
    public class PartialLocationExpander : IViewLocationExpander
    {
        public void PopulateValues(ViewLocationExpanderContext context)
        {

        }
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context,
                                                      IEnumerable<string> viewLocations)
        {
            //Логика Фримена стр.687
            foreach (var location in viewLocations)
            {
                yield return location;
            }
            yield return "/Views/Shared/ModalAction/{0}.cshtml";


            //моя логика
            //мб пригодится потом 
            //var area = context.ActionContext.RouteData.Values["area"]?.ToString();

            //if (area == "Admin")
            //{
            //    return new[]
            //    {
            //        "/Areas/Admin/Views/{1}/{0}.cshtml",
            //        "/Areas/Admin/Views/Shared/{0}.cshtml",
            //        "/Views/Shared/ModalAction/{0}.cshtml",
            //        "/Views/Shared/{0}.cshtml"
            //    };
            //}
            //else return new[]
            //{
            //    "/Views/{1}/{0}.cshtml",
            //    "/Views/Shared/ModalAction/{0}.cshtml",
            //    "/Views/Shared/{0}.cshtml"
            //};

        }

    }

}
