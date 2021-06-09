using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LessonUI
{
    public partial class UpdatePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            string pwd = txtPwd.Text.Trim();
            string NewPwd = txtNewPwd.Text.Trim();
            string rePwd = txtRePwd.Text.Trim();
        }
    }
}