namespace Booking.EntityLayer.Concrete
{
	public class New
	{
		public int NewID { get; set; }
		public string? Title { get; set; }
		public string? Tag { get; set; }
		public string? ImageURL { get; set; }
		public DateTime CreatedAt { get; set; }
		public bool IsHome { get; set; }
		public bool IsActive { get; set; }
	}
}