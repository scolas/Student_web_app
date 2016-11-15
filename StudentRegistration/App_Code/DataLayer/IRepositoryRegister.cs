using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IRepositoryRegister
/// </summary>
public interface IRepositoryRegister
{
    DataTable getCoursesOffered();
    int registerStudent(string course, int sid);
    int getNumR();
    int getCap();
	
}