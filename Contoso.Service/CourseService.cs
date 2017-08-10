using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model;
using Contoso.Service;
using Contoso.Data;

namespace Contoso.Service
{
    public class CourseService
    {
        public List<Courses> GetAllCourses()
        {
            CourseRepository repository = new CourseRepository();
            var courses = repository.GetAll();
            return courses;

        }
        public void SaveCourse(Courses course)
        {
            CourseRepository repository = new CourseRepository();
            repository.Create(course);
        }
    }
}
