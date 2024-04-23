using Academix.Infrastructure.Data.Models;
using Academix.Infrastructure.Data.Models.Enumerations;
using Academix.Infrastructure.Data.Models.Mapping;
using Microsoft.AspNetCore.Identity;

namespace Academix.Infrastructure.Data.Configurations
{
    public static class DataSeed
    {
        public static Absence[] SeedAbsences()
        {
            return new Absence[]
            {
                new Absence()
                {
                    Id = 1,
                    DateAndTime = DateTime.Now,
                    ExcusedAbsence = false,
                    SubjectId = 1,
                    StudentId = 1
                },
                new Absence()
                {
                    Id = 2,
                    DateAndTime = DateTime.Now.AddDays(1),
                    ExcusedAbsence = false,
                    SubjectId = 1,
                    StudentId = 1
                },
                new Absence()
                {
                    Id = 3,
                    DateAndTime = DateTime.Now.AddDays(2),
                    ExcusedAbsence = true,
                    SubjectId = 2,
                    StudentId = 1
                }
            };
        }

        public static ApplicationUser[] SeedApplicationUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            var director = new ApplicationUser()
            {
                Id = "a3717562-385e-41ce-9eff-0f1b994e5548",
                UserName = "i.ivanov@mail.com",
                NormalizedUserName = "I.IVANOV@MAIL.COM",
                Email = "i.ivanov@mail.com",
                NormalizedEmail = "I.IVANOV@MAIL.COM",
                FirstName = "Ivan",
                LastName = "Ivanov"
            };
            director.PasswordHash = hasher.HashPassword(director, "123456");

            var student = new ApplicationUser()
            {
                Id = "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                UserName = "m.marinov@mail.com",
                NormalizedUserName = "M.MARINOV@MAIL.COM",
                Email = "m.marinov@mail.com",
                NormalizedEmail = "M.MARINOV@MAIL.COM",
                FirstName = "Mitko",
                LastName = "Marinov"
            };
            student.PasswordHash = hasher.HashPassword(student, "123456");

            var student2 = new ApplicationUser()
            {
                Id = "a171483f-6e48-446a-a5d7-36110d0c1443",
                UserName = "d.kirilov@mail.com",
                NormalizedUserName = "D.KIRILOV@MAIL.COM",
                Email = "d.kirilov@mail.com",
                NormalizedEmail = "D.KIRILOV@MAIL.COM",
                FirstName = "Drago",
                LastName = "Kirilov"
            };
            student2.PasswordHash = hasher.HashPassword(student2, "123456");

            var student3 = new ApplicationUser()
            {
                Id = "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                UserName = "m.kirilova@mail.com",
                NormalizedUserName = "M.KIRILOVA@MAIL.COM",
                Email = "m.kirilova@mail.com",
                NormalizedEmail = "M.KIRILOVA@MAIL.COM",
                FirstName = "Marta",
                LastName = "Kirilova"
            };
            student3.PasswordHash = hasher.HashPassword(student3, "123456");

            var parent = new ApplicationUser()
            {
                Id = "925da918-5cd0-4b17-9b62-2f417aac0343",
                UserName = "v.marinov@mail.com",
                NormalizedUserName = "V.MARINOV@MAIL.COM",
                Email = "v.marinov@mail.com",
                NormalizedEmail = "V.MARINOV@MAIL.COM",
                FirstName = "Vasil",
                LastName = "Marinov"
            };
            parent.PasswordHash = hasher.HashPassword(parent, "123456");

            var parent2 = new ApplicationUser()
            {
                Id = "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                UserName = "v.kirilova@mail.com",
                NormalizedUserName = "V.KIRILOVA@MAIL.COM",
                Email = "v.kirilova@mail.com",
                NormalizedEmail = "V.KIRILOVA@MAIL.COM",
                FirstName = "Vanya",
                LastName = "Kirilova"
            };
            parent2.PasswordHash = hasher.HashPassword(parent2, "123456");

            var teacher = new ApplicationUser()
            {
                Id = "5093413e-4acb-471a-9ce7-53df30689fc1",
                UserName = "n.zakova@mail.com",
                NormalizedUserName = "N.ZAKOVA@MAIL.COM",
                Email = "n.zakova@mail.com",
                NormalizedEmail = "N.ZAKOVA@MAIL.COM",
                FirstName = "Nikoleta",
                LastName = "Zakova"
            };
            teacher.PasswordHash = hasher.HashPassword(teacher, "123456");

