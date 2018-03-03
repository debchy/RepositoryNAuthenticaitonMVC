using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using RepositoryNAuthenticaiton.Models;
namespace RepositoryNAuthenticaiton.DAL
{
    public class UnitOfWork : IDisposable
    {
        private SchoolContext context = new SchoolContext();             
        

        private GenericRepository<Department> departmentRepository;
        public GenericRepository<Department> DepartmentRepository
        {
            get
            {
                return this.departmentRepository ?? new GenericRepository<Department>(context);
            }
        }


        private GenericRepository<Course> courseRepository;
        public GenericRepository<Course> CourseRepository
        {
            get
            {
                return this.courseRepository ?? new GenericRepository<Course>(context);
            }
        }


        private GenericRepository<Student> studentRepository;
        public GenericRepository<Student> StudentRepository {
            get
            {
                return this.studentRepository ?? new GenericRepository<Student>(context);
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}