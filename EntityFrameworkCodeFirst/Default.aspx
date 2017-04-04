

<%--A simple form to read details of a Customer--%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EntityFrameworkCodeFirst.Default" %>

<!DOCTYPE html>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Code-First в Entity Framework</title>
</head>
<body>
    <div class="form">
        <form id="form1" runat="server" enctype="multipart/form-data">
            <h3>Personal Details</h3>
            <div class="data">
                <div>
                    <label>Name</label>
                    <input name="name" />
                </div>
                <div>
                    <label>Email</label>
                    <input name="email" />
                </div>
                <div>
                    <label>Age</label>
                    <input name="age" />
                </div>
                <div>
                    <label>Photo</label>
                    <input type="file" name="photo" />
                </div>
                <input type="submit" value="Insert into DB" />
            </div>
        </form>
    </div>

    <style>
        .form { position: absolute; left: 50%; width: 470px; margin-left: -235px; background: #888; border-radius: 5px; top: 20px; }
        form { background: #fff; border-radius: 2px;  margin: 5px;  }
        .data { border-top: 1px solid #d5d5d5; padding: 10px 15px; }
        .data div { margin: 8px 0; }
        h3 { padding: 10px 15px; margin: 0; }
        label { min-width: 100px; display: block; float: left; }
        input[type="submit"] { margin-top: 10px; }
    </style>
</body>
</html>
