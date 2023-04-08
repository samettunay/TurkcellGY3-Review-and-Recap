using ConsoleUI.Models;

namespace ConsoleUI.Businnes.Abstract
{
    public interface ITeacherService : IService<Teacher>
    {
        void AddHomeworkToStudent(int studentId, int homeworkId);
        void AddHomeworkToAllStudentsInClassroom(int classId, int homeworkId);
        List<Homework> GetHomeworksSelectedStudent(Student student);
    }
}
