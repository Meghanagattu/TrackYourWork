using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrackYourWork.Repository;

namespace TrackYourWork
{
    public partial class Admin : Page
    {
        TYWRepo repo = new TYWRepo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvbind();
            }
            if (!System.Web.HttpContext.Current.User.Identity.IsAuthenticated)
            {
                Response.Redirect("Account/Login", false);
            }
            
        }
        protected void gvbind()
        {

            DataSet ds = new DataSet();
            ds = repo.GetTicketDetails();
            if (ds.Tables[0].Rows.Count > 0)
            {
                grvITAdmin.DataSource = ds;
                grvITAdmin.DataBind();
            }
            else
            {
                ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                grvITAdmin.DataSource = ds;
                grvITAdmin.DataBind();
                int columncount = grvITAdmin.Rows[0].Cells.Count;
                grvITAdmin.Rows[0].Cells.Clear();
                grvITAdmin.Rows[0].Cells.Add(new TableCell());
                grvITAdmin.Rows[0].Cells[0].ColumnSpan = columncount;
                grvITAdmin.Rows[0].Cells[0].Text = "No Records Found";
            }
        }
        protected void grvITAdmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)grvITAdmin.Rows[e.RowIndex];
            int rowId = Convert.ToInt32(row.Cells[0].Text);
            repo.DeleteTicketByRowId(rowId);
            gvbind();
        }
        protected void grvITAdmin_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grvITAdmin.EditIndex = e.NewEditIndex;
            gvbind();
        }
        protected void grvITAdmin_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int ticketid = Convert.ToInt32(grvITAdmin.DataKeys[e.RowIndex].Value.ToString());
            GridViewRow row = (GridViewRow)grvITAdmin.Rows[e.RowIndex];
            TextBox ticketDesc = (TextBox) row.Cells[1].Controls[0];
            TextBox Status = (TextBox)row.Cells[2].Controls[0];
            TextBox assignTo = (TextBox)row.Cells[3].Controls[0];
            repo.UpdateTicketDetails(ticketDesc.Text, Status.Text, assignTo.Text, ticketid);
            grvITAdmin.EditIndex = -1;

            gvbind();
            //grvITAdmin.DataBind();  
        }
        protected void grvITAdmin_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grvITAdmin.PageIndex = e.NewPageIndex;
            gvbind();
        }
        protected void grvITAdmin_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grvITAdmin.EditIndex = -1;
            gvbind();
        }
    }
}