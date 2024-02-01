namespace Booking.EntityLayer.Concrete
{
	public class SocialMedia
	{
		public int SocialMediaID { get; set; }
		public string? SocialMediaIcon { get; set; }
		public string? SocialMediaURL { get; set; }
		public bool IsFooter { get; set; }
		public bool IsActive { get; set; }
	}
}