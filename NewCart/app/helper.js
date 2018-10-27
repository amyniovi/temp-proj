'use strict';

 function isEmpty(val) {
    return val === undefined || val === null || val.length <= 0 ? true : false;
}

 function getCookie(name) {
    if (isEmpty(document.cookie))
        return null;
    const documentCookieArr = document.cookie.split(';');
    const nameCookieArr = documentCookieArr.filter(x => x.includes(name))[0].split('=');
    if (isEmpty(nameCookieArr))
        return null;

    const nameValue = nameCookieArr[1];

    if (isEmpty(nameValue))
        return null;
    return nameValue;
}

export {
    isEmpty,
    getCookie
};