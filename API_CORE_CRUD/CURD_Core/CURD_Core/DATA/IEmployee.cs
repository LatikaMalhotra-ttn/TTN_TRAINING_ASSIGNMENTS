using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using CURD_Core.Model;

namespace CURD_Core.DATA
{
    public  interface IEmployee
    {
        DataSet GetData();
        DataSet GetDataId(int id);
        bool InsertData(Employee employee);
        bool UpdateData(int id, Employee employee);
        bool DeleteData(int id);
    }
}
