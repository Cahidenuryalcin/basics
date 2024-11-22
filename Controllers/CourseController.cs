using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

//course
public class CourseController: Controller{
   
    public IActionResult Index(){
        var kurs= new Course();
        kurs.Id =1;
        kurs.Title= "Aspnet core";
        kurs.Description= "Yeni basladim guzel gibi";
        kurs.Image="1.jpg";
        return View(kurs);
        
    }
   


public IActionResult Details(int? id){
        if (id==null)
        {
            // return Redirect("/course/list");
            return RedirectToAction("List", "Course");

        }
        var kurs= Repository.GetById(id);
        return View(kurs);
        
    }
    //course list
    public IActionResult List(){
        
         return View("CourseList", Repository.Courses); 
    }
}