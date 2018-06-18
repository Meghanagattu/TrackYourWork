<%@ Page Title="Ticket Tracker" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SubmitTicket.aspx.cs" Inherits="TrackYourWork.SubmitTicket" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>Raise a ticket here</h3>

    <asp:PlaceHolder ID="PlaceHolder1" runat="server">
        <div style="overflow-x: auto">
            <asp:Table ID="submitTicket" runat="server">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblEmail" runat="server" Text="Email Id"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="tbEmailId" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
                            ErrorMessage="*" ControlToValidate="tbEmailId"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="rgvEmail" runat="server" ErrorMessage="Please enter valid email id" ControlToValidate="tbEmailId" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="requiredFieldValidateStyle">

                        </asp:RegularExpressionValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="lblTicketDesc" runat="server" Text="Label"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox runat="server" ID="tbTicketDesc" TextMode="MultiLine" Rows="5" Columns="50"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvTicketDesc" runat="server"
                            ErrorMessage="*" ControlToValidate="tbEmailId"
                            ForeColor="Red"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label runat="server" ID="lblTickType" Text="Ticket Type"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID="ddlTicketType" runat="server" Width="200px">
                            <asp:ListItem Value="NoItemSelected">--Select--</asp:ListItem>
                            <asp:ListItem Value="Website">Website</asp:ListItem>
                            <asp:ListItem Value="MobileApp">Mobile App</asp:ListItem>
                            <asp:ListItem Value="Subscriptions">Subscriptions</asp:ListItem>
                            <asp:ListItem Value="General">General</asp:ListItem>
                            <asp:ListItem Value="Other">Other</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvddlTicketTyoe" runat="server" ControlToValidate="ddlTicketType"
                            InitialValue="NoItemSelected" ErrorMessage="Please select something" />

                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                        <asp:Button runat="server" Text="Submit" ID="btnSubmit" CausesValidation="true" OnClick="btnSubmit_Click" UseSubmitBehavior="true" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
    </asp:PlaceHolder>

    <style type="text/css">
        table {
            width: 100%;
            border-collapse: collapse;
        }
        /* Zebra striping */
        tr:nth-of-type(odd) {
            background: #eee;
        }

        th {
            background: #333;
            color: white;
            font-weight: bold;
        }

        td, th {
            padding: 6px;
            /*border: 1px solid #ccc;*/
            text-align: left;
        }

        @media only screen and (max-width: 760px), (min-device-width: 768px) and (max-device-width: 1024px) {

            /* Force table to not be like tables anymore */
            table, thead, tbody, th, td, tr {
                display: block;
            }

                /* Hide table headers (but not display: none;, for accessibility) */
                thead tr {
                    position: absolute;
                    top: -9999px;
                    left: -9999px;
                }

            tr {
                border: 1px solid #ccc;
            }

            td {
                /* Behave  like a "row" */
                border: none;
                border-bottom: 1px solid #eee;
                position: relative;
                padding-left: 50%;
            }

                td:before {
                    /* Now like a table header */
                    position: absolute;
                    /* Top/left values mimic padding */
                    top: 6px;
                    left: 6px;
                    width: 45%;
                    padding-right: 10px;
                    white-space: nowrap;
                }
        }
    </style>
</asp:Content>

