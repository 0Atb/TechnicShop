using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechnicShop.Bussiness.Abstract;
using TechnicShop.Model.Entity;
using TechnicShop.Model.ViewModels.Areas.Category;

namespace TechnicShop.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KategoriController : Controller
    {
        ICategoryBs _categoryBs;

        public KategoriController(ICategoryBs categoryBs)
        {
            _categoryBs = categoryBs;
        }

        public IActionResult List()
        {
            CategoryListViewModel model = new CategoryListViewModel();
            List<Category> categories = _categoryBs.GetAll().ToList();

            model.CategoriesList= categories;

            model.CategorySelectList = categories.Select(x => new SelectListItem() { Text = x.CategoryInformation, Value = x.Id.ToString() }).ToList();

            model.CategorySelectList.Insert(0, new SelectListItem("Lütfen Bir Kategori Seçiniz", "-1"));

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(CategoryListViewModel model)
        {
            Category category = new Category();
            category.CategoryName = model.CategoryName;
            category.MainCategoryId = model.MainCategoryId;
            category.Sorting = model.Sorting;
            category.Explanation = model.Explanation;
            category.IsDeleted = model.IsDeleted;

            if (model.MainCategoryId != -1)
            {
                Category mainCategory = _categoryBs.Get(x => x.Id == model.MainCategoryId);

                category.CategoryInformation = mainCategory.CategoryName + " > " + model.CategoryName;
            }
            else
            {
                category.CategoryInformation = model.CategoryName;
            }

            _categoryBs.Insert(category);

            List<Category> categories = _categoryBs.GetAll();

            return Json(new { result = true, Mesaj = "Kategori Başarıyla Eklendi." });
        }



    }
}
