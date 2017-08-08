using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected override void OnLoad(EventArgs e)
    {
        if (!IsPostBack)
        {
            rblShippers.SelectedIndex = 0;
        }
    }

    public void btnOrder_Click(object sender, EventArgs e)
    {
        lblMsg.Text = "Thank you " + txtName.Text.Trim() + ".  You chose " +
           rblShippers.SelectedItem.Text.ToString() + " whose ID is " +
           rblShippers.SelectedValue.ToString();
    }

}
