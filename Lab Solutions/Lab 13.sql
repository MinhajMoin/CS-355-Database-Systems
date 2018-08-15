

insert Student
select distinct [Student ID] , StudentName, Batch
from [Lab13]


insert Faculty(FacultyName)
select distinct FacultyName
from [Lab13]


insert Course(CourseName, Credit, CourseCode, FacultyID)
select distinct CourseName, Credit, CourseCode , FacultyID
from [Lab13], Faculty
where [Lab13].FacultyName = Faculty.FacultyName


insert Registration( CourseID, StudentID, Grade)
select  CourseID, [Student ID] , Grade
from [Lab13],  Course
where [Lab13].CourseName = Course.CourseName




