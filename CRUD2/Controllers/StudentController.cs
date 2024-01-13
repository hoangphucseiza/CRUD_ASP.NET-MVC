using CRUD2.Data;
using CRUD2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD2.Controllers
{
    public class StudentController : Controller
    {
        
        private readonly MVCDemoDbContext _Db;
        public StudentController(MVCDemoDbContext mvcDemoDbContext)
        {
            this._Db = mvcDemoDbContext;

        }

        public IActionResult StudentList()
        {
            try
            {
                //var students = mvcDemoDbContext.tbl_Student.ToList();

                var stdList = from a in _Db.tbl_Student
                              join b in _Db.tbl_Departments
                              on a.DepID equals b.ID
                              into Dep
                              from b in Dep.DefaultIfEmpty()

                              select new Student
                              {
                                  ID = a.ID,
                                  Name = a.Name,
                                  Fname = a.Fname,
                                  Email = a.Email,
                                  Mobile = a.Mobile,
                                  Description = a.Description,
                                  DepID = a.DepID,
                                  Department = b == null ? "" : b.Department,
                              };

                
                             
                return View(stdList);
            }
            catch (Exception)
            {

                return View();
            }
            
        }
        
        public IActionResult Create(Student obj)
        {
            loadDDL();
            return View(obj);
             
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(Student obj)
        {
            try
            {
              
                    if (obj.ID == 0)
                    {
                        _Db.tbl_Student.Add(obj);
                        await _Db.SaveChangesAsync();
                    }
                    else
                    {
                        _Db.Entry(obj).State = EntityState.Modified;
                        await _Db.SaveChangesAsync();
                    }

                return View(obj);
            }
            catch (Exception ex)
            {

                return RedirectToAction("StudentList");
            }
        }



        public async Task<IActionResult> DeleteStd(int id)
        {
            try
            {
                var std = await _Db.tbl_Student.FindAsync(id);
                if (std != null)
                {
                    _Db.tbl_Student.Remove(std);
                    await _Db.SaveChangesAsync();
                }    
                return RedirectToAction("StudentList");
            }
            catch(Exception ex)
            {
                return RedirectToAction("StudentList");
            }
        }

        private void loadDDL()
        {
            try
            {
                List<Departments> depList = new List<Departments>();

                depList =_Db.tbl_Departments.ToList();

                depList.Insert(0, new Departments { ID = 0, Department = "Select" });

                ViewBag.DepList = depList;

            }
            catch(Exception)
            {
                
            }
        }
    }
}
