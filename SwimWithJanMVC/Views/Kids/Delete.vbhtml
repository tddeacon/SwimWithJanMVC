@ModelType SwimWithJanMVC.Kid

@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
@Using Html.BeginForm()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
