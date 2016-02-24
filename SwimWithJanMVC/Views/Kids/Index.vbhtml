@ModelType IEnumerable(Of SwimWithJanMVC.Kid)

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
            @Html.DisplayNameFor(Function(model) model.Customer.FirstName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Age)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CurrentLevel)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.StartLevel)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Customer.FirstName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.FirstName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.LastName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Age)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.CurrentLevel)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.StartLevel)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = currentItem.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
