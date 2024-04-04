const rolesSelect = document.querySelector(".roles select");
const schoolsSelect = document.querySelector(".schools select");

if (rolesSelect.value == 1 || rolesSelect.value == "Student") {
    rolesSelect.addEventListener("click", function () {
        document.getElementsByClassName(".schools")[0].ariaHidden = false;
    });
}