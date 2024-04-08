document.querySelector(document).addEventListener("ready", function () {
    getClassesBySchoolId();
})
document.querySelector("#schoolId").addEventListener("change", function () {
    getClassesBySchoolId();
})
var getClassesBySchoolId = function () {
    document.querySelector.ajax({
        url: '@Url.Action("GetClassesBySchoolId", "Account")',
        type: 'GET',
        data: {
            schoolId: document.querySelector('#schoolId').val(),
        },
        success: function (data) {
            document.querySelector(data).each(
                function (index, item) {
                    document.querySelector('#classId').append('<option value="' + item.id + '">' + item.name + '</option>')
                }
            );
        }
    })
}