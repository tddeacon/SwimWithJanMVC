@ModelType SwimWithJanMVC.Kid

@Code
    ViewData("Title") = "Create"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Kid</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.CustomerLogin, "Customer")
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
            @Html.LabelFor(Function(model) model.LastName)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.LastName)
            @Html.ValidationMessageFor(Function(model) model.LastName)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Age)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Age)
            @Html.ValidationMessageFor(Function(model) model.Age)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.CurrentLevel)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.CurrentLevel)
            @Html.ValidationMessageFor(Function(model) model.CurrentLevel)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.StartLevel)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.StartLevel)
            @Html.ValidationMessageFor(Function(model) model.StartLevel)
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
