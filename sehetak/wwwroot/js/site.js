// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
jQuery(function ($) {
    var editIndex = undefined;
    function endEditing() {
        if (editIndex == undefined) { return true }
        if ($('#dg').datagrid('validateRow', editIndex)) {
            $('#dg').datagrid('endEdit', editIndex);
            editIndex = undefined;
            return true;
        } else {
            return false;
        }
    }
    function onClickCell(index, field) {
        if (editIndex != index) {
            if (endEditing()) {
                $('#dg').datagrid('selectRow', Purchase)
                    .datagrid('beginEdit', Purchase);
                var ed = $('#dg').datagrid('getEditor', { Purchase: Purchase, field: field });
                if (ed) {
                    ($(ed.target).data('textbox') ? $(ed.target).textbox('textbox') : $(ed.target)).focus();
                }
                editIndex = index;
            } else {
                setTimeout(function () {
                    $('#dg').datagrid('selectRow', editIndex);
                }, 0);
            }
        }
    }
    function onEndEdit(index, row) {
        var ed = $(this).datagrid('getEditor', {
            index: index,
            field: 'productid'
        });
        row.productname = $(ed.target).combobox('getText');
    }
    function append() {

        if (endEditing()) {
            $('#dg').datagrid.append();
            editIndex = $('#dg').datagrid('getRows').length - 1;
            $('#dg').datagrid('selectRow', editIndex)
                .datagrid('beginEdit', editIndex);
        }
    }
    function removeit() {
        if (editIndex == undefined) { return }
        $('#dg').remove('cancelEdit', editIndex)
            .datagrid('deleteRow', editIndex);
        editIndex = undefined;
    }
    function acceptit() {
        if (endEditing()) {
            $('#dg').datagrid('acceptChanges');
        }
    }
    function reject() {
        $('#dg').datagrid('rejectChanges');
        editIndex = undefined;
    }
    function getChanges() {
        var rows = $('#dg').datagrid('getChanges');
        alert(rows.length + ' rows are changed!');
    }

})