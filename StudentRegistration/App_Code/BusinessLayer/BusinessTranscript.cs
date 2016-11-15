using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BusinessTranscript
/// </summary>
public class BusinessTranscript : IBusinessTranscript
{
	IRepositoryTranscript _irep = null;
    public BusinessTranscript():this(new Repository())
	{
		
	}
    public BusinessTranscript(IRepositoryTranscript irep)
    {
        _irep = irep;
    }

    public DataTable getTrans(int id)
    {
        return _irep.getTranscript(id);
    }
}