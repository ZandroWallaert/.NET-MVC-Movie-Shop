using System;
using System.Linq;
using System.Collections.Generic;
using howest_movie_lib.Library.Services;
using System.Collections;
using howest_movie_lib.Library.Models;
using howest_movie_shop.ViewModels.Movies;

namespace howest_movie_shop.Library.Handlers
{
    public class TicketHandler
    {
        public TicketViewModel CreateTicket (string name, string payment) {
            TicketViewModel page = new TicketViewModel{
                Fullname = name,
                Paymentmethod = payment
            };
            return page;
        }
    }
}
