const stepMenuOne = document.querySelector(".register-step-menu1");
const stepMenuTwo = document.querySelector(".register-step-menu2");

const stepOne = document.querySelector(".register-form-step-1");
const stepTwo = document.querySelector(".register-form-step-2");

const formSubmitBtn = document.querySelector(".register-btn.next");
const formBackBtn = document.querySelector(".register-btn.back");
const formCancelBtn = document.querySelector(".register-btn.cancel");

formSubmitBtn.addEventListener("click", function (event) {
  event.preventDefault();

  stepMenuOne.classList.remove("active");
  stepMenuTwo.classList.add("active");

  stepOne.classList.remove("active");
  stepTwo.classList.add("active");

  formCancelBtn.classList.add("active");
  formBackBtn.classList.add("active");
  formBackBtn.addEventListener("click", function (event) {
    event.preventDefault();

    stepMenuOne.classList.add("active");
    stepMenuTwo.classList.remove("active");

    stepOne.classList.add("active");
    stepTwo.classList.remove("active");

    formCancelBtn.classList.remove("active");
    formBackBtn.classList.remove("active");
    formSubmitBtn.textContent = "Next";
  });

  formSubmitBtn.textContent = "Submit";
});
