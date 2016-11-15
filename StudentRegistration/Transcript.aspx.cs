using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Transcript : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["LOGGEDIN"] == null)
            Response.Redirect("Login.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        IBusinessTranscript ibt = new BusinessTranscript();
         //ibt.getTrans(txtStudentId);
        int sid = Int32.Parse(txtStudentId.Text);
        //dt=ibt.getTrans(txtStudentId.Text);
        dt = ibt.getTrans(sid);
        GridViewTranscript.DataSource = dt;
        GridViewTranscript.DataBind();

    }
}