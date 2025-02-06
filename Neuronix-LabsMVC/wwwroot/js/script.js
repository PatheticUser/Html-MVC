var animation = lottie.loadAnimation({
  container: document.getElementById("lottie-animation"), // the DOM element to contain the animation
  renderer: "svg", // render the animation as SVG
  loop: true, // set to true to make the animation loop
  autoplay: true, // set to true to autoplay the animation
  path: "images/Animation - 1738049438776.json", // URL to the Lottie JSON file (replace this with your own URL or file path)
});

// Show the loader for 1000ms and then display the website content
window.addEventListener("load", function () {
  setTimeout(function () {
    // Hide the loading animation
    document.querySelector(".loading-container").style.display = "none";

    // Show the website content
    document.body.style.display = "block";
  }, 1800); // 1000 milliseconds (1 second)
});
