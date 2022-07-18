using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{

    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Too Long Name")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Too Long Short Name")]
        public string ShortName { get; set; }
    }
    public class CountryDTO: CreateCountryDTO
    {
        public int Id { get; set; }
        public  IList<HotelDTO> Hotels { get; set; }

    }
}
