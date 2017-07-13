// ////////////////////////////////////////////////////////////////////////////////////////////////////
// Purpose: To control company policies within the system
// Author: Brando Lange
// Date: 2017/07/12
// ////////////////////////////////////////////////////////////////////////////////////////////////////
var CompanyPolicyForm = function() {

    var Initialise = function() {
        InitialiseValidation();
        RegisterEvents();
    }

    var InitialiseValidation = function() {
        $('.ui.form')
            .form({
                fields: {
                    validation_company_policy_name: {
                        identifier: 'validation_company_policy_name',
                        rules: [{
                            type: 'empty'
                        }]
                    },
                    validation_company_policy_description: {
                        identifier: 'validation_company_policy_description',
                        rules: [{
                            type: 'empty'
                        }]
                    },
                }
            });
    }

    var CheckValidation = function() {
        var bSuccess = $('.ui.form').form("is valid");
        console.log(bSuccess);
        if (bSuccess) {
            $('.ui.form').form("validate form");
            return true;
        } else {
            $('.ui.form').form("validate form");
            return false;
        }
    }

    var RegisterEvents = function() {
        $("#btn_add_company_policy").on("click", CreateCompanyPolicy);
    }

    var CreateCompanyPolicy = function() {
        $('.ui.modal').modal({
            closable: false,
            onApprove: function() {
                var bSuccess = CheckValidation();
                return bSuccess;
            }
        }).modal('show');
    }

    return {
        init: function() {
            Initialise();
        }
    }
}();

$(document).ready(function() {
    jQuery(function() {
        CompanyPolicyForm.init();
    })
})
