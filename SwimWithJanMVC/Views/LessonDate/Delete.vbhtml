@ModelType SwimWithJanMVC.LessonDate

@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
@Using Html.BeginForm()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
