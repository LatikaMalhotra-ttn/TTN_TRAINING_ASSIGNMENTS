<Query Kind="Statements">
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

//Ques3: Write LINQ to get the top two records from the table and perform sorting in descending order.

var result=from all_ele in Tbl_students
           select all_ele;
result.Dump();

var Show_top_2_record= Tbl_students.Take(5).AsEnumerable();
Show_top_2_record.Dump();

var sorted_elements=Show_top_2_record.OrderBy(x=>x.Marks);

sorted_elements.Dump();