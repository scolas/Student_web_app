using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IRepositoryEnrolled
/// </summary>
public interface IRepositoryEnrolled
{
	
		object getCourses();
        DataTable getGridData(string course);
	
}