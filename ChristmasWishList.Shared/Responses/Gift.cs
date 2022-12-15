namespace ChristmasWishList.Shared.Responses
{
    public class Gift
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string NameGift { get; set; }
        public decimal Price { get; set; }
        public bool IsPurchased { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }

    }
}
