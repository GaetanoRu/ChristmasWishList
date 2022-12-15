namespace ChristmasWishList.Shared.Requests
{
    public class SaveGiftRequest
    {
        public string FirstName { get; set; }
        public string NameGift { get; set; }
        public decimal Price { get; set; }
        public bool IsPurchased { get; set; }
    }
}
