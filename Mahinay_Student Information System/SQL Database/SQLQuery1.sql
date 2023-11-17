create database db_student

use db_student 

create table info( 
id int identity(1,1) primary key clustered,
stud_no as 'Stud_no' + Right('00000'+ CAST(id as varchar(5)),5) persisted, 
fname varchar (50), 
lname varchar (50),
bday Date,
s_address varchar (50),
phone varchar (50),
email varchar (50)
)

create procedure sp_save 
@fname varchar(50), 
@lname varchar(50),
@bday Date,
@s_address varchar(50),
@phone varchar (50),
@email varchar(50)
as 
insert into info values (@fname,@lname,@bday,@s_address,@phone, @email) 

create procedure sp_update 
@id int, 
@fname varchar(50),
@lname varchar(50),
@bday Date,
@s_address varchar(50),
@phone varchar (50),
@email varchar(50)
as 
update info 
set fname = @fname, lname = @lname, bday = @bday, s_address = @s_address, phone = @phone, email = @email
where id=@id

create procedure sp_delete 
@id int 
as 
delete info 
where id=@id 

create procedure sp_view 
as 
select 
id as 'ID', 
stud_no as 'STUD_NO', 
fname as 'FIRST NAME', 
lname as 'LAST NAME', 
bday as 'BIRTH DATE', 
DATEDIFF(YY,bday,GETDATE()) as 'AGE', 
s_address as 'ADDRESS', 
phone as 'PHONE', 
email as 'EMAIL'
from info 

create procedure sp_search 
@key varchar(max) 
as 
select 
id as 'ID', 
stud_no as 'STUD_NO', 
fname as 'FIRST NAME', 
lname as 'LAST NAME', 
bday as 'BIRTH DATE', 
DATEDIFF(YY,bday,GETDATE()) as 'AGE', 
s_address as 'ADDRESS', 
phone as 'PHONE', 
email as 'EMAIL'
from info  
where 
stud_no like '%' +@key+'%' 
or fname like '%' +@key+'%' 
or lname like '%' +@key+'%' 
or bday like '%' +@key+'%' 
or s_address like '%' +@key+'%' 
or phone like '%' +@key+'%' 
or email like '%' +@key+'%' 