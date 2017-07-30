// ////////////////////////////////////////////////////////////////////////////////////////////////////
// Purpose: To be able to view, add, modify, delete company groups 
// ////////////////////////////////////////////////////////////////////////////////////////////////////

var CompanyGroupForm = function() {

    var Initialise = function() {
        var callback_load_company_groups = function(data) {
            $(data.CompanyGroupItemList).each(function(idx, el) {
                Add_Company_Group_To_List(el);
            })
        }

        Load_Company_Groups(callback_load_company_groups);

        Register_Events();
    }

    var Register_Events = function() {
        $("#btn_addCompanyGroup").on("click", function() {
            var callback_add_company_group = function(data) {
            	Add_Company_Group_To_List(data.CompanyGroupItemList[0]);
            	$("#validation_GroupName").val("");
            }

            Add_Company_Group(callback_add_company_group)
        });
    }

    var Load_Company_Groups = function(callback) {

        CompanyGroupRequest = {
            "Action": 0
        }

        $.ajax({
            type: "POST",
            url: "http://localhost/HrTrackService/CompanyGroup/ProcessCompanyGroup?format=JSON",
            dataType: "JSON",
            data: JSON.stringify(CompanyGroupRequest),
            contentType: "application/json; charset=utf-8",
            success: function(data) {
                callback(data);
            },
            error: function() {
                alert("failed");
            }
        });
    }

    var Add_Company_Group_To_List = function(data) {
    	var html = '<option value="' + data.CompanyGroupID + '">' + data.GroupName + '</option>';

        $("#dropdown_items").append(html)
    }

    var Add_Company_Group = function(callback) {
        var groupName = $("#validation_GroupName").val();

        AddCompanyGroupRequest = {
            "Action": 2,
            "CompanyGroupItem": {
                "GroupName": groupName
            }
        }

        $.ajax({
            type: "POST",
            url: "http://localhost/HrTrackService/CompanyGroup/ProcessCompanyGroup?format=JSON",
            dataType: "JSON",
            data: JSON.stringify(AddCompanyGroupRequest),
            contentType: "application/json; charset=utf-8",
            success: function(data) {
            	console.log(data);
                if (data.Success) {
                    callback(data);
                }
                else {
                	alert("Oops something went wrong, please try again");
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
        CompanyGroupForm.init();
    })
})