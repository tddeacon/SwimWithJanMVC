@ModelType SwimWithJanMVC.Lesson

@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Lesson</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.CustomerLogin, "Kid")
        </div>
        <div class="editor-field">
            @Html.DropDownList("CustomerLogin", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.CustomerLogin)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.FirstName)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.FirstName)
            @Html.ValidationMessageFor(Function(model) model.FirstName)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Date, "LessonDate")
        </div>
        <div class="editor-field">
            @Html.DropDownList("Date", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.Date)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Hour)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Hour)
            @Html.ValidationMessageFor(Function(model) model.Hour)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.description)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.description)
            @Html.ValidationMessageFor(Function(model) model.description)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Duration)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Duration)
            @Html.ValidationMessageFor(Function(model) model.Duration)
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
