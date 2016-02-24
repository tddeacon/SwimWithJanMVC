@ModelType SwimWithJanMVC.Lesson

@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>Lesson</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Kid.LastName)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Kid.LastName)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.FirstName)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.FirstName)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.LessonDate.Hour)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.LessonDate.Hour)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Hour)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Hour)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.description)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.description)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Duration)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Duration)
    </div>
</fieldset>
@Using Html.BeginForm()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
