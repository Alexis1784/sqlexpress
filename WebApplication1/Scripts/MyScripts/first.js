
//$('.Authorblock').hide();
//$(function () {
//    alert('Подключена последняя версия jQuery через Google хостинг');
//});
//­Вы­пол­ня­ет­за­прос­HTTP­GET­со­дер­жи­мо­го­ука­зан­но­го­URL-ад­ре­са.
//­По­сле­ус­пеш­но­го­по­лу­че­ния­от­ве­та­про­ве­ря­ет,­со­дер­жит­ли­он­про­стой­текст,
//­и­пе­ре­да­ет­его­ука­зан­ной­функ­ции­об­рат­но­го­вы­зо­ва
//function getText(url, callback) {
//    var request = new XMLHttpRequest();         // Создать  новый  запрос
//    request.open("GET", url);                   // Указать URL-адрес ресурса
//    request.onreadystatechange = function () {   // Определить  обработчик  события

//        // Ес ли  за прос  был  вы пол нен  ус пеш но        
//        if (request.readyState === 4 && request.status === 200) {
//            var type = request.getResponseHeader("Content-Type");

//            if (type.match(/^text/)) {// Убедиться, что это текст
//                callback(request.responseText);  // Передать функции
//            }
//        }
//    };
//    request.send(null);                          // Отправить запрос
//}

// 1. Создаём новый объект XMLHttpRequest
var xhr = new XMLHttpRequest();


// 2. Конфигурируем его: GET-запрос на URL 'phones.json'
xhr.open('GET', 'phones.json', false);
//alert(" send");
// 3. Отсылаем запрос
xhr.send();

// 4. Если код ответа сервера не 200, то это ошибка
if (xhr.status != 200) {
    // обработать ошибку
    alert(xhr.status + ': ' + xhr.statusText); // пример вывода: 404: Not Found
} else {
    // вывести результат
    alert(xhr.responseText); // responseText -- текст ответа.
}