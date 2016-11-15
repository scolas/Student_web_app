using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Unregister : System.Web.UI.Page
{
    int sid;
    protected void Page_Load(object sender, EventArgs e)
    {




        if (!IsPostBack)
        {
            if (Session["LOGGEDIN"] == null)
                Response.Redirect("Login.aspx");
            //int sid = Int32.Parse(txtStudentId.Text);


        }
    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        sid = Convert.ToInt32(txtStudentId.Text);
        sid = int.Parse(txtStudentId.Text);


            DataTable dt = new DataTable();
          

     
            IBussinessUnregister ibr = new BussinessUnregister();

            
            

            dt = ibr.getCourses1(sid);
            ddCourse.DataSource = dt;
            ddCourse.DataValueField = "CourseNum";
            ddCourse.DataTextField = "CourseNum";
            ddCourse.DataBind();
       




    }


}