function InitializationUsersTable() {
    var table = $('#dictionariesTable').DataTable({
        select: true,

        aLengthMenu: [
            [10, 25, 50, 100, -1],
            [10, 25, 50, 100, "все"]
        ],
        dom: 'QlBfrtip',
        buttons: [

            //Кнопка Добавить
            {
                text: 'Добавить',
                className: 'btn-create btntext btnmg',
                enabled: true,
                action: function () {

                    //var actionType = "edit";
                    //var section = "";
                    //AjaxActionGetCreateEditModal(actionType, "", section)
                    $("#modalDictionaryData").modal("show");
                  
                }
            },

            //Кнопка Изменить
            {
                text: 'Изменить',
                className: 'btn-edit btntext btnmg',
                enabled: false,
                action: function () {
                    //var id = table.cell('.selected', 2).data();
                    //var title = "";
                    //var message = "Вы уверены, что хотите внести изменения в данные о пользователе? ";
                    //var actionType = "edit";
                    //var section = "";
                    //PrepareWarningModal(id, title, message, actionType, section)
                    //$("#modalActionWarning").modal('show');
                }
            },
            //Кнопка Удалить
            {
                text: 'Удалить',
                className: 'btn-delete btntext btnmg',
                enabled: false,
                action: function () {
                   // var id = table.cell('.selected', 2).data();
                   // var title = "Удаление пользователя";
                    //var message = "После удаления восстановить данные будет невозможно";
                   // var actionType = "delete";
                    //var section = "";
                    //PrepareWarningModal(id, title, message, actionType, section)
                    //$("#modalActionWarning").modal('show');
                },
            },

            //Кнопка Скачать
            {
                text: 'Скачать',
                className: 'btn-download btntext btnmg',
                enabled: true,
                // экспорт данных
                extend: 'excelHtml5',
                autoFilter: true,
            }
        ],
        // определение столбцов для отображения в таблице
        select: {
            style: 'single'
        },
        columns: [
            { width: '5%', data: "id" },
            { data: "name" },

        ],

        language: tableLanguage.language,
    });



    // управление  кнопками disabled enabled
    $('#usersTable tbody').on('click', 'td', function () {
        table.on('select deselect', function () {
            var selectedRows = table.rows({ selected: true }).count();
            // если выбрана только одна строка
            if (selectedRows === 1) {
                table.button('.btn-edit').enable();
                table.button('.btn-delete').enable();

            } else if (selectedRows >= 2) {
                // если выбрано две или более строк
                table.button('.btn-edit').disable();
                table.button('.btn-delete').disable();
                table.button('.btn-add').enable();
            } else {
                // Если нет выбранных строк, блокировать все кнопки
                table.button('.btn-add').enable();
                table.button('.btn-edit').disable();
                table.button('.btn-delete').disable();
            }
        });
    });

}