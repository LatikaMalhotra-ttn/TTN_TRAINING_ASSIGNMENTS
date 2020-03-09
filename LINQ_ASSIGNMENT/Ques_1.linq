<Query Kind="Expression">
  <Connection>
    <ID>7faa1b17-5765-4597-b55e-10e2596f7fb8</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <SqlSecurity>true</SqlSecurity>
    <UserName>SA</UserName>
    <Password>AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAAPVnKI6uavkGh419phCuCdwAAAAACAAAAAAAQZgAAAAEAACAAAAAit7ANKNHyQ9BW5rF65PcVlVbySJxK4oJpuUGZ6eNWQwAAAAAOgAAAAAIAACAAAABVdSXENcGXBRxfI8V6K8ulKiq/IG2tYVFe6H0FyhbrVBAAAAC1Ba398LvNoi1Gbr3PAp7JQAAAAIS+02KyWw5H8idFNeukggxVkbFxascN4N+MqnXmjMAw9uPPUi4/J6UfuEJdgb2ssCKb8tPVXA4H3th2mD+dYk8=</Password>
    <Database>LINQ_Assignment</Database>
  </Connection>
</Query>

//Ques1: Write LINQ syntax and define each term of the syntax.

//there are three ways in which linq syntax can be defined
//1. Query syntax
from student in Tbl_students
where student.Roll_no==2
select student

//2.Method syntax
Tbl_students.Where(x=>x.Roll_no==2).ToList()


//3. Mixed syntax

(from student in Tbl_students
select student).Skip(2)
