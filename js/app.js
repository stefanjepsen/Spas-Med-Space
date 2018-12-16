function populate() {
    if(quiz.isEnded()) {
        showScores();
    }
    else {
        // show question
        var element = document.getElementById("question");
        element.innerHTML = quiz.getQuestionIndex().text;

        // show options
        var choices = quiz.getQuestionIndex().choices;
        for(var i = 0; i < choices.length; i++) {
            var element = document.getElementById("choice" + i);
            element.innerHTML = choices[i];
            guess("btn" + i, choices[i]);
        }

        showProgress();
    }
};

function guess(id, guess) {
    var button = document.getElementById(id);
    button.onclick = function() {
        quiz.guess(guess);
        populate();
    }
};


function showProgress() {
    var currentQuestionNumber = quiz.questionIndex + 1;
    var element = document.getElementById("progress");
    element.innerHTML = "Spørgsmål " + currentQuestionNumber + " af " + quiz.questions.length;
};

function showScores() {
    if (quiz.score >= 7) {
        var gameOverHTML = "<h4 id='result' class='center'>Tillykke, du er en superastronaut!</h4>";
        gameOverHTML += "<h4 id='score'> Du fik " + quiz.score + " ud af 8 rigtige" + "</h4>";
        gameOverHTML += "<a href='quiz.html'><button id='reset'><p>Prøv igen</p></button></a>";
      } else if (quiz.score >= 4) {
        var gameOverHTML = "<h4 id='result' class='center'>Flot! Med lidt mere træning kunne du blive en superastronaut!</h4>";
        gameOverHTML += "<h4 id='score'> Du fik " + quiz.score + " ud af 8 rigtige" + "</h4>";
        gameOverHTML += "<a href='quiz.html'><button id='reset'><p>Prøv igen</p></button></a>";
      } else {
        var gameOverHTML = "<h4 id='result' class='center'>Øv. Du skal bare øve dig, så er den der!</h4>";
        gameOverHTML += "<h4 id='score'> Du fik " + quiz.score + " ud af 8 rigtige" + "</h4>";
        gameOverHTML += "<a href='quiz.html'><button id='reset'><p>Prøv igen</p></button></a>";
    }
    var element = document.getElementById("quiz");
    element.innerHTML = gameOverHTML;
};

// create questions
var questions = [
    new Question("Hvilken planet er en dværgplanet?", ["Jupiter", "Uranus","Mars", "Pluto"], "Pluto"),
    new Question("Hvor mange planeter er der liv på?", ["6", "1", "Alle planeter", "3"], "1"),
    new Question("Hvilken planet er den største?", ["Jupiter", "Jorden","Mars", "Saturn"], "Jupiter"),
    new Question("Hvad er mælkevejen?", ["En stjerne", "En galakse", "En gade", "Et stjernebillede"], "En galakse"),
    new Question("Hvor mange planeter er der?", ["8 planeter og 5 dværgplaneter", "5 planeter og 4 dværgplaneter", "9 planeter og 0 dværgplaneter", "8 planeter og 1 dværgplanet"], "8 planeter og 5 dværgplaneter"),
    new Question("Hvilken planet er tættest på solen?", ["Neptun", "Merkur", "Jupiter", "Jorden"], "Merkur"),
    new Question("Hvilken planet har en ring omkring sig?", ["Mars", "Venus", "Saturn", "Jupiter"], "Saturn"),
    new Question("Hvor lang tid tager det Jorden at dreje en gang om sig selv?", ["1 dag", "7 dage", "365 dage", "31 dage"], "1 dag"),
];

// create quiz
var quiz = new Quiz(questions);

// display quiz
populate();

