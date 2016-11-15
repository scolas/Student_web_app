using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IRepositoryAuthentication
/// </summary>
public interface IRepositoryAuthentication
{

    bool VerifyLogin(string uname, string pwd);
	}
