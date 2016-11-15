using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Repository
/// </summary>
public class Repository : IRepositoryAuthentication, IRepositoryEnrolled, IRepositoryRegister, IRepositoryUnregister, IRepositoryTranscript
{
    IDataAccess _idac = null;
    
	public Repository()
	{
        _idac = new DataAccess();
	}

    public Repository(IDataAccess idac)
    {
        _idac = idac;
    }

    public bool VerifyLogin(string uname, string pwd)
    {
        bool ret = false;
        try
        {
            string sql = "select Username from Users where " +
                "Username='" + uname + "'and Password='" + pwd + "'";
            object obj = _idac.GetSingleAnswer(sql);
            if (obj != null)
                ret = true;
        }
        catch (Exception)
        {
            
            throw;
        }
        return ret;
    }
    public object getCourses21(int id)
    {
        DataTable ret = null;
        try
        {
            string sql = "select CourseNum from Enrollments";
            DataTable obj = _idac.GetManyRowCols(sql);
            if (obj != null)
                ret = obj;
        }
        catch (Exception)
        {

            throw;
        }
        return ret;
    }

    public object getCourses()
    {
        object ret = null;
        try
        {
            string sql = "select CourseNum, StudentID, SectionNum from Enrollments";
            object obj = _idac.GetManyRowCols(sql);
            if (obj != null)
                ret = obj;
        }
        catch (Exception)
        {

            throw;
        }
        return ret;
    }


    public DataTable getGridData(string course)
    {
        DataTable ret = null;
        try
        {
            string sql = "select CourseNum, StudentID, SectionNum from Enrollments";
            DataTable obj = _idac.GetManyRowCols(sql);
            if (obj != null)
                ret = obj;
        }
        catch (Exception)
        {

            throw;
        }
        return ret;
    }

    public DataTable getCoursesOffered()
    {
        DataTable ret = null;
        try
        {
            string sql = "select CourseNum from OfferedCourses";
            DataTable obj = _idac.GetManyRowCols(sql);
            if (obj != null)
                ret = obj;
        }
        catch (Exception)
        {

            throw;
        }
        return ret;
    }

    public int registerStudent(string course, int sid)
    {
        int ret=0;
        int i;
        try
        {


            string sql1 = "INSERT into Enrollments (CourseNum,StudentID,SectionNum) " + " VALUES ('" + course + "', '" + 12358 + "', '" + 1 + "');";
           string sql = "insert into Enrollments (CourseNum, StudentID, SectionNum) value('" + course + "','" + sid + "','" + 1 + "');";
           // string sql = "insert into Enrollments value(@course,@id, @sec)";
            SqlCommand con = new SqlCommand(sql);
            con.Parameters.AddWithValue("@course", course);
            con.Parameters.AddWithValue("@id", sid);
            con.Parameters.AddWithValue("@sec", 1);
            i = _idac.InsertUpdateDelete(sql1);
           // i= _idac.InsertUpdateDelect(sql,cours511,899094,2);
           // i = _idac.InsertUpdateDelete(sql);
            if (i != null)
                ret = 2;
            
        }
        catch (Exception)
        {
            
            throw;
        }
        
        return ret;
    }




    public int unregisterCourse(int id)
    {
        throw new NotImplementedException();
    }

    public DataTable getTranscript(int id)
    {
        DataTable ret = null;
     

        try
        {
            //"select Username from Users where " +
              //   "Username='" + uname + "'and Password='" + pwd + "'";
            string sql = "select CourseNum, Grade from TakenCourses where " 
                + "StudentID='" + id + "'";
            DataTable obj = _idac.GetManyRowCols(sql);
            if (obj != null)
                ret = obj;
        }
        catch (Exception)
        {

            throw;
        }
        return ret;
    }


    public int getNumR()
    {
        object ret = null;
        try
        {
            string sql = "select NumRegistered from OfferedCourses";
            object obj = _idac.GetSingleAnswer(sql);
            if (obj != null)
                ret = obj;
        }
        catch (Exception)
        {

            throw;
        }
        int i = (int)ret;
        return i;
    }

    public int getCap()
    {
        object ret = null;
        try
        {
            string sql = "select Capacity from OfferedCourses";
            object obj = _idac.GetSingleAnswer(sql);
            if (obj != null)
                ret = obj;
        }
        catch (Exception)
        {

            throw;
        }
        int i = (int)ret;
        return i;
    }

    public DataTable getCourses1(int id)
    {
        DataTable ret = null;
        try
        {
            //"select Username from Users where " +
            //   "Username='" + uname + "'and Password='" + pwd + "'";
            string sql = "select CourseNum from Enrollments where" + "StudentID='" + id + "'";
            DataTable obj = _idac.GetManyRowCols(sql);
            if (obj != null)
                ret = obj;
        }
        catch (Exception)
        {

            throw;
        }
        return ret;
    }

    public int unregisterCourse()
    {
        throw new NotImplementedException();
    }
}