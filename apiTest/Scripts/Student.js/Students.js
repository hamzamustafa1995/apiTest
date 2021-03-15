$(document).ready(function () {
	GetAllUsers();
});
function GetAllUsers() {
	$.ajax({
		type: "POST",
		dataType: "json",
		url: "StudentHandler.ashx",
		headers: {
			"Action": "GetAllUsers",
		},

		success: function (data) {
			var datatableVariable = $('#UsersData').DataTable({

				responsive: true,
				bPaginate: true,
				bFilter: true,
				bInfo: true,
				data: data,
				columns: [
					{ 'data': 'StudentName' },
					{ 'data': 'StudentAge' },

					{
						"render": function (d, t, user) {
							var $dropDown = $("<div>").attr({ "class": "dropdown" }).append(
								$("<i>").attr({ "class": "fa fa-ellipsis-h  dropdown-toggle", "data-toggle": "dropdown" }),
								$("<div>").attr({ "class": "dropdown-menu" }).append(
									$("<a>").attr({ "onclick": "showUpdateUserStatus(" + user.StudentAge + "," + 1 + ")", "data-toggle": "modal", "data-target": "#myModal", "class": "pointer" }).html("Suspend User"),
									$("<a>").attr({ "onclick": "showUpdateUserStatus(" + user.StudentAge + "," + 2 + ")", "data-toggle": "modal", "data-target": "#myModal", "class": "pointer" }).html("Delete User"),
								)
							);
							return $dropDown.prop("outerHTML");
						},
					}
				],
			});

		}

	});

}