  //  (function () {


    if (authenticate()) {
        startUp();
    } else {
        window.location = 'login.html';
    }


    function getCookie(name) {
        return 'name=amy;';
    }

    function authenticate() {
        return false;
    }


    function startUp() {
        document.write('this is the cart');
    }
//})();