$(".js-dictionaryBtn").off("click").on("click", function () {

    //Берём нообходимы данные из кнопки
    var divID = $(this).attr("id");
    console.log("DICTINARIES AREA - divID: " + divID);

    var section = $(this).attr("data-section");
    console.log("DICTINARIES AREA - section: " + section);

    //Снимаем со всех класс актив и ставим на нужную кнопку
    $(".js-dictionaryBtn").removeClass("active");
    $("#" + divID).addClass("active");

    //Вызываем аякс который нам вернёт паршел с нужными данными
});