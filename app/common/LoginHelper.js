if (LOGINHELPER === undefined) {
    var LOGINHELPER = {};
}

LOGINHELPER.Login = function(username, password) {
    if (username == "1" && password == "1") {
        return "SUCCESS";
    } else {
        return "Failed to login";
    }
}
