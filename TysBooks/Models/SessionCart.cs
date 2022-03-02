using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TysBooks.Infrastructure;

namespace TysBooks.Models.ViewModels
{
    public class SessionCart : Cart //inheriting from the cart class
    {
        public static Cart GetCart (IServiceProvider services) //gives information about session
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();

            cart.Session = session;

            return cart;
        }

        [JsonIgnore]

        public ISession Session { get; set; }

        public override void AddItem(Books book, int qty)
        {
            base.AddItem(book, qty);
            Session.SetJson("Cart", this);
        }

        public override void RemoveItem(Books book)
        {
            base.RemoveItem(book);
            Session.SetJson("Cart", this);
        }

        public override void ClearCart()
        {
            base.ClearCart();
            Session.Remove("Cart");
        }
    }
}
