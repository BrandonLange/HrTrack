var SetupForm = function() {

    var Initialise = function() {
    	CheckSession();
        Events();
    }

    var Events = function() {
        $("#add-item").on("click", function() {

            $("#policy-form").show();
        })

        $("#update-policy").on("click", function() {
            var policyName = $("#policy-name").val();
            var policyDesc = $("#policy-description").val();

            var html = '<li class="collection-item blue darken-4">' + policyName + '</li>';

            $(".collection").append(html);

            var policyName = $("#policy-name").val("");
            var policyDesc = $("#policy-description").val("");

            $("#policy-form").hide();
        })

        $("#attach-document").on("click", function() {
        	$("#file-upload").click();
        })
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
