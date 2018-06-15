using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrackYourWork
{
    public partial class SubmitTicket : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Submit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string emailId, ticketDesc, ticketType;
            emailId = tbEmailId.Text;
            ticketDesc = tbTicketDesc.Text;
            ticketType = ddlTicketType.SelectedValue;
        }
    }
}