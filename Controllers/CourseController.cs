using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

//course
public class CourseController: Controller{
    //course index


    // public string Index(){
    //     return "course/index";     
    // }
    public IActionResult Index(){
        var kurs= new Course();
        kurs.Id =1;
        kurs.Title= "Aspnet core";
        kurs.Description= "Yeni basladim guzel gibi";
        kurs.Image="1.jpg";
        return View(kurs);
        
    }
    // //course list
    // public IActionResult List(){
    //     return View(); // view ile kullanildiginda ayni isimde dosyayi arar
    // }

    //course list
    public IActionResult List(){
        var kurslar= new List<Course>(){
            new Course(){Id=1,Title="aspnet kursu", Description="guzel bir kurs", Image="1.jpg"},
            new Course(){Id=2,Title="pyhton kursu", Description="iyi bir kurs", Image="2.jpg"},
            new Course(){Id=3,Title="javascript kursu", Description=" harika bir kurs", Image="3.jpg"},
        };
        return View("CourseList", kurslar); // farkli isimde değer gönderilmek istenilirse
    }
}