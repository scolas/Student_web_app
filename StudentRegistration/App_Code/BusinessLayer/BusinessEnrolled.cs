using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BusinessEnrolled
/// </summary>
public class BusinessEnrolled : IBusinessEnrolled
{
    IRepositoryEnrolled _irep = null;
   
    public BusinessEnrolled():this(new Repository())
	{
        
	}

    
    public BusinessEnrolled(IRepositoryEnrolled irep)
    {
        _irep = irep;
    }

  
    public object getCourses()
    {
        return _irep.getCourses();
    }


    public DataTable getGridData(string course)
    {
        return _irep.getGridData(course);
    }
}