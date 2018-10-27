'use strict';

import { isEmpty } from './helper.js';

(function () {

    var loginService = (function () {

        function setAuthCookie() {
            var user = document.querySelector("#inputUser").value;
            if (isEmpty(user))
                return;
            // we are using the session default "expires" 
            document.cookie = `username=${user};`;
        }

        return { login: setAuthCookie };

    })();

    var $frm = document.querySelector('#loginFrm');

    $frm.onsubmit = authenticate;

    function authenticate(e) {
        e.preventDefault();
        loginService.login();
        window.location.replace("index.html");
        return false;
    }
})();
