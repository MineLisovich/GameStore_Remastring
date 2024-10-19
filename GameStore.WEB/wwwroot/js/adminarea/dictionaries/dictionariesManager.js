//Глобальная переменная которая хранит текущюю секцию
var currentDictionarySection;
$(".js-dictionaryBtn").off("click").on("click", function () {

    //Берём нообходимы данные из кнопки
    var divID = $(this).attr("id");
    console.log("DICTINARIES AREA - divID: " + divID);

    var section = $(this).attr("data-section");
    currentDictionarySection = section;
    console.log("DICTINARIES AREA - currentDictionarySection: " + currentDictionarySection);

    //Снимаем со всех класс актив и ставим на нужную кнопку
    $(".js-dictionaryBtn").removeClass("active");
    $("#" + divID).addClass("active");

    //Получаем ссылку
    var url = GetUrlFotAjaxActionGetData();
    console.log("DICTINARIES AREA - url: " + url);
    //Вызываем аякс который нам вернёт паршел с нужными данными
    AjaxActionGetData(section,url);
});

function AjaxActionGetData(section,url) {
    console.log("DICTINARIES AREA - AjaxActionGetData - section: " + section);

    //отправляем запрос
    $.ajax({
        cache: false,
        type: "GET",
        url: url,
        data: { sectionName: section},
        dataType: "html",
        success: function (data) {
            $("#js-showTable").empty();
            $("#js-showTable").append(data);
            SettingsDictionaryDataTable();
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert('Ошибка загрузки модального окна!!!');
        }
    });
}