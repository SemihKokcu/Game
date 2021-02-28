namespace Game
{
    public interface IGame
    {
        void Sell(Games games, Customer customer);
        void SellWithDiscount(Games games, Customer customer, Campaign campaign);
    }

}
