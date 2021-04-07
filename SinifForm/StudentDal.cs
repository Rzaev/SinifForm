using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifForm
{
    public class StudentDal
    {
        public List<Student> GetStudents()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Students.ToList();

            }
        }

        public List<Student> GetStudentByName(string s)
        {
            using (ETradeContext context = new ETradeContext())
            {

                var blogs = from b in context.Students
                            where b.Name.Contains(s)
                            select b;
                return blogs.ToList();
                //var matchingvalues = context
                //// Where(stringToCheck => stringToCheck.Contains(myString));

            }
        }

        public void Add(Student student)
        {
            using (ETradeContext context = new ETradeContext())
            {
                // context.Students.Add(student);
                var entity = context.Entry(student);
                entity.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Student student)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(student);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Student student)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(student);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
