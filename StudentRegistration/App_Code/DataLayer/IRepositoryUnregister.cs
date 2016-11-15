using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IRepositoryUnregister
/// </summary>
public interface IRepositoryUnregister
{

    DataTable getCourses1(int id);
    int unregisterCourse();
	
}