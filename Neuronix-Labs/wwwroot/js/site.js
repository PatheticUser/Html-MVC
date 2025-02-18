document.getElementById("contactForm").addEventListener("submit", async (e) => {
  e.preventDefault();

  // Form validation
  const form = e.target;
  if (!form.checkValidity()) {
    e.stopPropagation();
    form.classList.add("was-validated");
    return;
  }

  // Show loading state
  const button = form.querySelector('button[type="submit"]');
  const buttonText = button.querySelector("span");
  const spinner = button.querySelector(".loading-spinner");
  button.disabled = true;
  buttonText.style.opacity = "0.5";
  spinner.style.display = "inline-block";

  try {
    // Simulate form submission
    await new Promise((resolve) => setTimeout(resolve, 1500));

    // Show success message
    document.querySelector(".success-message").style.display = "block";
    form.reset();
    form.classList.remove("was-validated");

    // Scroll to success message
    document
      .querySelector(".success-message")
      .scrollIntoView({ behavior: "smooth", block: "center" });
  } catch (error) {
    alert("An error occurred. Please try again later.");
  } finally {
    // Reset button state
    button.disabled = false;
    buttonText.style.opacity = "1";
    spinner.style.display = "none";
  }
});

// Real-time email validation
document.getElementById("email").addEventListener("input", function () {
  const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  if (this.value && !emailRegex.test(this.value)) {
    this.classList.add("is-invalid");
  } else {
    this.classList.remove("is-invalid");
  }
});
