
if (getCookie('username')!==null) {
    startUp();
} else {
    window.location = 'login.html';
}


function getCookie(name) {
    if (isEmpty(document.cookie))
        return null;
    var documentCookieArr = document.cookie.split(';');
    var nameCookieArr = documentCookieArr.filter(x => x.includes('username'))[0].split('=');
    if (isEmpty(nameCookieArr))
        return null;
    if (nameCookieArr <= 1)
        return null;
    var nameValue = nameCookieArr[1];
    if (isEmpty(nameValue))
        return null;
    return nameValue;
}

function isEmpty(val) {
    return (val === undefined || val == null || val.length <= 0) ? true : false;
}

function startUp() {
    document.write('this is the cart');
}

//function deleteAllCookies() {
//    var cookies = document.cookie.split(";");
//    for (var i = 0; i < cookies.length; i++) {
//        var cookie = cookies[i];
//        var eqPos = cookie.indexOf("=");
//        var name = eqPos > -1 ? cookie.substr(0, eqPos) : cookie;
//        document.cookie = name + "=;expires=Thu, 01 Jan 1970 00:00:00 GMT";
//    }
//};