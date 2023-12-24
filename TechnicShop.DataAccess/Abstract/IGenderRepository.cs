using Infrastructure.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicShop.Model.Entity;

namespace TechnicShop.DataAccess.Abstract
{
    public interface IGenderRepository : IRepository<Gender>
    {
    }
}

//public class Gender() :Controller
//{

//IGender genderBs;

//ctor(IGender _genderBs){
//
//genderBs = _genderBs
//
//}

//public IActionResult Get(){
//
// Gender genderlist = gerderBs.GetAll().Tolist();
//
//return View(genderlist);
//}


//Eski Yol
//public IActionResult Get(){


//IGenderRepository gender = new EfGenderRepository();

//List<Gender> genderlist = gender.getAll().Tolist();

//return View(genderlist)
//}