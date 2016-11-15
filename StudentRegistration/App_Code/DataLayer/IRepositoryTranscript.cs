using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IRepositoryTranscript
/// </summary>
public interface IRepositoryTranscript
{
	DataTable getTranscript(int id);
	
}