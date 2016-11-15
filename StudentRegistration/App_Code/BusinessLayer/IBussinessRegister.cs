using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IBussinessRegister
/// </summary>
public interface IBussinessRegister
{

    DataTable getCoursesOffered();
    int registerStudent(string course, int sid);
	}
