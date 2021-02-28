namespace Game
{
    class CampaignManager : ICampaign
    {
        public void Add(Campaign campaign)
        {
            System.Console.WriteLine("You win discount :  "+campaign.CampaignDiscountRate);
        }

        public void Delete(Campaign campaign)
        {
            System.Console.WriteLine("Campaign deleted");
        }

        public void Uptade(Campaign campaign)
        {
            System.Console.WriteLine("Campaign Updated");
        }
    }

}
