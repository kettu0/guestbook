const boxes = ["userMessage", "nickName", "eMail"];
const button = document.getElementById("submit");
let errorName = document.getElementById("error-name");
let errorEmail = document.getElementById("error-email");

function checkIfBoxFilled(id) {
    const content = document.getElementById(id).value;
    if (content.length === 0)
        return false;
    return true;
}


function checkAllBoxes(array) {
    let counter = 0;
    for (const element of array) {
        if (checkIfBoxFilled(element) === true) {
            counter++;
            if (counter === array.length)
                return true;
        }
    }
    return false;
}


function checkCapitals() {
    let content = document.getElementById("nickName").value;
    let contentArray = content.split(' ');

    for (const element of contentArray) {
        if (element[0] !== element[0].toUpperCase()) {
            return false;
        }
        return true;
    }
}


function checkName() {
    const content = document.getElementById("nickName").value;
    let errorMessage = "";

    if (!content.trim()) {
        errorMessage += "\nThe name cannot contain only whitespaces!\n";
    }
    if ((!isNaN(content)) || (!/^[a-z/\s/]+$/i.test(content))) {
        errorMessage += "\nThe name can only contain letters and spaces!\n";
    }

    if (content.length >= 30) {
        errorMessage += "\nName too long! It should have no more than 30 characters!\n";
    }

    if (!checkCapitals()) {
        errorMessage += "Each word should begin with a capital letter";
    }

    errorName.textContent = errorMessage;
    errorName.style.color = "#d17171";
}

function checkeMail() {
    const content = document.getElementById("eMail").value;
    let errorMessage = "";

    if (!content.trim()) {
        errorMessage += "\nThe email cannot be empty!\n";
    }
    if (!content.includes("@")) {
        errorMessage += "\nIt is not an e-mail, traveller!";
    }

    if (!content.includes(".")) {
        errorMessage += "\nIt is not an e-mail, traveller!";
    }

    if (content.length < 5) {
        errorMessage += "\nAddress too short";
    }

    errorEmail.textContent = errorMessage;
    errorEmail.style.color = "#d17171";
}

function enableButton() {
    if (checkAllBoxes(boxes)) {
        document.getElementById("submit").disabled = false;
    }

    if (!checkAllBoxes(boxes)) {
        document.getElementById("submit").disabled = true;
    }
}


function sendForm() {
    if (errorName.textContent.length === 0 && errorEmail.textContent.length === 0) {
        alert("The guestbook has been signed!");
        location.reload();
    }
}


document.addEventListener("input", enableButton);
button.addEventListener("click", checkeMail);
button.addEventListener("click", checkName);
button.addEventListener("click", sendForm);




