namespace ChristmasWishList.Shared.Responses
{
    public class GiftResponse
    {
        public int TotalGift { get; init; }
        public decimal TotalAmount { get; init; }
        public decimal TotalSpent { get; init; }
        public decimal TotalToSpent { get; init; }
        public List<Gift> Gifts { get; init; }

        public GiftResponse(List<Gift> gifts)
        {
            TotalGift = gifts?.Count ?? 0;
            Gifts = gifts;
        }
        public GiftResponse(int totalGift,decimal totalAmount,decimal totalSpent, decimal totalToSpent, List<Gift> gifts)
        {
            TotalGift = totalGift;
            TotalAmount = totalAmount;
            TotalSpent = totalSpent;
            TotalToSpent = totalToSpent;
            Gifts = gifts;
        }
    }
}
