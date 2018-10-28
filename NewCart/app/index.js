'use strict';
import { getCookie } from './helper.js';

(function() {

    var checkAuth = () => {

        if (getCookie('username') !== null) {
            loadApp();
        } else {
            setTimeout(() => window.location = 'login.html', 1000);
        }
    };

    //var options = 
    //var ApiRequest = 

    checkAuth();

    function loadApp() {
        var data = fetch('').then().catch();
    }

})();

/*
 <div class="panel panel-default">
  <!-- Default panel contents -->
  <div class="panel-heading">Panel heading</div>

  <!-- Table -->
  <table class="table">
    ...
  </table>
</div>*/

//comments/improvements
//        document.cookie = "username" + "=;expires=Thu, 01 Jan 1970 00:00:00 GMT";
// add logout feature