            var teacher2 = new ApplicationUser()
            {
                Id = "6c1ff15b-1853-4d20-98ff-9695affb432c",
                UserName = "d.milev@mail.com",
                NormalizedUserName = "D.MILEV@MAIL.COM",
                Email = "d.milev@mail.com",
                NormalizedEmail = "D.MILEV@MAIL.COM",
                FirstName = "Dragan",
                LastName = "Milev"
            };
            teacher2.PasswordHash = hasher.HashPassword(teacher2, "123456");

            var teacher3 = new ApplicationUser()
            {
                Id = "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                UserName = "z.draganova@mail.com",
                NormalizedUserName = "Z.DRAGANOVA@MAIL.COM",
                Email = "z.draganova@mail.com",
                NormalizedEmail = "Z.DRAGANOVA@MAIL.COM",
                FirstName = "Zara",
                LastName = "Draganova"
            };
            teacher3.PasswordHash = hasher.HashPassword(teacher3, "123456");

            var admin = new ApplicationUser()
            {
                Id = "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                UserName = "admin@mail.com",
                NormalizedUserName = "ADMIN@MAIL.COM",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                FirstName = "admin",
                LastName = "Admin"
            };
            admin.PasswordHash = hasher.HashPassword(admin, "123456");

            var admin2 = new ApplicationUser()
            {
                Id = "214ce248-b8b3-4832-8c3b-7f133e7a429e",
                UserName = "admin2@mail.com",
                NormalizedUserName = "ADMIN2@MAIL.COM",
                Email = "admin2@mail.com",
                NormalizedEmail = "ADMIN2@MAIL.COM",
                FirstName = "admin2",
                LastName = "Admin2"
            };
            admin2.PasswordHash = hasher.HashPassword(admin2, "123456");

            return new ApplicationUser[] { director, student, student2, student3, parent, parent2, teacher, teacher2, teacher3, admin, admin2 };
        }

        public static City[] SeedCities()
        {
            return new City[]
            {
                new City
                {
                    Id = 1,
                    Name = "Sofia"
                },
                new City
                {
                    Id = 2,
                    Name = "Varna"
                },
                new City
                {
                    Id = 3,
                    Name = "Burgas"
                }
            };
        }

        public static Class[] SeedClasses()
        {
            return new Class[]
            {
                new Class()
                {
                    Id = 1,
                    Name = "12A",
                    SchoolId = 1,
                    ClassTeacherId = 1
                },
                new Class()
                {
                    Id = 2,
                    Name = "8B",
                    SchoolId = 1,
                    ClassTeacherId = 2
                }
            };
        }

        public static Grade[] SeedGrades()
        {
            return new Grade[]
            {
                new Grade()
                {
                    Id = 1,
                    GradeNumber = 4,
                    DateAndTime = DateTime.Now,
                    GradeType = GradeTypes.Exam,
                    SubjectId = 1,
                    StudentId = 1
                },
                new Grade()
                {
                    Id = 2,
                    GradeNumber = 6,
                    DateAndTime = DateTime.Now.AddDays(12),
                    GradeType = GradeTypes.Exam,
                    SubjectId = 1,
                    StudentId = 1
                },
                new Grade()
                {
                    Id = 3,
                    GradeNumber = 6,
                    DateAndTime = DateTime.Now.AddDays(11),
                    GradeType = GradeTypes.Project,
                    SubjectId = 2,
                    StudentId = 1
                },
                new Grade()
                {
                    Id = 4,
                    GradeNumber = 2,
                    DateAndTime = DateTime.Now.AddDays(7),
                    GradeType = GradeTypes.Exam,
                    SubjectId = 3,
                    StudentId = 1
                }
            };
        }

        public static School[] SeedSchools()
        {
            return new School[]
            {
                new School()
                {
                    Id = 1,
                    Name = "Vasil Levski",
                    CityId = 1,
                    DirectorId = "a3717562-385e-41ce-9eff-0f1b994e5548"
                },
                new School()
                {
                    Id = 2,
                    Name = "137 Georgi Asparuhov",
                    CityId = 1
                }
            };
        }

        public static Student[] SeedStudents()
        {
            return new Student[]
            {
                new Student()
                {
                    Id = 1,
                    Address = "Vasil Aprilov 5",
                    StudentIdentityId = "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                    ClassId = 1
                },
                new Student()
                {
                    Id = 2,
                    Address = "Krali Marko 12",
                    StudentIdentityId = "a171483f-6e48-446a-a5d7-36110d0c1443",
                    ClassId = 1
                },
                new Student()
                {
                    Id = 3,
                    Address = "Kalimanci 13",
                    StudentIdentityId = "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                    ClassId = 2
                }
            };
        }

