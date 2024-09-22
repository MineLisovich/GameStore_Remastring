//region BUTTONS
$("#btnEditProfileData").on("click", function () {
    console.log("НАЖАТА КНОПКА РЕДАКТИРОВАТЬ ДАННЫЕ");
    var userId = $("#AppUser_Email").val();
    var section = $(this).attr("data-section");
    console.log("userId: " + userId + " section: " + section);
    var message = GetMessageForModalActionWarning(section);
    console.log("message: " + message);
 
    var actionType = "edit";
    var title = "";
    PrepareWarningModal(userId, title, message, actionType, section);
   
    $("#modalActionWarning").modal('show');
});
//endregion

function GetMessageForModalActionWarning(section) {
    var message = "";
    switch (section) {
        case "userdata":
            message = "Вы уверены, что хотите внести изменения?";
            break;
       
    }
    return message;
}

