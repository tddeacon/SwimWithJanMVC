@ModelType IEnumerable(Of SwimWithJanMVC.Customer)

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
            @Html.DisplayNameFor(Function(model) model.CustomerLogin)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Address)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.City)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.State)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Zip)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CellPhone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.HomePhone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Comments)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Password)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.CustomerLogin)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.FirstName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.LastName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Address)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.City)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.State)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Zip)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.CellPhone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.HomePhone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Comments)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Password)
        </td>
        <td>
            @*@Html.ActionLink("Edit", "Edit", New With {.id = currentItem.PrimaryKey}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.PrimaryKey}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.PrimaryKey})*@
        </td>
    </tr>
Next

</table>
