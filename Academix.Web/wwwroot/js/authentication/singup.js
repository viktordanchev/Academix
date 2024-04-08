const stepMenuOne = document.querySelector(".step-menu1");
const stepMenuTwo = document.querySelector(".step-menu2");

const stepOne = document.querySelector(".form-step-1");
const stepTwo = document.querySelector(".form-step-2");

const formNextBtn = document.querySelector(".btn.next");
const formBackBtn = document.querySelector(".btn.back");
const formCancelBtn = document.querySelector(".btn.cancel");
const formButtonsHtml = document.querySelector(".form-btn-wrapper.register");

const formSignUpButton = document.createElement("button");
formSignUpButton.className = "btn";
formSignUpButton.innerHTML = "Sing Up";
formSignUpButton.setAttribute("type", "submit");

formNextBtn.addEventListener("click", function (event) {
    event.preventDefault();

    stepMenuOne.classList.remove("active");
    stepMenuTwo.classList.add("active");

    stepOne.classList.remove("active");
    stepTwo.classList.add("active");

    formCancelBtn.classList.remove("active");
    formBackBtn.classList.add("active");
    formNextBtn.classList.remove("active");

    formBackBtn.addEventListener("click", function (event) {
        event.preventDefault();

        stepMenuOne.classList.add("active");
        stepMenuTwo.classList.remove("active");

        stepOne.classList.add("active");
        stepTwo.classList.remove("active");

        formCancelBtn.classList.add("active");
        formBackBtn.classList.remove("active");
        formNextBtn.classList.add("active");

        formButtonsHtml.removeChild(formSignUpButton);
    });

    formButtonsHtml.appendChild(formSignUpButton);
});
