document.querySelector("#roles select").addEventListener('change', function () {
    var selectedValue = this.value;
    var classes = document.getElementById("classes");
    var students = document.getElementById("students");

    if (selectedValue === "Student") {
        students.setAttribute("hidden", true);
        classes.removeAttribute("hidden");
    } else if (selectedValue === "Parent") {
        classes.removeAttribute("hidden");
        students.removeAttribute("hidden");
    } else { 
        classes.setAttribute("hidden", true);
        students.setAttribute("hidden", true);
    }
});