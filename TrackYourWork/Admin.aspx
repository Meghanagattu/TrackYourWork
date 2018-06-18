<%@ Page Title="IT Admin" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="TrackYourWork.Admin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Manage tickets here.</h3>
    <asp:GridView ID="grvITAdmin" runat="server" AutoGenerateColumns="false" DataKeyNames="TicketId" OnPageIndexChanging="grvITAdmin_PageIndexChanging" OnRowCancelingEdit="grvITAdmin_RowCancelingEdit" OnRowDeleting="grvITAdmin_RowDeleting" OnRowEditing="grvITAdmin_RowEditing" OnRowUpdating="grvITAdmin_RowUpdating">
        <Columns>
            <asp:BoundField DataField="TicketId" HeaderText="TicketId" />
            <asp:BoundField DataField="TicketDesc" HeaderText="Ticket Desc" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
            <asp:BoundField DataField="AssignedTo" HeaderText="Assign To" />
            <asp:CommandField ShowEditButton="true" />
            <asp:CommandField ShowDeleteButton="true" />
        </Columns>
    </asp:GridView>
</asp:Content>
