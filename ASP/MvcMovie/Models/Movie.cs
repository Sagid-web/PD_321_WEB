using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
	public int Id { get; set; }
	[StringLength(60,MinimumLength = 3)]
	[Required]
	public required string Title { get; set; }
	[Display(Name = "Realease date")]
	[DataType(DataType.Date)]
	public DateTime? ReleaseDate { get; set; } //Nullable fields
	[RegularExpression(@"[A-Z+[a-zA-Z\s]*$")]
	public string? Genre {  get; set; }
	[Required]
	public decimal Price { get; set; }
	public string? Rating { get; set; }	
}
