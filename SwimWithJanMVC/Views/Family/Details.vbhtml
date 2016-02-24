@ModelType SwimWithJanMVC.Customer

@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<fieldset>
    <legend>Customer</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.CustomerLogin)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.CustomerLogin)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.FirstName)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.FirstName)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.LastName)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.LastName)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Address)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Address)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.City)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.City)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.State)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.State)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Zip)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Zip)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.CellPhone)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.CellPhone)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.HomePhone)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.HomePhone)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Comments)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Comments)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Password)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Password)
    </div>
</fieldset>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
