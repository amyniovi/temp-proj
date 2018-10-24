
    if (getCookie('username')) {
        startUp();
    } else {
        window.location = 'login.html';
    }


    function getCookie(name) {
        return true;
    }

   

    function startUp() {
        document.write('this is the cart');
    }
