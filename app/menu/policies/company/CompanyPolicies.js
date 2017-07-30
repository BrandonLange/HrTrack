// ////////////////////////////////////////////////////////////////////////////////////////////////////
// Purpose: To control company policies within the system
// Author: Brando Lange
// Date: 2017/07/12
// ////////////////////////////////////////////////////////////////////////////////////////////////////
var CompanyPolicyForm = function() {

    var _lastSelected;

    var Initialise = function() {
        var callback_load_group_policies = function(data) {
            $(data.GroupPolicyItemList).each(function(idx, el) {
                Add_Group_Policy_To_List(el);
            })

            RegisterEvents();
            InitialiseValidation();
        }

        Load_Group_Policies(callback_load_group_policies);
    }

    var Add_Group_Policy_To_List = function(data) {
        var html = '<div class="attached ui segment company-policy-list-item" data-internalid="' + data.GroupPolicyID + '">' + data.Policy + '</div>';

        $("#GroupPolicyItemHolder").append(html)
    }
    // ////////////////////////////////////////////////////////////////////////////////////////////////////
    // Validation
    // ////////////////////////////////////////////////////////////////////////////////////////////////////
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
        if (bSuccess) {
            $('.ui.form').form("validate form");
            return true;
        } else {
            $('.ui.form').form("validate form");
            return false;
        }
    }

    // ////////////////////////////////////////////////////////////////////////////////////////////////////
    // Events
    // ////////////////////////////////////////////////////////////////////////////////////////////////////
    var RegisterEvents = function() {
        $("#btn_add_company_policy").on("click", CreateCompanyPolicy);

        $(".company-policy-list-item").on("click", function() {
            var $this = this;

            $(_lastSelected).removeClass("active");
            $(_lastSelected).addClass("company-policy-list-item");
            _lastSelected = $this;
            $($this).removeClass("company-policy-list-item");
            $($this).addClass("active");
        })
    }

    // ////////////////////////////////////////////////////////////////////////////////////////////////////
    // General Crud Functions
    // ////////////////////////////////////////////////////////////////////////////////////////////////////
    // Get All
    var Load_Group_Policies = function(callback) {
        GroupPolicyRequest = {
            "Action": 0
        }

        $.ajax({
            type: "POST",
            url: "http://localhost/HrTrackService/GroupPolicy/ProcessGroupPolicy?format=JSON",
            dataType: "JSON",
            data: JSON.stringify(GroupPolicyRequest),
            contentType: "application/json; charset=utf-8",
            success: function(data) {
                callback(data);
            },
            error: function() {
                alert("failed");
            }
        });
    }

    // Add
    var CreateCompanyPolicy = function() {
        $('.ui.modal').modal({
            closable: false,
            onApprove: function() {
                var bSuccess = CheckValidation();
                if (bSuccess) {
                    var callback_add_group_policy = function(data) {
                        Add_Group_Policy_To_List(data.GroupPolicyItemList[0])
                        $("#validation_company_policy_name").val("");
                        $("#validation_company_policy_description").val("");
                        return true;
                    }

                    var PolicyName = $("#validation_company_policy_name").val();
                    var PolicyDescription = $("#validation_company_policy_description").val();

                    var AddGroupPolicyRequest = {
                        "Action": 2,
                        "GroupPoliciesItem": {
                            "CompanyGroupID": 1,
                            "Description": PolicyDescription,
                            "DocumentID": 0,
                            "DocumentRef": "",
                            "LastUpdated": "\/Date(928142400000+0200)\/",
                            "LastUpdatedBy": 1,
                            "ParentID": 1,
                            "Policy": PolicyName,
                            "PolicyLevel": 1,
                            "Rank": 1
                        }
                    }

                    Add_Group_Policy(AddGroupPolicyRequest, callback_add_group_policy);
                }
            }
        }).modal('show');
    }

    var Add_Group_Policy = function(AddGroupPolicyRequest, callback) {

        $.ajax({
            type: "POST",
            url: "http://localhost/HrTrackService/GroupPolicy/ProcessGroupPolicy?format=JSON",
            dataType: "JSON",
            data: JSON.stringify(AddGroupPolicyRequest),
            contentType: "application/json; charset=utf-8",
            success: function(data) {
                if (data.Success) {
                    callback(data);
                } else {
                    alert("Oops! Something went wrong. Please try again.")
                }
            },
            error: function() {
                alert("failed");
            }
        });
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