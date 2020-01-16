using System.ComponentModel.DataAnnotations;

namespace BestRestaurant.Models
{
    public class Restaurant
    {
        [Key]
        public int idRestaurant { get; set; }
        public int CuisineId { get; set; }
        public string Name { get; set; }
        public string BestFood { get; set; }

        public virtual Cuisine Cuisine { get; set; }
    }
}
