using librarymgt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace librarymgt.Repository
{
  public  interface IStudent
    {
        void AddStudent(Student student);

        List<Student> GetAllStudents();

        Student GetStudentById(int id);

        bool UpdateStudent(Student student);

        bool DeleteStudent(int id);
        List<BookBorrowed> booksBorrowedByStudent(int stuId);

        BookBorrowed GetReturnBook(int StuId, int BookId);

        bool ReturnBook(BookBorrowed bookBorrowed);

        bool GetBookBorrowedBYStudentId(int id);
        int GetBookBorrowedByStudentRollNO(string rollno);

    }
}
