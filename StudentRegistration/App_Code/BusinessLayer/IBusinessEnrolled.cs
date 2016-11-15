using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IBusinessEnrolled
/// </summary>
public interface IBusinessEnrolled
{
	
	 object getCourses();
     DataTable getGridData(string course);
	
}