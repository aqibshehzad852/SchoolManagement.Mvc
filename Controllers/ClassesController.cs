using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Mvc.Data;
using SchoolManagement.Mvc.Models;



namespace SchoolManagement.Mvc.Controllers
{
    public class ClassesController : Controller
    {
        private readonly SchoolManagementDbContext _context;

        public ClassesController(SchoolManagementDbContext context)
        {
            _context = context;
        }

        // GET: Classes
        public async Task<IActionResult> Index()
        {
            var schoolManagementDbContext = _context.Classes.Include(p => p.Course).Include(p => p.Lecturer);
            return View(await schoolManagementDbContext.ToListAsync());
        }

        // GET: Classes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Classes == null)
            {
                return NotFound();
            }

            var @class = await _context.Classes
                .Include(p => p.Course)
                .Include(p => p.Lecturer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@class == null)
            {
                return NotFound();
            }

            return View(@class);
        }

        // GET: Classes/Create
        public IActionResult Create()
        {
            CreateSelectLists();
            return View();
        }

        // POST: Classes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LecturerId,CourseId,Time")] Class @class)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@class);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            CreateSelectLists();
            return View(@class);
        }

        // GET: Classes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Classes == null)
            {
                return NotFound();
            }

            var @class = await _context.Classes.FindAsync(id);
            if (@class == null)
            {
                return NotFound();
            }
            CreateSelectLists();
            return View(@class);
        }

        // POST: Classes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LecturerId,CourseId,Time")] Class @class)
        {
            if (id != @class.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@class);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassExists(@class.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            CreateSelectLists();
            return View(@class);
        }

        // GET: Classes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Classes == null)
            {
                return NotFound();
            }

            var @class = await _context.Classes
                .Include(p => p.Course)
                .Include(p => p.Lecturer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@class == null)
            {
                return NotFound();
            }

            return View(@class);
        }

        // POST: Classes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Classes == null)
            {
                return Problem("Entity set 'SchoolManagementDbContext.Classes'  is null.");
            }
            var @class = await _context.Classes.FindAsync(id);
            if (@class != null)
            {
                _context.Classes.Remove(@class);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> ManageEnrollments(int classId)
        {
            var @class= await _context.Classes
            .Include(p => p.Course)
            .Include(p => p.Lecturer)
            .Include(p => p.Enrollments)
            .ThenInclude(p => p.Student)
            .FirstOrDefaultAsync(m => m.Id == classId);

            var students = await _context.Students.ToListAsync();

            var model= new ClassEnrollmentViewModel();
            model.Class = @class;
            foreach(var stu in students)
            {
                model.Students.Add(new StudentEnrollmentViewModel
                {
                    Id= stu.Id,
                    FirstName= stu.FirstName,
                    LastName = stu.LastName,
                    IsEnrolled= (@class?.Enrollments?.Any(p => p.StudentId == stu.Id)).GetValueOrDefault()
                });

            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<ActionResult> EnrollStudent(int classId, int studentId, bool shouldEnroll)
        {
            var enrollement = new Enrollment();
            if(shouldEnroll==true)
            {
                enrollement.ClassId = classId;
                enrollement.StudentId = studentId;
                await _context.AddAsync(enrollement);
            }
            else
            {
                enrollement = await _context.Enrollments.FirstOrDefaultAsync(
                    p => p.ClassId == classId && p.StudentId == studentId);
                if(enrollement != null)
                _context.Remove(enrollement);

            }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(ManageEnrollments), new{ id= classId});
        }

        private bool ClassExists(int id)
        {
          return (_context.Classes?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        private void CreateSelectLists(){
            var course = _context.Courses.Select(p => new {
            CourseName = $"{p.Code} - {p.Name} ({p.Credits} Credits)",
            p.Id,
            });
            ViewData["CourseId"] = new SelectList(course, "Id", "CourseName");
            var lecturers = _context.Lecturers.Select(p => new {
                FullName = $"{p.FirstName} {p.LastName}",
                p.Id,

            });
            ViewData["LecturerId"] = new SelectList(lecturers, "Id", "FullName");

        }
    }
    
}

