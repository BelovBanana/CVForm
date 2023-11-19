function addNewInput() {
    const input = document.createElement("input");
    input.setAttribute('type', 'text');
    input.className = 'cv-input__workperiod';

    const parent = document.querySelector(".cv-form__workperiods");
    parent.appendChild(input);
}

function confirmWorkPeriods() {
    const workperiods = document.querySelectorAll(".cv-input__workperiod");
    let workPeriodString = '';
    for (var workperiod of workperiods) {
        workPeriodString += workperiod.value + "[;]";
    }

    const hiddenInputWorkPeriod = document.querySelector(".cv-input__workperiods");
    hiddenInputWorkPeriod.value = workPeriodString;

    console.log(workPeriodString);
}
