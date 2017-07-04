var SetupForm = function() {

    var Initialise = function() {
        Events();
    }

    var Events = function() {
    	$("#btn_login").on("click", function() {
    		var username = $("#txt_username").val();
    		var password = $("#txt_password").val();
    		login(username, password);
    	})
    }

    var login = function(username, password) {
    	if(username == "1" && password == "1") {
    		window.location.href = "menu/Homepage.html";
    	}
    	else {
    		alert("Failed to login");
    	}
    }

    return {
        init: function() {
            Initialise();
        }
    }
}();

$(document).ready(function() {
    jQuery(function() {
        SetupForm.init();
    })
})
