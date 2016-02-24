@ModelType SwimWithJanMVC.Customer

@Code
    ViewData("Title") = "Edit"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Customer</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.CustomerLogin)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.CustomerLogin)
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
            @Html.LabelFor(Function(model) model.Address)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Address)
            @Html.ValidationMessageFor(Function(model) model.Address)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.City)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.City)
            @Html.ValidationMessageFor(Function(model) model.City)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.State)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.State)
            @Html.ValidationMessageFor(Function(model) model.State)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Zip)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Zip)
            @Html.ValidationMessageFor(Function(model) model.Zip)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.CellPhone)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.CellPhone)
            @Html.ValidationMessageFor(Function(model) model.CellPhone)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.HomePhone)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.HomePhone)
            @Html.ValidationMessageFor(Function(model) model.HomePhone)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Comments)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Comments)
            @Html.ValidationMessageFor(Function(model) model.Comments)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.Password)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.Password)
            @Html.ValidationMessageFor(Function(model) model.Password)
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
