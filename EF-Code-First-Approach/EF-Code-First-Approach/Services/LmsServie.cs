using EF_Code_First_Approach.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Code_First_Approach.Services
{
    public  class LmsServie
    {
        private LMSContext lmsDbContext;

        #region "Reading Data"
        public LmsServie(LMSContext ldbContext)
        {
            lmsDbContext = ldbContext;
        }

        // Loading Related Entities
        // Eagerly Loading: Load all the releated Items in advance
        // Reading all data
        public IEnumerable<Category> GetAllCategories()
        {
            return lmsDbContext.Catagories;
        }

        // Eagerly loading multiple levels
        public IEnumerable<Category> GetAllCategoriesWithCourses()
        {
            return lmsDbContext.Catagories.Include(c => c.Courses);
        }

        public IOrderedQueryable<Exam> GetGradesOfCourse(int courseId)
        {
            IOrderedQueryable<Exam> examsorderedByGrade = from e in lmsDbContext.Exams where e.Course.id == courseId orderby e.Grade ascending select e ;
            return examsorderedByGrade;
        }

        public IOrderedQueryable<Exam> GetGradesOfStudent(int student)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Exam> GetAllExams()
        {
            throw new NotImplementedException();
        }

        // Reading a single entity
        public Student GetStudentById(int id)
        {
            return lmsDbContext.Students.Where(s => s.Id == id).FirstOrDefault();
        }

        // Filtering the data
        public List<Student> GetStudentByAddress(string city)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentByCountry(string country)
        {
            throw new NotImplementedException();
        }

        public int GetNumOfStudentsPerAddress(string city)
        {
            return lmsDbContext.Students.Where(s => s.Address == city).Count();
        }

        public List<(string,int)> GetNumOfStudentsinEachCity()
        {
            var listResult = new List<(string, int)>();
            var result = from s in lmsDbContext.Students group s by s.Address;
            foreach (var s in result)
            {
                listResult.Add(new (s.Key, s.Count()));
            }
            return listResult;
        }

        #endregion

        #region "Updating and Deleteing Data"
        public void DeleteStudentById(int id)
        {
            var student = lmsDbContext.Students.Find(id);
            if (student is not null)
            {
                lmsDbContext.Students.Remove(student);
                lmsDbContext.SaveChanges();
            }
        }

        public void AddStudent(Student student)
        {
            lmsDbContext.Students.Add(student);
            lmsDbContext.SaveChanges();
        }

        // Save the Entity graph
        public void AddCategory(Category category)
        {
            lmsDbContext.Catagories.Add(category);
            lmsDbContext.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            var category = lmsDbContext.Catagories.Where(c=> c.Id == categoryId).Include(c=>c.Courses).FirstOrDefault();

            if (category is not null)
            { 
                foreach (var c in category.Courses)
                {
                    lmsDbContext.Remove(c);
                }
                lmsDbContext.Catagories.Remove(category);
                lmsDbContext.SaveChanges();
            }
        }
        #endregion

    }
}
