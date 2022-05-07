using Microsoft.EntityFrameworkCore;

namespace UniversityEnrollment.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UniversityEnrollmentContext(
  serviceProvider.GetRequiredService<DbContextOptions<UniversityEnrollmentContext>>()))

            {
               
                if (context.Course.Any() || context.Student.Any() || context.Teacher.Any())
                {
                    return;
                }



                context.Student.AddRange(
                    new Student
                    { studentId = "100/2019", firstName = "Filip", lastName = "Filipov", enrollmentDate = DateTime.Parse("2019-9-20"), acquiredCredits = 150, currentSemester = 6, educationLevel = "Under graduate" },
                    new Student
                    { studentId = "101/2016", firstName = "Kiril", lastName = "Kirilov", enrollmentDate = DateTime.Parse("2016-9-23"), acquiredCredits = 300, currentSemester = 12, educationLevel = "PhD" },
                    new Student
                    { studentId = "102/2017", firstName = "Nikola", lastName = "Nikolov", enrollmentDate = DateTime.Parse("2017-9-21"), acquiredCredits = 250, currentSemester = 10, educationLevel = "Masters" },
                    new Student
                    { studentId = "103/2019", firstName = "Petar", lastName = "Petrov", enrollmentDate = DateTime.Parse("2019-9-2"), acquiredCredits = 160, currentSemester = 6, educationLevel = "Under graduate" },
                    new Student
                    { studentId = "104/2020", firstName = "Alen", lastName = "Alenov", enrollmentDate = DateTime.Parse("2020-9-30"), acquiredCredits = 100, currentSemester = 4, educationLevel = "Under graduate" },
                    new Student
                    { studentId = "105/2020", firstName = "Marija", lastName = "Marijova", enrollmentDate = DateTime.Parse("2020-9-20"), acquiredCredits = 120, currentSemester = 4, educationLevel = "Under graduate" }
                   

                     );
                context.Teacher.AddRange(
                    new Teacher
                    {
                        firstName = "Daniel",
                        lastName = "Danilov",
                        degree = "PhD",
                        academicRank = "Professor",
                        officeNumber = "220",
                        hireDate = DateTime.Parse("1990-7-10")
                    },
                    new Teacher
                    {
                        firstName = "Stole",
                        lastName = "Stoilov",
                        degree = "Masters",
                        academicRank = "Assistant",
                        officeNumber = "221",
                        hireDate = DateTime.Parse("2015-2-10")
                    },
                    new Teacher
                    {
                        firstName = "Mario",
                        lastName = "Markov",
                        degree = "Masters",
                        academicRank = "Professor",
                        officeNumber = "222",
                        hireDate = DateTime.Parse("2005-2-6")
                    },
                    new Teacher
                    {
                        firstName = "Dimitar",
                        lastName = "Dimitrov",
                        degree = "Bachelor",
                        academicRank = "Docent",
                        officeNumber = "223",
                        hireDate = DateTime.Parse("2018-12-4")
                    }
                );
                context.SaveChanges();

                context.Course.AddRange(
                   new Course
                   {
                       title = "Math 1",
                       credits = 8,
                       semester = 1,
                       programme = "All",
                       educationLevel = "Under graduate",
                       firstTeacherId = context.Teacher.Single(d => d.firstName == "Dimitar" && d.lastName == "Dimitrov").teacherId,
                       secondTeacherId = context.Teacher.Single(d => d.firstName == "Stole" && d.lastName == "Stoilov").teacherId,

                   },
                   new Course
                   {

                       title = "OWEB",
                       credits = 6,
                       semester = 5,
                       programme = "KTI",
                       educationLevel = "Under graduate",
                       firstTeacherId = context.Teacher.Single(d => d.firstName == "Stole" && d.lastName == "Stoilov").teacherId,
                       secondTeacherId = context.Teacher.Single(d => d.firstName == "Dimitar" && d.lastName == "Dimitrov").teacherId,

                   },
                   new Course
                   {

                       title = "RSWeb",
                       credits = 6,
                       semester = 6,
                       programme = "TKII&KTI",
                       educationLevel = "Under graduate",
                       firstTeacherId = context.Teacher.Single(d => d.firstName == "Mario" && d.lastName == "Markov").teacherId,
                       secondTeacherId = context.Teacher.Single(d => d.firstName == "Dimitar" && d.lastName == "Dimitrov").teacherId,

                   },
                   new Course
                   {

                       title = "Fizika2",
                       credits = 7,
                       semester = 2,
                       programme = "All",
                       educationLevel = "Masters",
                       firstTeacherId = context.Teacher.Single(d => d.firstName == "Dimitar" && d.lastName == "Dimitrov").teacherId,
                       secondTeacherId = context.Teacher.Single(d => d.firstName == "Mario" && d.lastName == "Markov").teacherId,

                   }
               );
                context.SaveChanges();

                context.Enrollment.AddRange(
                   new Enrollment
                   { courseId = context.Course.Single(d => d.title == "Fizika2").courseId, studentId = context.Student.Single(d => d.firstName == "Filip" && d.lastName == "Filipov").Id, semester = 2, year = 2020, grade = 10, seminalUrl = "ekursevi.feit.ukim.edu.mk/seminarski", projectUrl = "ekursevi.feit.ukim.edu.mk/proektni", examPoints = 90, seminalPoints = 10, projectPoints = 10, additionalPoints = 0, finishDate = DateTime.Parse("2021-6-20") },
                   new Enrollment
                   { courseId = context.Course.Single(d => d.title == "RSWeb").courseId, studentId = context.Student.Single(d => d.firstName == "Kiril" && d.lastName == "Kirilov").Id, semester = 6, year = 2019, grade = 8, seminalUrl = "ekursevi.feit.ukim.edu.mk/seminarski", projectUrl = "ekursevi.feit.ukim.edu.mk/proektni", examPoints = 70, seminalPoints = 0, projectPoints = 10, additionalPoints = 5, finishDate = DateTime.Parse("2020-9-20") },
                   new Enrollment
                   { courseId = context.Course.Single(d => d.title == "OWEB").courseId, studentId = context.Student.Single(d => d.firstName == "Nikola" && d.lastName == "Nikolov").Id, semester = 5, year = 2018, grade = 9, seminalUrl = "ekursevi.feit.ukim.edu.mk/seminarski", projectUrl = "ekursevi.feit.ukim.edu.mk/proektni", examPoints = 78, seminalPoints = 5, projectPoints = 10, additionalPoints = 5, finishDate = DateTime.Parse("2022-2-10") },
                   new Enrollment
                   { courseId = context.Course.Single(d => d.title == "Math 1").courseId, studentId = context.Student.Single(d => d.firstName == "Petar" && d.lastName == "Petrov").Id, semester = 1, year = 2022, grade = 10, seminalUrl = "ekursevi.feit.ukim.edu.mk/seminarski", projectUrl = "ekursevi.feit.ukim.edu.mk/proektni", examPoints = 90, seminalPoints = 10, projectPoints = 5, additionalPoints = 10, finishDate = DateTime.Parse("2022-2-10") },
                   new Enrollment
                   { courseId = context.Course.Single(d => d.title == "Fizika2").courseId, studentId = context.Student.Single(d => d.firstName == "Marija" && d.lastName == "Marijova").Id, semester = 2, year = 2021, grade = 6, seminalUrl = "ekursevi.feit.ukim.edu.mk/seminarski", projectUrl = "ekursevi.feit.ukim.edu.mk/proektni", examPoints = 55, seminalPoints = 0, projectPoints = 5, additionalPoints = 0, finishDate = DateTime.Parse("2021-2-7") }
                   );

                context.SaveChanges();



            }
        }
    }
}
