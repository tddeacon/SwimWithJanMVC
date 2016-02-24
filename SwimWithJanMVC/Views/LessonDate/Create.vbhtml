@ModelType SwimWithJanMVC.LessonDate

@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>LessonDate</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Date)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Date)
            @Html.ValidationMessageFor(Function(model) model.Date)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Hour)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Hour)
            @Html.ValidationMessageFor(Function(model) model.Hour)
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
