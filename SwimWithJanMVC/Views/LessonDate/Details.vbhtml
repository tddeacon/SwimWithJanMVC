@ModelType SwimWithJanMVC.LessonDate

@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<fieldset>
    <legend>LessonDate</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Date)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Date)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Hour)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Hour)
    </div>
</fieldset>
<p>
    @*@Html.ActionLink("Edit", "Edit", New With {.id = Model.PrimaryKey}) |*@
    @Html.ActionLink("Back to List", "Index")
</p>
