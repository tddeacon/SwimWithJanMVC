@ModelType SwimWithJanMVC.Kid

@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<fieldset>
    <legend>Kid</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Customer.FirstName)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Customer.FirstName)
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
        @Html.DisplayNameFor(Function(model) model.Age)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Age)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.CurrentLevel)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.CurrentLevel)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.StartLevel)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.StartLevel)
    </div>
</fieldset>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
