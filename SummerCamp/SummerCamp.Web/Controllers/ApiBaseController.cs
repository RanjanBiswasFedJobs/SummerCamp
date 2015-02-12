using System.Web.Http;
using SummerCamp.Data.Contracts;


namespace CodeCamper.Web.Controllers
{
    public abstract class ApiControllerBase : ApiController
    {
        protected ISummerCampUow Uow { get; set; }

      
    }

}
