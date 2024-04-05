document.querySelector("#roles select").addEventListener('change', function () {
    var selectedValue = this.value;
    var schools = document.getElementById("schools");
    var classes = document.getElementById("classes");
    var students = document.getElementById("students");

    if (selectedValue === "Director") {
        schools.removeAttribute("hidden");
    }
});