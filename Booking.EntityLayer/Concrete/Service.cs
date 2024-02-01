namespace Booking.EntityLayer.Concrete
{
	public class Service
	{
		public int ServicesID { get; set; }
		public string? ImageURL { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public bool IsHome { get; set; }
		public bool IsActive { get; set; }
	}
}