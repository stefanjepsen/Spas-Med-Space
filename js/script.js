  $('.dropdown-trigger').dropdown();

  $('.dropdown-trigger').dropdown({
    hover: true, // Activate on hover
    coverTrigger: false,
  }
);


function myFunction(x) {
  if (x.matches) { // If media query matches
    $('.dropdown-trigger').dropdown({
      hover: false, // Activate on hover
      coverTrigger: false,
    }
  );
  } else {
    $('.dropdown-trigger').dropdown({
      hover: true,
      coverTrigger: false,
    }
  );
  }
}

var x = window.matchMedia("(max-width: 1200px)")
myFunction(x) // Call listener function at run time
x.addListener(myFunction) // Attach listener function on state changes

//QUIZ
