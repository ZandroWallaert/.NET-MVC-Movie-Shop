using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace howest_movie_shop.Library.Seeders
{
    class MoviePriceSeeder
    {
        /* private PriceManager<IdentityPrice> priceManager = null;

        public MoviePriceSeeder(IServiceProvider serviceProvider){
            this.priceManager = serviceProvider.GetRequiredService<PriceManager<IdentityPrice>>();
            
        }

        public void Run(){
            int Min = 0;
            int Max = 20;
            Random randNum = new Random();
            int[] prices = Enumerable
            .Repeat(0, 5)
            .Select(i => randNum.Next(Min, Max))
            .ToArray();

            CreatePrice(prices).Wait();
        }

        private async Task CreatePrice(int[] prices) {
            PriceResult priceResult;
            foreach (var price in prices) {
                var priceExist = await this.priceManager.PriceExistsAsync(price); 
                if (!priceExist)
                {
                    priceResult = await this.priceManager.CreateAsync(new IdentityPrice(price)); 
                }
            }
        } */
    }
}