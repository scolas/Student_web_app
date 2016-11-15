using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack)
        {
            string value = listCourseOffered.SelectedValue;
            SessionId.Text = value;
        }
        if (!IsPostBack)
        {

            DataTable dt = new DataTable();
            //SessionId.Text = Session.SessionID;

             if (Session["LOGGEDIN"] == null)
              Response.Redirect("Login.aspx");
            IBussinessRegister ibr = new BussinessRegister();

            List<String> course = new List<String>();

            dt = ibr.getCoursesOffered();
            //listCourseOffered.DataSource = dt;
            //listCourseOffered.DataBind();
            listCourseOffered.DataSource = dt;
            listCourseOffered.DataValueField = "CourseNum";
            listCourseOffered.DataTextField = "CourseNum";
            listCourseOffered.DataBind();
            string value = listCourseOffered.SelectedValue;
            SessionId.Text = value;

        }


       




    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        IBussinessRegister ibr = new BussinessRegister();
        ibr.registerStudent("csscott", 123);
    }
}