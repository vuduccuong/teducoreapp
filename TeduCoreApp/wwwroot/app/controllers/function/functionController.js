let functionController = {
    initial: function () {
        functionController.LoadData();
        functionController.registerEvent();

    },
    registerEvent: function () {
        $(document).off('click').on('click', '.btn-view', function () {
            $('#txtIDFunction').attr('disabled', 'disabled');
            $('#add-edit-modal').modal('show');
            const id = $(this).data('id');
            $.get('/admin/Function/GetById', {
                id: id
            }, function (data) {
                    console.log("get by id: ", data);
                    $('#txtIDFunction').val(data.Id);
                    $('#txtFunctionName').val(data.Name);
                    $('#txtParentID').val(data.ParentId);
                    $('#txtIconCss').val(data.IconCss);
                    $('#txtDisplayOrder').val(data.SortOrder);
                    $('#txtUrl').val(data.URL);
            });
        });
    },

    LoadData: function() {
        $.get('/admin/Function/GetAll', function (data) {
            console.log("result filter: ", data);
            var template = $('#table-template').html();
            var render = "";
            if (data.length > 0) {
                $.each(data, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        FunctionName: item.Name,
                        ParentID: item.ParentId,
                        IconCss: item.IconCss,
                        SortOrder: item.SortOrder,
                        Status: item.Status,
                        Url: item.URL
                    });
                });

                if (render !== undefined) {
                    $('#tbl-content').html(render);
                }
            }
            else {
                $('#tbl-content').html('');
            }
            //tedu.stopLoading();
        });
    }
};

$(document).ready(function () {
    functionController.initial();
});