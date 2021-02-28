using System;

namespace Game
{
    class GameManager : IGame
    {
        public void Sell(Games games, Customer customer)
        {
            Console.WriteLine("Game Name:" + games.GameName + "\nthe customer is bought:" + customer.FirstName);
        }

        public void SellWithDiscount(Games games, Customer customer, Campaign campaign)
        {
            Console.WriteLine("Game Name:" + games.GameName + "\nthe customer is bought:" + customer.FirstName+"\nDiscount:"+campaign.CampaignDiscountRate);
        }
    }

}
