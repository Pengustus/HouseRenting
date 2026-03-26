using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HouseRenting.Data.Data.DataConstants.Category;

namespace HouseRenting.Data.Data.Entities
{
    public class Category
    {
        public int Id { get; init; }
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;
        public IEnumerable<House> Houses { get; init; } = new List<House>();
    }
}
