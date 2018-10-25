function login() {
   
    var user = document.querySelector("#inputUser").value;
    document.write(user);
    if (LoginService.login(user))
     window.location = "index.html";
}



var LoginService = (function () {

   

    function setAuthCookie(user) {
        //var currentDate = new Date();
        //currentDate.setHours(currentDate.getHours() + 1);
        //document.write(currentDate.toUTCString());
        //date not set correctly here we are using the session default
        document.cookie = `username=${user};`;//expires=${currentDate.toUTCString()};
    }

    function login(user) {
        //return new Promise(function(resolve, reject) {
            
        //});
        setAuthCookie(user);
        return true;
    }

    return { login : login };

})();