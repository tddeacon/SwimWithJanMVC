@ModelType IEnumerable(Of SwimWithJanMVC.LessonDate)

@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Date)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Hour)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Date)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Hour)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = currentItem.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
