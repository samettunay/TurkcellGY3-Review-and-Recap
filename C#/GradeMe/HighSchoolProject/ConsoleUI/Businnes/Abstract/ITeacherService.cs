using ConsoleUI.Models;

namespace ConsoleUI.Businnes.Abstract
{
    public interface ITeacherService : IService<Teacher>
    {
        void AddHomeworkToStudent(Guid studentId, Guid homeworkId);
        void AddHomeworkToAllStudentsInClassroom(Guid classId, Guid homeworkId);
        List<Homework> GetHomeworksSelectedStudent(Student student);
    }
}
