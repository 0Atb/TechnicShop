using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicShop.Model.ViewModels.Areas.Category
{
    public class CategoryListViewModel
    {
        //Kategori Listeleme İşlemleri
        public List<Model.Entity.Category> CategoriesList { get; set; }

        //Kategori Ekleme İşlemleri
        public List<SelectListItem> CategorySelectList { get; set; }

        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public int? MainCategoryId { get; set; }
        public string? CategoryInformation { get; set; }
        public int? Sorting { get; set; }
        public string? Explanation { get; set; }
        public bool IsDeleted { get; set; }
    }
}
