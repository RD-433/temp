

if OBJECT_ID ('Teacher', 'u') is not null
drop table Teacher
go
create table Teacher
(
id int identity,
name nvarchar(30),
surname nvarchar(30),
gender nvarchar(20),
subject nvarchar(30),

constraint pk_teacher_id primary key (id)
)
go

if OBJECT_ID ('Pupil', 'u') is not null
drop table Pupil
go
create table Pupil
(
id int identity,
name nvarchar(30),
surname nvarchar(30),
gender nvarchar(20),
class nvarchar(30),

constraint pk_pupil_id primary key (id)
)
go

if OBJECT_ID ('TeacherPupil', 'u') is not null
drop table TeacherPupil
go
create table TeacherPupil
(
teacher_id int,
pupil_id int,

constraint fk_teacher_id foreign key (teacher_id) references Teacher(id),
constraint fk_pupil_id foreign key (pupil_id) references Pupil(id),
constraint uq_teacher_pupil unique(teacher_id, pupil_id)
)
go


insert into Teacher(name, surname, gender, subject) values (N'ანა', N'დ', N'მდედრობითი', N'მათემატიკა')
insert into Teacher(name, surname, gender, subject) values (N'ელენე', N'დ', N'მდედრობითი', N'გეოგრაფია')
insert into Teacher(name, surname, gender, subject) values (N'ვახტანგ', N'დ', N'მამრობითი', N'ბიოლოგია')
insert into Teacher(name, surname, gender, subject) values (N'სალომე', N'დ', N'მდედრობითი', N'ისტორია')
insert into Teacher(name, surname, gender, subject) values (N'გიორგი', N'დ', N'მამრობითი', N'ქიმია')
insert into Teacher(name, surname, gender, subject) values (N'არჩილ', N'დ', N'მამრობითი', N'ფიზიკა')

insert into Pupil(name, surname, gender, class) values (N'გიორგი', N'ბ', N'მამრობითი', N'11ა')
insert into Pupil(name, surname, gender, class) values (N'ილია', N'ბ', N'მამრობითი', N'10ა')
insert into Pupil(name, surname, gender, class) values (N'თამარ', N'ბ', N'მდედრობითი', N'12ბ')
insert into Pupil(name, surname, gender, class) values (N'დავით', N'ბ', N'მამრობითი', N'11ა')
insert into Pupil(name, surname, gender, class) values (N'ეკა', N'ბ', N'მდედრობითი', N'11ბ')
insert into Pupil(name, surname, gender, class) values (N'მარიამ', N'ბ', N'მდედრობითი', N'12ა')
insert into Pupil(name, surname, gender, class) values (N'ხატია', N'ბ', N'მდედრობითი', N'10ბ')

insert into TeacherPupil(teacher_id, pupil_id) values (1, 1)
insert into TeacherPupil(teacher_id, pupil_id) values (1, 3)
insert into TeacherPupil(teacher_id, pupil_id) values (1, 4)
insert into TeacherPupil(teacher_id, pupil_id) values (1, 6)
insert into TeacherPupil(teacher_id, pupil_id) values (1, 2)
insert into TeacherPupil(teacher_id, pupil_id) values (2, 2)
insert into TeacherPupil(teacher_id, pupil_id) values (2, 3)
insert into TeacherPupil(teacher_id, pupil_id) values (2, 4)
insert into TeacherPupil(teacher_id, pupil_id) values (2, 5)
insert into TeacherPupil(teacher_id, pupil_id) values (3, 1)
insert into TeacherPupil(teacher_id, pupil_id) values (3, 6)
insert into TeacherPupil(teacher_id, pupil_id) values (4, 2)
insert into TeacherPupil(teacher_id, pupil_id) values (4, 3)
insert into TeacherPupil(teacher_id, pupil_id) values (4, 4)
insert into TeacherPupil(teacher_id, pupil_id) values (5, 1)
insert into TeacherPupil(teacher_id, pupil_id) values (5, 2)
insert into TeacherPupil(teacher_id, pupil_id) values (5, 4)
insert into TeacherPupil(teacher_id, pupil_id) values (6, 1)
insert into TeacherPupil(teacher_id, pupil_id) values (6, 3)
insert into TeacherPupil(teacher_id, pupil_id) values (6, 5)
insert into TeacherPupil(teacher_id, pupil_id) values (6, 6)
go


if OBJECT_ID ('GetTeachers', 'p') is not null
drop procedure GetTeachers
go
create procedure GetTeachers
@name nvarchar(30)
as
begin
select t.id, t.name, t.surname, t.gender, t.subject from 
Pupil inner join TeacherPupil on Pupil.id = TeacherPupil.pupil_id
inner join Teacher as t on t.id = TeacherPupil.teacher_id
where Pupil.name = @name
end
go

declare @name nvarchar(30)
set @name = N'გიორგი'
exec GetTeachers @name





