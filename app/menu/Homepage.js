// ////////////////////////////////////////////////////////////////////////////////////////////////////
// Purpose: To controll the main page and all of its contents
// Author: Brandon Lange
// Date: 2017/07/04
// ////////////////////////////////////////////////////////////////////////////////////////////////////
var Homepage = function() {

    var Initialise = function() {
        LoadEvents();
        LoadMainPage();
    }

    var LoadMainPage = function() {
        var html = "<div style='background-image: url(../assets/images/HomePage-Logo.png); background-repeat: round; background-size:cover; width: 100%; height: 50%;'></div>"

        $('#main_page_content').empty()
        $('#main_page_content').append(html)
    }

    var goToTab = function(itemToLoad) {
        switch (itemToLoad) {
            case "HOME":
                {
                    LoadMainPage();
                }
                break;
            case "COMPANYGROUP":
                {
                    $("#main_page_content").load("company/companygroup/CompanyGroup.html");
                }
                break;
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

        $('#Main_Menu > a').on('click', function() {
            $('#Main_Menu > a').removeClass('active');
            $(this).addClass('active')
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