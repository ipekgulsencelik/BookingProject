namespace Booking.EntityLayer.Concrete
{
	public class Testimonial
	{
		public int TestimonalID { get; set; }
		public string? Description { get; set; }
		public string? NameSurname { get; set; }
		public bool IsHome { get;}
		public bool IsActice { get; set; }
	}
}