using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

//course
public class CourseController: Controller{
    //course index


    // public string Index(){
    //     return "course/index";     
    // }
    public IActionResult Index(){
        return View();
        
    }
    //course list
    public IActionResult List(){
        return View("CourseList");
    }
}