        public static Subject[] SeedSubjects()
        {
            return new Subject[]
            {
                new Subject()
                {
                    Id = 1,
                    Name = "Mathematics",
                    TeacherId = 1,
                    SchoolId = 1
                },
                new Subject()
                {
                    Id = 2,
                    Name = "Physics",
                    TeacherId = 2,
                    SchoolId = 1
                },
                new Subject()
                {
                    Id = 3,
                    Name = "History",
                    TeacherId = 3,
                    SchoolId = 1
                }
            };
        }

        public static SubjectStudent[] SeedSubjectStudent()
        {
            return new SubjectStudent[]
            {
                new SubjectStudent()
                {
                    SubjectId = 1,
                    StudentId = 1
                },
                new SubjectStudent()
                {
                    SubjectId = 2,
                    StudentId = 1
                },
                new SubjectStudent()
                {
                    SubjectId = 3,
                    StudentId = 1
                }
            };
        }

        public static StudentParent[] SeedStudentParent()
        {
            return new StudentParent[] 
            {
                new StudentParent()
                {
                    StudentId = 1,
                    ParentId = "925da918-5cd0-4b17-9b62-2f417aac0343"
                },
                new StudentParent()
                {
                    StudentId = 2,
                    ParentId = "24a0fdf5-ca4f-4c0f-8120-f6c87448033c"
                },
                new StudentParent()
                {
                    StudentId = 3,
                    ParentId = "24a0fdf5-ca4f-4c0f-8120-f6c87448033c"
                }
            };
        }

        public static Teacher[] SeedTeacher()
        {
            return new Teacher[]
            {
                new Teacher()
                {
                    Id = 1,
                    TeacherIdentityId = "5093413e-4acb-471a-9ce7-53df30689fc1",
                    SchoolId = 1
                },
                new Teacher()
                {
                    Id = 2,
                    TeacherIdentityId = "6c1ff15b-1853-4d20-98ff-9695affb432c",
                    SchoolId = 1
                },
                new Teacher()
                {
                    Id = 3,
                    TeacherIdentityId = "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                    SchoolId = 1
                }
            };
        }

        public static IdentityRole[] SeedRoles()
        {
            return new IdentityRole[]
            {
                new IdentityRole
                {
                    Id = "a550b411-e5c7-407f-aaba-35161bab127e",
                    Name = "Director",
                    NormalizedName = "DIRECTOR"
                },
                new IdentityRole
                {
                    Id = "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b",
                    Name = "Teacher",
                    NormalizedName = "TEACHER"
                },
                new IdentityRole
                {
                    Id = "e67d14b1-de35-47bd-96ac-a70fcc4c25be",
                    Name = "Student",
                    NormalizedName = "STUDENT"
                },
                new IdentityRole
                {
                    Id = "fc1ee3a5-9b29-43ea-b038-2265c1806a75",
                    Name = "Parent",
                    NormalizedName = "PARENT"
                },
                new IdentityRole
                {
                    Id = "7f92327f-b1c1-4fd0-b837-afc278f256b2",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                }
            };
        }

