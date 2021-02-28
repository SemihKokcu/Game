using Game.Concrete;
using Game.Abstract;


namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id =1,
                FirstName="semih",
                LastName="kökçü",
                DateOfBirth = new System.DateTime(2000,11,23),
                NationalityId="12345678910"

            };

            Games game = new Games
            {
                Id=1,
                GameName="CALL OF DUTY MODERN WARFARE 4",
                Price= 20
            };

            Campaign campaign = new Campaign
            {
                CampaignName= "new customer campaigne",
                CampaignDiscountRate = 20
            };

            BaseCustomerManager customerManager = new BaseCustomerManager();
            CampaignManager campaignManager = new CampaignManager();
            GameManager gameManager = new GameManager();
            customerManager.Add(customer);
            campaignManager.Add(campaign);
            gameManager.Sell(game, customer);
            gameManager.SellWithDiscount(game, customer, campaign);




            System.Console.WriteLine(customer+ "\n"+campaign);
           
        }
    }

}
