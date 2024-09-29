//BUTTONS
$("#userdata, .js-btn").off("click").on("click", function () {
    var userId = $("#AppUser_Email").val();
    var section = $(this).attr("data-section");
    var actionType = $(this).attr("data-action");
    console.log("userId: " + userId + " section: " + section);
    var message = GetMessageForModalActionWarning(section);
    console.log("message: " + message);
    
    var title = "";
    PrepareWarningModal(userId, title, message, actionType, section);
    $("#modalActionWarning").modal('show');

});


function GetMessageForModalActionWarning(section) {
    var message = "";
    switch (section) {
        case "userdata":
            message = "Вы уверены, что хотите внести изменения?";
            break;
        case "changePass":
            message = "Вы уверены, что хотите изменить пароль?";
            break;
        case "deleteAccount":
            message = "Вы уверены, что хотите удалить свой аккаунт? После удаления восстановить данные будет не возможно!";
            break;
       
    }
    return message;
}

