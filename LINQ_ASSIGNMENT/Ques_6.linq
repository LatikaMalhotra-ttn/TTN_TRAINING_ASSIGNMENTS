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

//Ques6: Write LINQ to perform aggregate function Count, Max, Min, Average on the table

//Aggrigate function: count
//
(from student1 in Tbl_students
select student1.Name).Count()

//Tbl_students.Count(student=>student.Name)

//Aggrigate function: Max
(from student in Tbl_students
select student.Marks).Max()

//------second way
Tbl_students.Max(student=>student.Marks)


//Aggrigate function: Min
(from student in Tbl_students
select student.Marks).Min()

//----------------second way
Tbl_students.Min(student=>student.Marks)

//Aggrigate function: Average
(from student in Tbl_students
select student.Marks).Average()

//-------------second way
Tbl_students.Average(student=>student.Marks)