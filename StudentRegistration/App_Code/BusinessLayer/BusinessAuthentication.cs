using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BusinessAuthentication
/// </summary>
public class BusinessAuthentication : IBusinessAuthentication
{
    IRepositoryAuthentication _irep = null;
	public BusinessAuthentication():this(new Repository())
	{
	}

    public BusinessAuthentication(IRepositoryAuthentication irep)
    {
        _irep = irep;
    }

    public bool VerifyLogin(string username, string password)
    {
        return _irep.VerifyLogin(username, password);
        
    }
}