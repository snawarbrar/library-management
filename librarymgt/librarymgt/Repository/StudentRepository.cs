using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using librarymgt.Models;

namespace librarymgt.Repository
{
    class StudentRepository : IStudent
    {
        private readonly identityModel context;
        public StudentRepository(identityModel _context)
        {
            context = _context; 
        }
        public void AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public List<BookBorrowed> booksBorrowedByStudent(int stuId)
        {
            var abc = (from bookIssues in context.BookIssueds
                      join student in context.Students
                      on bookIssues.StudentId equals student.StudentId
                      join book in context.Books
                      on bookIssues.BookId equals book.BookId
                      where bookIssues.StudentId == stuId
                      select new BookBorrowed
                      {
                          StudentName = student.StuName,
                          BookName = book.BookName,
                          issuedate = bookIssues.issueDate,
                          ReturnDate = bookIssues.ReturnDate,
                          StudentId = bookIssues.StudentId,
                          BookId = bookIssues.BookId

                      }).OrderBy(b=>b.ReturnDate).ToList();
           
           
            return abc ;
        }

        public bool DeleteStudent(int id)
        {
            var count = context.BookIssueds.Count(issue => issue.student.StudentId==id);
            if (count > 0)
            {
                return false;     
            }
            else
            {
                var data = context.Students.FirstOrDefault(stu => stu.StudentId == id);
                context.Students.Remove(data);
                context.SaveChanges();
                return true;
            }
            }

        public List<Student> GetAllStudents()
        {
           return context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            return context.Students.Where(stu => stu.StudentId == id).FirstOrDefault();
        }

        public BookBorrowed GetReturnBook(int StuId, int BookId)
        {
            var result = (from student in context.Students
                          join issuebook in context.BookIssueds
                          on student.StudentId equals issuebook.StudentId
                          join book in context.Books
                          on issuebook.BookId equals book.BookId
                          where issuebook.BookId == BookId && issuebook.StudentId == StuId
                          select new BookBorrowed
                          {
                              BookId = issuebook.BookId,
                              StudentId = issuebook.StudentId,
                              BookName = book.BookName,
                              StudentName = student.StuName,
                              issuedate = issuebook.issueDate,
                              ReturnDate = DateTime.Now

                          }
                        ).FirstOrDefault();
            return result;
        }

        public bool UpdateStudent(Student student)
        {
            var data = context.Students.FirstOrDefault(stu => stu.StudentId == student.StudentId);
           data.StuName= student.StuName;
            data.StuEmail = student.StuEmail;
            data.Course = student.Course;
            data.RollNumber = student.RollNumber;
            context.SaveChanges();
            return true;
        }

        public bool ReturnBook(BookBorrowed bookBorrowed)
        {
            var data = context.BookIssueds
                 .Where(book => book.BookId == bookBorrowed.BookId)
                 .Where(book => book.StudentId == bookBorrowed.StudentId)
                 .FirstOrDefault();

            data.StudentId = bookBorrowed.StudentId;
            data.BookId = bookBorrowed.BookId;
            data.issueDate = bookBorrowed.issuedate;
            data.ReturnDate = bookBorrowed.ReturnDate;
            context.SaveChanges();
            return true;

        }

        public bool GetBookBorrowedBYStudentId(int id)
        {
            throw new NotImplementedException();
        }

        public int GetBookBorrowedByStudentRollNO(string rollno)
        {
            var result=context.Students.FirstOrDefault(x => x.RollNumber == rollno);
            return result.StudentId;
        }
    }
}
