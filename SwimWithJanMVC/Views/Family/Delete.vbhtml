@ModelType SwimWithJanMVC.Customer

@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
@Using Html.BeginForm()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
