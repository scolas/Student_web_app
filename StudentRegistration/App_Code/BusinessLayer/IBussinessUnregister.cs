using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IBussinessUnregister
/// </summary>
public interface IBussinessUnregister

{
	
       DataTable getCourses1(int id);
        int unregisterCourse();
	
}