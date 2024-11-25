
namespace RazorPagesEx.RouteConstraints
{
    public class NumberRouteContraints : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if(int.TryParse(values[routeKey].ToString(), out int result))
            {
                if(result > 0)
                {
                    return true;
                }
            }
            return false;
            
        }
    }
}
