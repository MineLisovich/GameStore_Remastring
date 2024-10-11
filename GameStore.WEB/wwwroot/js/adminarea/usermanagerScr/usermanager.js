

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
