using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicShop.Model.ViewModels.Areas.Home
{
    public class ProfileViewModel
    {
        public List<SelectListItem> ProfileList { get; set; }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? AdminName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public Guid? UniqueId { get; set; }
        public int? CityId { get; set; }
        public int? GenderId { get; set; }
        public string? PhoneNumber { get; set; }
        public int? MaritalStatusId { get; set; }
        public int? CountryId { get; set; }
    }
}
