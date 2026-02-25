$(document).ready(function () {
    debugger;
    if (products && products.length > 0) {
        addInvenstorytbl(products);
        hideReservedCol();
    }
})

function addInvenstorytbl(products) {
    debugger;
    var tblBody = $("#tblInventoryData");
    tblBody.empty();
    $.each(products, function (index, product) {
        var isLowStock = product.Stock < product.LowStockThreshold;
        var status = isLowStock ? '<span class="badge bg-danger">Low Stock</span>' : '<span class="badge bg-success">In Stock</span>';
        var rowclass = isLowStock ? "table-danger" : "";
        var row = `<tr class="${rowclass}">
                    <td>${product.Name}</td>
                    <td>${product.Category}</td>
                    <td>${product.Stock}</td>
                    <td class="ReservedCol"></td>
                    <td>${status}</td>
                    <td> <button class="btn btn-sm btn-outline-primary">View</button> </td>
                    </tr>`;
        tblBody.append(row);
    })
}
function hideReservedCol()
{
    $(".ReservedCol").hide();
}