        public static IdentityUserRole<string>[] SeedUserRoles()
        {
            return new IdentityUserRole<string>[]
            {
                new IdentityUserRole<string>
                {
                    UserId = "a3717562-385e-41ce-9eff-0f1b994e5548",
                    RoleId = "a550b411-e5c7-407f-aaba-35161bab127e"
                },
                new IdentityUserRole<string>
                {
                    UserId = "5093413e-4acb-471a-9ce7-53df30689fc1",
                    RoleId = "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b"
                },
                new IdentityUserRole<string>
                {
                    UserId = "6c1ff15b-1853-4d20-98ff-9695affb432c",
                    RoleId = "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b"
                },
                new IdentityUserRole<string>
                {
                    UserId = "bd3e68c0-728b-44a0-ba3a-992d8ae683f9",
                    RoleId = "f67cd347-818b-4c3e-a1ce-ae76e1a2e31b"
                },
                new IdentityUserRole<string>
                {
                    UserId = "1ae342a8-9fab-4c0a-bd5a-70b351717ecc",
                    RoleId = "e67d14b1-de35-47bd-96ac-a70fcc4c25be"
                },
                new IdentityUserRole<string>
                {
                    UserId = "a171483f-6e48-446a-a5d7-36110d0c1443",
                    RoleId = "e67d14b1-de35-47bd-96ac-a70fcc4c25be"
                },
                new IdentityUserRole<string>
                {
                    UserId = "b2502a25-8341-4e5c-af74-cd0f889ede1b",
                    RoleId = "e67d14b1-de35-47bd-96ac-a70fcc4c25be"
                },
                new IdentityUserRole<string>
                {
                    UserId = "925da918-5cd0-4b17-9b62-2f417aac0343",
                    RoleId = "fc1ee3a5-9b29-43ea-b038-2265c1806a75"
                },
                new IdentityUserRole<string>
                {
                    UserId = "24a0fdf5-ca4f-4c0f-8120-f6c87448033c",
                    RoleId = "fc1ee3a5-9b29-43ea-b038-2265c1806a75"
                },
                new IdentityUserRole<string>
                {
                    UserId = "11f2b8bd-a49a-42cd-b08b-ce067e430965",
                    RoleId = "7f92327f-b1c1-4fd0-b837-afc278f256b2"
                },
                new IdentityUserRole<string>
                {
                    UserId = "214ce248-b8b3-4832-8c3b-7f133e7a429e",
                    RoleId = "7f92327f-b1c1-4fd0-b837-afc278f256b2"
                }
            };
        }

        public static IdentityUserClaim<string>[] SeedUserClaims()
        {
            var director = new IdentityUserClaim<string>()
            {
                Id = 1,
                ClaimType = "FullName",
                ClaimValue = "Ivan Ivanov",
                UserId = "a3717562-385e-41ce-9eff-0f1b994e5548"
            };

            var student = new IdentityUserClaim<string>()
            {
                Id = 2,
                ClaimType = "FullName",
                ClaimValue = "Mitko Marinov",
                UserId = "1ae342a8-9fab-4c0a-bd5a-70b351717ecc"
            };

            var student2 = new IdentityUserClaim<string>()
            {
                Id = 3,
                ClaimType = "FullName",
                ClaimValue = "Drago Kirilov",
                UserId = "a171483f-6e48-446a-a5d7-36110d0c1443"
            };

            var student3 = new IdentityUserClaim<string>()
            {
                Id = 4,
                ClaimType = "FullName",
                ClaimValue = "Marta Kirilova",
                UserId = "b2502a25-8341-4e5c-af74-cd0f889ede1b"
            };

            var parent = new IdentityUserClaim<string>()
            {
                Id = 5,
                ClaimType = "FullName",
                ClaimValue = "Vasil Marinov",
                UserId = "925da918-5cd0-4b17-9b62-2f417aac0343"
            };

            var parent2 = new IdentityUserClaim<string>()
            {
                Id = 6,
                ClaimType = "FullName",
                ClaimValue = "Vanya Kirilova",
                UserId = "24a0fdf5-ca4f-4c0f-8120-f6c87448033c"
            };

            var teacher = new IdentityUserClaim<string>()
            {
                Id = 7,
                ClaimType = "FullName",
                ClaimValue = "Nikoleta Zakova",
                UserId = "5093413e-4acb-471a-9ce7-53df30689fc1"
            };

            var teacher2 = new IdentityUserClaim<string>()
            {
                Id = 8,
                ClaimType = "FullName",
                ClaimValue = "Dragan Milev",
                UserId = "6c1ff15b-1853-4d20-98ff-9695affb432c"
            };

            var teacher3 = new IdentityUserClaim<string>()
            {
                Id = 9,
                ClaimType = "FullName",
                ClaimValue = "Zara Draganova",
                UserId = "bd3e68c0-728b-44a0-ba3a-992d8ae683f9"
            };

            var admin = new IdentityUserClaim<string>()
            {
                Id = 10,
                ClaimType = "FullName",
                ClaimValue = "admin Admin",
                UserId = "11f2b8bd-a49a-42cd-b08b-ce067e430965"
            };

            var admin2 = new IdentityUserClaim<string>()
            {
                Id = 11,
                ClaimType = "FullName",
                ClaimValue = "admin2 Admin2",
                UserId = "214ce248-b8b3-4832-8c3b-7f133e7a429e"
            };

            return new IdentityUserClaim<string>[] { director, student, student2, student3, parent, parent2, teacher, teacher2, teacher3, admin, admin2 };
        }
    }
}
