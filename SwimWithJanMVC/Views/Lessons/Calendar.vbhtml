@ModelType IEnumerable(Of SwimWithJanMVC.Lesson)

@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.Kid.LastName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LessonDate.Hour)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Hour)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Duration)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Kid.LastName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.FirstName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.LessonDate.Hour)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Hour)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Duration)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = currentItem.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
