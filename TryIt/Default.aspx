<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        &nbsp;</p>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://webstrar49.fulton.asu.edu/index.html">http://webstrar49.fulton.asu.edu/index.html</asp:HyperLink>
    </p>
    <p>
        <asp:Label ID="TryItLabel" runat="server" Text="TryIt" Font-Bold="True"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="FindNearestStoreLabel" runat="server" Text="FindNearestStore"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p>
        Find the nearest store to the entered zipcode</p>
    <p>
        string findNearestStore(string zipcode, string name)&nbsp;&nbsp;&nbsp;
    </p>
    <p>
&nbsp;<asp:Label ID="ZipcodeLabel" runat="server" Text="Zipcode:"></asp:Label>
&nbsp;
        <asp:TextBox ID="ZipcodeTextBox" runat="server" Height="18px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="StoreNameLabel" runat="server" Text="StoreName:"></asp:Label>
&nbsp;
        <asp:TextBox ID="StoreNameTextBox" runat="server" Height="16px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="InvokeNearestStore" runat="server" OnClick="InvokeNearestStore_Click" Text="Invoke" />
    </p>
    <p>
        <asp:Label ID="StoreResult" runat="server" Text="Return Result Here"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="WordCountLabel" runat="server" Text="WordCount"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p>
        Analyze a text file and return a string of json data. The key is a word appearing in the file and its value is the number of occurences in the file, listed in descending order.</p>
    <p>
        string wordCount(string contents)</p>
    <p>
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="InvokeWordCount" runat="server" OnClick="InvokeWordCount_Click" Text="Invoke" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        <asp:Label ID="CountResult" runat="server" Text="Return Result Here"></asp:Label>
    </p>
<p>
        &nbsp;</p>
<p>
        WebDownload Service</p>
<p>
        &nbsp;<asp:Label ID="URLlbl" runat="server" Text="URL:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtURL" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDownload" runat="server" OnClick="btnDownload_Click" Text="Download" />
    </p>
<p>
        <asp:TextBox ID="txtWebDownloadOutput" runat="server" Rows="10" TextMode="MultiLine"></asp:TextBox>
    </p>
<p>
        &nbsp;</p>
<p>
        WordFilter Service</p>
<p>
        <asp:Label ID="lblText" runat="server" Text="Text:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtText" runat="server"></asp:TextBox>
    </p>
<p>
        Stop Words (comma separated):
        <asp:TextBox ID="txtStopWords" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFilter" runat="server" OnClick="btnFilter_Click" Text="Filter" />
    </p>
<p>
        <asp:TextBox ID="txtWordFilterOutput" runat="server" Rows="10" TextMode="MultiLine"></asp:TextBox>
    </p>
<p>
        &nbsp;</p>
<p>
        Solar Intensity Service</p>
<p>
        Enter day of year as an int (out of 365 days):&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
        Enter Latitude:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
        Enter Longitude:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
</p>
<p>
        <asp:Button ID="btnCalculate" runat="server" OnClick="btnCalculate_Click" Text="Calculate" />
</p>
<p>
        Average Solar Intensity in kWh per square meter:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</p>
<p>
        UV Index for given location:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
</p>
    <p>
        &nbsp;</p>
    <p>
        Wind Intensity Service</p>
    <p>
        Enter Latitude:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtLat" runat="server"></asp:TextBox>
</p>
    <p>
        Enter Longitude:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtLong" runat="server"></asp:TextBox>
</p>
    <p>
        <asp:Button ID="btnCalculateWind" runat="server" OnClick="btnCalculateWind_Click" Text="Calculate" />
</p>
    <p>
        Wind pressure for given location:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtWindPressure" runat="server"></asp:TextBox>
&nbsp;Pound Force Per Square Yard</p>
    <p>
        Annual average wind index for given location:&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtWindIndex" runat="server"></asp:TextBox>
</p>

</asp:Content>
