﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrackYourWork.Repository;

namespace TrackYourWork
{
    public partial class _Default : Page
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

            TYWRepo tywRepo = new TYWRepo();
            string result = tywRepo.CreateNewTicket(emailId, ticketDesc, ticketType);
            if (String.Compare(result, "Success") == 0)
                Response.Write("<script>alert('Data inserted successfully')</script>");
            else
                Response.Write("<script>alert('Oops!! Something went wrong, please try again!')</script>");
        }
    }
}