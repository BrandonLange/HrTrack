// ////////////////////////////////////////////////////////////////////////////////////////////////////
// Purpose: To controll the main page and all of its contents
// Author: Brandon Lange
// Date: 2017/07/04
// ////////////////////////////////////////////////////////////////////////////////////////////////////
var Homepage = function() {

    var Initialise = function() {
        LoadEvents();
    }

    var goToTab = function(itemToLoad) {
        switch (itemToLoad) {
            case "COMPANYPOLICIES":
                {
                    $("#main_page_content").load("policies/company/CompanyPolicies.html");
                }
                break;
            case "GROUPPOLICIES":
                {
                    $("#main_page_content").load("policies/group/GroupPolicies.html");
                }
                break;
        }
    }

    var LoadEvents = function() {
        $("#btn_policies").on("click", function() {
            $("#main_page_content").load("policies/policies.html");
        })

        $("#btn_duties").on("click", function() {
            $("#main_page_content").load("duties/duties.html");
        })


        $("#btn_logout").on("click", function() {
            window.location.href = "../index.html";
        })

        $(".tab_item").on("click", function() {
            var itemToLoad = $(this).attr("data-target");
            goToTab(itemToLoad);
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
