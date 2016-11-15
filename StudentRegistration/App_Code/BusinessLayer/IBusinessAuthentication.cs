using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IBusinessAuthentication
/// </summary>

	public interface IBusinessAuthentication
	{
		bool VerifyLogin(string username,string password);
	}
