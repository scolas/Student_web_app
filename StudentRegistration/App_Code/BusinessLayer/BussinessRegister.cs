using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BussinessRegister
/// </summary>
public class BussinessRegister : IBussinessRegister

    
{
    IRepositoryRegister _irep = null;
	public BussinessRegister():this(new Repository())
	{
        
	}
    public BussinessRegister(IRepositoryRegister irep)
    {
        _irep = irep;
    }

    public DataTable getCoursesOffered()
    {
        return _irep.getCoursesOffered();
    }

    public int registerStudent(string course, int id)
    {
      
        int numr = _irep.getNumR();
        int cap = _irep.getCap();
        if (numr < cap)
            return _irep.registerStudent(course, id);
        else
            return 0;

       
    }
}