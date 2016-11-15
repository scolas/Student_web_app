using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BussinessUnregister
/// </summary>
public class BussinessUnregister : IBussinessUnregister
{
    IRepositoryUnregister _irep = null;
	public BussinessUnregister():this(new Repository())
	{
		
	}
    public BussinessUnregister(IRepositoryUnregister irep)
    {
        _irep = irep;
    }
    public DataTable getCourses1(int id)
    {
        return _irep.getCourses1(id);
    }

    public int unregisterCourse()
    {
        throw new NotImplementedException();
    }
}