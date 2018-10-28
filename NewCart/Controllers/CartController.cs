using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NewCart.Models;

/*
 * Usernames are assumed to be Id s for simplification, hence uniquely identify a cart
 */
namespace NewCart.Controllers
{
    [RoutePrefix("api/cart")]
    public class CartController : ApiController
    {
        [Route("{username}")]
        public Task<IHttpActionResult> Get()
        {
            var result = new List<CartItem>();
            result.Add(new CartItem(){Name = "bread", Cost});

        }
    }
}
