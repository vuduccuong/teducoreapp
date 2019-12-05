var TodoController = function () {
    this.initialize = function () {
        loadData();
        registerEvents();

    };
    this.Delete = function (id) {
        $.post('/Admin/TodoList/Delete', {
            id: id
        }, function (data) {
                if (!data.err) {
                    tedu.notify("Xoá thành công", 'success');
                    loadData();
                }
                else {
                    tedu.notify("Có lỗi sảy ra, xin thử lại", 'error');
                }
        });
    };
    this.Update = function (id, Status) {
        console.log(id, Status);
        const status = Status === 1 ? 0 : 1;
        $.post('/Admin/TodoList/UpdateStatus', {
            id: parseInt(id),
            status: status
        }, function (data) {
            if (data) {
                loadData();
            }
        });
    };
        function registerEvents() {
            $('#create-todo-item').on('click', function () {
                $('#modal-add-edit').modal('show');
            });


            $('#frm-add-todo-item').validate({
                errorClass: 'red',
                lang: 'vi',
                rules: {
                    txtTodo: {
                        required: true,
                        maxlength: 50
                    }

                },
                messages: {
                    txtTodo: {
                        required: "Bạn phải nhập dữ liệu",
                        maxlength: "Bạn chỉ được nhập tối đa 50 kí tự"
                    }
                }
            });

            //Save
            $('#btnSaveM').off('click').on('click', function () {
                if ($('#frm-add-todo-item').valid()) {
                    const userID = $('#hid-user-id').val();
                    const content = $('#txtTodo').val();
                    const status = 0;
                    $.post('/Admin/TodoList/SaveTodoItem', {

                        UserID: userID,
                        Content: content,
                        Status: status
                    },
                        function (data) {
                            $('#modal-add-edit').modal('hide');
                            resetFormAddTodo();
                            if (data !== null) {
                                tedu.notify("Thêm mới thành công", 'success');
                                loadData();
                            }
                        });
                }
            });

        }

        function loadData() {

            const userid = $('#hid-user-id').val();
            const pageIndex = 1;
            const pageSize = 6;
            $.ajax({
                type: "GET",
                url: "/Admin/TodoList/GetTodoListByUser",
                data: {
                    userID: userid,
                    PageIndex: pageIndex,
                    PageSize: pageSize
                },
                dataType: "json",
                beforeSend: function () {
                    //tedu.startLoading();
                },
                success: function (response) {
                    var template = $('#table-template').html();
                    var render = "";
                    if (response.RowCount > 0) {
                        $.each(response.Results, function (i, item) {
                            render += Mustache.render(template, {
                                Content: item.Content,
                                Id: item.ID,
                                CreatedDate: item.BackDate,
                                statusx: item.Status === 1 ? "done" : '',
                                check: item.Status === 1 ? 'checked' : '',
                                Status: item.Status
                            });
                        });

                        if (render !== undefined) {
                            $('#todo-list').html(render);
                        }
                    }
                    else {
                        $('#todo-list').html('');
                    }
                    //tedu.stopLoading();

                },
                error: function (status) {
                    tedu.notify('Có lỗi xảy ra', 'error');
                    //tedu.stopLoading();
                }
            });
    }

        function resetFormAddTodo() {
            $('#txtTodo').val('');
        }
};