using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentsEnrolled : System.Web.UI.Page
{
    string strDDLVal = " ";
    protected void Page_Load(object sender, EventArgs e)
    {
       

        if (!IsPostBack)
        {

            if (Session["LOGGEDIN"] == null)
                Response.Redirect("Login.aspx");
            IBusinessEnrolled iba = new BusinessEnrolled();
           // List<StudentsEnrolled> lstud= new List<StudentsEnrolled>;
            //ENABLED THIS WHEN FINISHED  if (Session["LOGGEDIN"] == null)
            // THIS TO Response.Redirect("Login.aspx");



            listCourse.DataSource = iba.getCourses();
            listCourse.DataTextField = "CourseNum";
           
            listCourse.DataValueField = "StudentID";
            listCourse.DataBind();

        }
        
       strDDLVal = listCourse.SelectedValue;
        lblSessionID.Text = Session.SessionID + " " + "This is the selected" + strDDLVal.ToString();
    }
    
        public void fillGridView(){
          IBusinessEnrolled ibe = new BusinessEnrolled();
            DataTable dt = new DataTable();


            string idd = strDDLVal.ToString();

            dt = ibe.getGridData(idd);
            this.GridView1.Visible = true;
            GridView1.DataSource = dt;
        GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            fillGridView();
        }
}