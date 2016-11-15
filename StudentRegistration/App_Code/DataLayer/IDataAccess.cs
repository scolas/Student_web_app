using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

public interface IDataAccess
{
    object GetSingleAnswer(string sql);
    DataTable GetManyRowCols(string sql);
    int InsertUpdateDelete(string sql);
}
