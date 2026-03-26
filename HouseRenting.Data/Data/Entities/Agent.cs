using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HouseRenting.Data.Data.DataConstants.Agent;


namespace HouseRenting.Data.Data.Entities
{
    public class Agent
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [MaxLength(PhoneNumberMaxLength)]
        [Required]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        public string UserId { get; set; } = null!;
        public IdentityUser User { get; set; } = null!;
        public IEnumerable<House> ManagedHouses { get; set; } = new List<House>();
    }
}
