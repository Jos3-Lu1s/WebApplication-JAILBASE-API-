<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Async="true" Inherits="WebApplication_JAILBASE_API_.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Style/Bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="Style/css/style.css" rel="stylesheet" />
    <link href="Scripts/Select2/select2.min.css" rel="stylesheet" />
    <title>JailBase</title>
</head>
<body>
    <form id="form1" runat="server">
        <header class="bg-dark">
            <div class="container py-2">
                <a class="text-light text-decoration-none h2" href="#">JailBase<span>API</span></a>
            </div>
        </header>
        <main>
            <div class="p-3 text-center heroe">
                <div class="col-md-5 p-lg-5 mx-auto my-5">
                    <h1 class="display-4 fw-normal">JAILBASE</h1>
                    <p class="lead fw-normal">An informational site for friends, family, and victims of arrested persons.</p>
                </div>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-md-6">
                        <div class="p-3 form my-4">
                            <h3 class="text-center">CONDADO</h3>
                            <asp:DropDownList ID="DdlCondado" Style="width: 100%" CssClass="js-example-basic-single form-control" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="p-3 form my-4">
                            <h3 class="text-center">PRESO</h3>
                            <asp:DropDownList ID="DdlLastName" Style="width: 100%" CssClass="js-example-basic-single form-control" runat="server"></asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
        </main>
        <footer>
        </footer>
    </form>


    <script src="Style/Bootstrap/bootstrap.bundle.min.js"></script>
    <script src="Scripts/jquery/jquery-3.6.0.min.js"></script>
    <script src="Scripts/Select2/select2.min.js"></script>

    <script>
        // In your Javascript (external .js resource or <script> tag)
        $(document).ready(function () {
            $('.js-example-basic-single').select2({
                placeholder: 'Select an option',
                allowClear: true,
            });
        });
    </script>
</body>
</html>
