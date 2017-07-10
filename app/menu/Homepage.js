// ////////////////////////////////////////////////////////////////////////////////////////////////////
// Purpose: To controll the main page and all of its contents
// Author: Brandon Lange
// Date: 2017/07/04
// ////////////////////////////////////////////////////////////////////////////////////////////////////
var Homepage = function() {

    var Initialise = function() {
        LoadEvents();
    }

    var LoadEvents = function() {
        $("#btn_policies").on("click", function() {
            $("#main_page_content").load("policies/policies.html");
        })

        $("#btn_duties").on("click", function() {
            $("#main_page_content").load("duties/duties.html");
        })


        $("#btn_logout").on("click", function() {
            $("#main_page_content").load("index.html");
        })
    }

    return {
        init: function() {
            Initialise();
        }
    }
}()

$(document).ready(function() {
    jQuery(function() {
        Homepage.init();
    });
})
