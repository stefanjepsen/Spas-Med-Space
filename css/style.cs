@import url("https://fonts.googleapis.com/css?family=Roboto");
@import url("https://fonts.googleapis.com/css?family=Handlee");
* {
  box-sizing: border-box;
}

body {
  background-image: url("../img/background.png");
  background-size: 60%;
  font-family: "Roboto", sans-serif !important;
  z-index: -1;
  display: flex !important;
  min-height: 100vh !important;
  flex-direction: column;
  color: white;
  cursor: url(../img/cursor.cur), auto;
}

main {
  flex: 1 0 auto;
}

header {
  height: 150px;
}

#logo {
  position: absolute;
  top: 20px;
  left: 20px;
}

a.dropdown-trigger.btn {
  background-color: rgba(255, 255, 255, 0) !important;
  letter-spacing: 0 !important;
  text-transform: none !important;
  box-shadow: none !important;
  margin: 0 !important;
}

#dropdown {
  background-color: rgba(255, 242, 0, 0.829);
  overflow-y: visible;
}

#dropdown li {
  margin: 0 !important;
  padding: 0 !important;
  font-size: 10px !important;
}

#dropdown li:hover {
  background-color: #fff200;
}

nav ul a {
  -webkit-transition: background-color 0.3s;
  transition: background-color 0.3s;
  display: block;
  cursor: pointer;
  font-size: 3em !important;
  font-family: "Handlee", cursive !important;
  color: #fff !important;
}

#spil {
  color: rgba(255, 255, 255, 0.315) !important;
}

#spil:hover {
  color: white !important;
}

nav ul li {
  margin-top: 30px;
  color: #fff200 !important;
}

#nav-mobile {
  margin: auto !important;
  display: inline-block !important;
}

main {
  flex: 1 0 auto;
}

h3 {
  font-family: "Handlee", cursive !important;
  color: #fff200 !important;
  text-align: center;
  margin: 0 !important;
  text-transform: uppercase;
  font-size: 2em !important;
}

#text-box {
  width: 100% !important;
  max-width: 100% !important;
  height: 400px;
  background-color: rgba(255, 255, 255, 0.514);
  margin: 50px 0;
}

nav ul a {
  -webkit-transition: background-color 0.3s;
  transition: background-color 0.3s;
  display: block;
  cursor: pointer;
  font-size: 3em !important;
  font-family: "Handlee", cursive !important;
  color: #fff !important;
}

nav ul li {
  margin-top: 30px;
  color: #fff200 !important;
}

#nav-mobile {
  margin: auto !important;
  display: inline-block !important;
}

#outside-solar-syst {
  position: relative;
  height: 800px;
}

.modal-content {
  color: black !important;
}

.solar-syst div {
  top: 50%;
  left: 50%;
  position: absolute;
  z-index: 999;
}

.neptune {
  height: 130px;
  width: 130px;
  background-image: url("../img/neptun.png");
  background-size: 100%;
  background-repeat: no-repeat;
  margin-top: -15px;
  margin-left: -15px;
  top: 19% !important;
  left: 5% !important;
  animation: neptune linear infinite 15s;
}

.jupiter {
  height: 200px;
  width: 200px;
  background-image: url("../img/jupiter.png");
  background-size: 100%;
  background-repeat: no-repeat;
  margin-top: -20px;
  margin-left: -20px;
  top: 71% !important;
  left: 9% !important;
  animation: jupiter linear infinite 19s;
}

.earth {
  height: 93px;
  width: 90px;
  background-image: url("../img/earth.png");
  background-size: 100%;
  background-repeat: no-repeat;
  margin-top: -10px;
  margin-left: -10px;
  top: 10% !important;
  left: 37% !important;
  animation: orbit1 linear infinite alternate both 15s;
}

.venus {
  height: 80px;
  width: 80px;
  background-image: url("../img/venus.png");
  background-size: 100%;
  background-repeat: no-repeat;
  margin-top: -10px;
  margin-left: -10px;
  top: 49% !important;
  left: 14% !important;
  animation: slide-tr 14s cubic-bezier(0.47, -4, 0.745, 0.115) infinite alternate-reverse both;
}

.sun {
  height: 320px;
  width: 320px;
  background-image: url("../img/sun.png");
  background-size: 100%;
  background-repeat: no-repeat;
  margin-top: -160px !important;
  margin-left: -160px !important;
  top: 50% !important;
  left: 50% !important;
  animation: spin 45s linear infinite;
}

.mercury {
  height: 70px;
  width: 70px;
  background-image: url("../img/merkur.png");
  margin-top: -8px;
  margin-left: -8px;
  background-size: 100%;
  background-repeat: no-repeat;
  top: 31% !important;
  left: 74% !important;
  animation: mercury linear infinite 20s;
}

.mars {
  height: 75px;
  width: 75px;
  background-image: url("../img/mars.png");
  background-size: 100%;
  background-repeat: no-repeat;
  margin-top: -10px;
  margin-left: -10px;
  top: 83% !important;
  left: 58% !important;
  animation: mars linear infinite alternate-reverse 26s;
}

.saturn {
  height: 110px;
  width: 225px;
  background-image: url("../img/saturn.png");
  background-size: 100%;
  background-repeat: no-repeat;
  margin-top: -15px;
  margin-left: -15px;
  top: 5% !important;
  left: 68% !important;
  animation: saturn 13s linear infinite;
}

.uranus {
  height: 120px;
  width: 120px;
  background-image: url("../img/uranus.png");
  background-size: 100%;
  background-repeat: no-repeat;
  margin-top: -15px;
  margin-left: -15px;
  top: 71% !important;
  left: 77% !important;
  animation: slide 2s linear infinite alternate-reverse both;
}

.pluto {
  height: 45px;
  width: 45px;
  background-image: url("../img/pluto.png");
  background-size: 100%;
  background-repeat: no-repeat;
  margin-top: -8px;
  margin-left: -8px;
  top: 50% !important;
  left: 90% !important;
  animation: slide 2s linear infinite alternate both;
}

.rocket-man {
  height: 80px;
  width: 80px;
  background-image: url("../img/space-man.png");
  background-size: 100%;
  background-repeat: no-repeat;
  margin-top: -8px;
  margin-left: -8px;
  top: 125% !important;
  left: 0% !important;
  opacity: 0;
  animation: rocket-entrance 12s 1s linear;
}

.rocket-man2 {
  opacity: 0;
  height: 85px;
  width: 85px;
  background-image: url("../img/space-man.png");
  background-size: 100%;
  background-repeat: no-repeat;
  margin-left: 79%;
  z-index: 9999;
  top: 14%;
  position: absolute;
  animation: rocket-man-static linear alternate both infinite 3s 13s;
}

.waves-effect.waves-light.btn.modal-trigger {
  position: absolute;
  width: 200px;
  height: 75px;
  text-align: center;
  line-height: 75px;
  background-color: #fff200;
  border: 2px solid black;
  color: black;
  -webkit-border-radius: 30px;
  -moz-border-radius: 30px;
  left: 65%;
  opacity: 0;
  top: 14%;
  z-index: 1;
  animation: rocket-man-static linear alternate both infinite 3s 13s;
}

@keyframes rocket-man-static {
  0% {
    opacity: !important;
    transform: rotate(-4deg) scaleX(1.1) scaleY(1.1);
  }
  10% {
    opacity: 1;
    transform: rotate(-3deg) scaleX(0.8) scaleY(0.8);
  }
  20% {
    opacity: 1;
    transform: rotate(-3deg) scaleX(0.8) scaleY(0.8);
  }
  30% {
    opacity: 1;
    transform: rotate(10deg) scaleX(1.2) scaleY(1.2);
  }
  40% {
    opacity: 1;
    transform: rotate(-3deg) scaleX(1.2) scaleY(1.2);
  }
  50% {
    opacity: 1;
    transform: rotate(10deg) scaleX(1.2) scaleY(1.2);
  }
  60% {
    opacity: 1;
    transform: rotate(-3deg) scaleX(1.2) scaleY(1.2);
  }
  70% {
    opacity: 1;
    transform: rotate(10deg) scaleX(1.2) scaleY(1.2);
  }
  80% {
    opacity: 1;
    transform: rotate(-3deg) scaleX(1.2) scaleY(1.2);
  }
  90% {
    opacity: 1;
    transform: rotate(10deg) scaleX(1.2) scaleY(1.2);
  }
  100% {
    opacity: 1;
    transform: rotate(-2deg) scaleX(1.2) scaleY(1.2);
  }
}
@keyframes rocket-entrance {
  0% {
    transform: translate(0px, 0px);
  }
  10% {
    opacity: 1;
    transform: translate(250px, -250px);
  }
  20% {
    opacity: 1;
    transform: translate(550px, -500px);
  }
  30% {
    opacity: 1;
    transform: translate(500px, -220px);
  }
  40% {
    opacity: 1;
    transform: translate(100px, -1000px);
  }
  50% {
    opacity: 1;
    transform: translate(1300px, -700px);
  }
  60% {
    opacity: 1;
    transform: translate(110px, -1000px);
  }
  80% {
    opacity: 1;
    transform: translate(1150px, -1050px);
  }
  100% {
    opacity: 0;
    transform: translate(1150px, -1050px);
  }
}
@keyframes rocket-entrance-large {
  0% {
    transform: translate(0px, 0px);
  }
  10% {
    opacity: 1;
    transform: translate(250px, -250px);
  }
  20% {
    opacity: 1;
    transform: translate(550px, -500px);
  }
  30% {
    opacity: 1;
    transform: translate(500px, -90px);
  }
  40% {
    opacity: 1;
    transform: translate(160px, -90px);
  }
  50% {
    opacity: 1;
    transform: translate(1300px, -700px);
  }
  60% {
    opacity: 1;
    transform: translate(-50px, -880px);
  }
  80% {
    opacity: 1;
    transform: translate(1350px, -790px);
  }
  100% {
    opacity: 0;
    transform: translate(1500px, -750px);
  }
}
@keyframes rocket-entrance-tablet {
  0% {
    opacity: 1;
    transform: translate(0px, 0px);
  }
  10% {
    opacity: 1;
    transform: translate(250px, -475px);
  }
  20% {
    opacity: 1;
    transform: translate(250px, 0px);
  }
  30% {
    opacity: 1;
    transform: translate(0px, -900px);
  }
  40% {
    opacity: 1;
    transform: translate(600px, -200px);
  }
  50% {
    opacity: 1;
    transform: translate(250px, -800px);
  }
  80% {
    opacity: 1;
    transform: translate(550px, -800px);
  }
  100% {
    opacity: 0;
    transform: translate(550px, -800px);
  }
}
@keyframes mars {
  0% {
    transform: translate(106px, -52px);
  }
  21% {
    transform: translate(148px, -167px);
  }
  40% {
    transform: translate(5px, -179px);
  }
  50% {
    transform: translate(-134px, -80px);
  }
  60% {
    transform: translate(-102px, 51px);
  }
  80% {
    transform: translate(30px, 29px);
  }
  99% {
    transform: translate(114px, -51px);
  }
  100% {
    transform: translate(108px, -50px);
  }
}
@keyframes orbit1 {
  0% {
    transform: translate(-56px, -56px);
  }
  20% {
    transform: translate(-75px, -31px);
  }
  40% {
    transform: translate(-130px, 96px);
  }
  61% {
    transform: translate(-95px, 21px);
  }
  70% {
    transform: translate(-50px, 12px);
  }
  100% {
    transform: translate(-156px, -60px);
  }
}
@keyframes orbit2 {
  0% {
    transform: translate(-126px, 131px);
  }
  25% {
    transform: translate(82px, 283px);
  }
  51% {
    transform: translate(284px, 31px);
  }
  75% {
    transform: translate(92px, -21px);
  }
  88% {
    transform: translate(1px, -1px);
  }
  100% {
    transform: translate(-126px, 131px);
  }
}
@keyframes jupiter-tablet {
  0% {
    transform: translate(-100px, 121px);
  }
  51% {
    transform: translate(114px, 231px);
  }
  75% {
    transform: translate(92px, -21px);
  }
  100% {
    transform: translate(-126px, 131px);
  }
}
@keyframes jupiter {
  0% {
    transform: translate(20px, 20px);
  }
  51% {
    transform: translate(114px, 131px);
  }
  75% {
    transform: translate(92px, -21px);
  }
  100% {
    transform: translate(20px, 20px);
  }
}
@keyframes mercury {
  0% {
    transform: translate(-100px, 220px);
  }
  25% {
    transform: translate(-50px, 50px);
  }
  51% {
    transform: translate(0px, 100px);
  }
  75% {
    transform: translate(150px, 50px);
  }
  100% {
    transform: translate(-100px, 220px);
  }
}
@keyframes mercury-tablet {
  0% {
    transform: translate(80px, 50px);
  }
  25% {
    transform: translate(100px, -50px);
  }
  51% {
    transform: translate(50px, -70px);
  }
  75% {
    transform: translate(-80px, -40px);
  }
  100% {
    transform: translate(80px, 50px);
  }
}
@keyframes slide {
  0% {
    transform: translateY(0) translateX(0);
  }
  100% {
    transform: translateY(-30px) translateX(70%);
  }
}
@keyframes spin {
  from {
    transform: rotate(0deg);
  }
  to {
    transform: rotate(365deg);
  }
}
@-webkit-keyframes slide-tl {
  0% {
    -webkit-transform: translateY(0) translateX(0);
    transform: translateY(0) translateX(0);
  }
  100% {
    -webkit-transform: translateY(-100px) translateX(-100px);
    transform: translateY(-100px) translateX(-100px);
  }
}
@keyframes slide-tl {
  0% {
    -webkit-transform: translateY(0) translateX(0);
    transform: translateY(0) translateX(0);
  }
  100% {
    -webkit-transform: translateY(-100px) translateX(-100px);
    transform: translateY(-100px) translateX(-100px);
  }
}
@keyframes slide-tr {
  0% {
    transform: translateY(0) translateX(0);
  }
  100% {
    transform: translateY(-100px) translateX(100px);
  }
}
@keyframes saturn {
  0% {
    transform: translate(0px, 125px);
  }
  25% {
    transform: translate(-165px, 61px);
  }
  50% {
    transform: translate(-170px, 89px);
  }
  75% {
    transform: translate(-75px, 89px);
  }
  100% {
    transform: translate(0px, 125px);
  }
}
@keyframes neptune {
  0% {
    transform: translate(0px, 0px);
  }
  25% {
    transform: translate(190px, -61px);
  }
  50% {
    transform: translate(220px, 89px);
  }
  75% {
    transform: translate(75px, 45px);
  }
  100% {
    transform: translate(0px, 0px);
  }
}
@keyframes neptune-tablet {
  0% {
    transform: translate(0px, 0px);
  }
  25% {
    transform: translate(-90px, -61px);
  }
  50% {
    transform: translate(-180px, -21px);
  }
  75% {
    transform: translate(-120px, -40px);
  }
  100% {
    transform: translate(0px, 0px);
  }
}
.page-footer {
  background-color: #0000 !important;
  width: 100%;
  height: auto;
  background-image: url("../img/moon2.png");
  background-size: 100%;
  background-repeat: no-repeat;
  position: static;
  bottom: 0;
  padding: 0 !important;
}

.infobox {
  margin-top: -10px !important;
  display: flex !important;
}

.black-text1 {
  margin: 1rem !important;
  color: black;
}

#footer-content {
  margin-bottom: -30%;
}
#footer-content img {
  height: 50px !important;
  width: auto;
}

@media only screen and (min-width: 0px) {
  * {
    font-size: 14px;
  }
}
@media only screen and (max-width: 399px) {
  .page-footer {
    height: 100px !important;
  }

  #footer-content img {
    height: 1em;
    width: auto;
    margin-bottom: -10%;
  }
}
@media only screen and (min-width: 400px) {
  .page-footer {
    height: 130px !important;
  }

  #footer-content img {
    height: 1.5em;
    width: auto;
  }

  #logo {
    height: 80px !important;
    width: 80px !important;
  }
}
@media only screen and (max-width: 490px) {
  nav ul li a {
    font-size: 1.5em !important;
  }

  nav ul li {
    margin-top: 15px;
  }

  #logo {
    height: 50px !important;
    width: 50px !important;
  }

  .pluto {
    height: 35.5px;
    width: 35.5px;
    margin-top: -4px;
    margin-left: -4px;
  }

  .waves-effect.waves-light.btn.modal-trigger {
    width: 120px !important;
    height: 50px !important;
    line-height: 50px !important;
    left: 50% !important;
    top: 15%;
    z-index: 2;
  }
}
@media only screen and (max-width: 600px) {
  nav ul li a {
    font-size: 1em !important;
    padding: 0 10px !important;
  }

  #divider {
    padding: 0 !important;
  }

  nav ul li {
    margin-top: 15px;
  }

  #logo {
    height: 40px !important;
    width: 40px !important;
  }

  .black-text1 {
    margin-top: 5em !important;
  }

  #footer-content img {
    height: 1.5em;
    width: auto;
    margin-top: 3.5em !important;
  }
}
@media only screen and (min-width: 601px) {
  #logo {
    height: 80px !important;
    width: 80px !important;
  }
}
@media only screen and (max-width: 768px) {
  .neptune {
    height: 65px;
    width: 65px;
    margin-top: 30px;
    margin-left: 134.5px;
    animation: neptune-tablet linear infinite 15s;
  }

  .jupiter {
    height: 100px;
    width: 100px;
    margin-top: -220px;
    margin-left: 95px;
    animation: jupiter-tablet 29s linear infinite alternate;
  }

  .earth {
    height: 46.5px;
    width: 45px;
    margin-top: -5px;
    margin-left: -5px;
  }

  .venus {
    height: 40px;
    width: 40px;
    margin-top: -185px;
    margin-left: 115px;
  }

  .sun {
    height: 160px;
    width: 160px;
    margin-top: -200px !important;
    margin-left: -80px !important;
  }

  .mercury {
    height: 55px;
    width: 55px;
    margin-top: -4px;
    margin-left: -4px;
    top: 31% !important;
    left: 74% !important;
    animation: mercury-tablet linear infinite alternate-reverse 14s;
  }

  .mars {
    height: 37.5px;
    width: 37.5px;
    margin-top: -5px;
    margin-left: -5px;
    top: 67% !important;
    left: 62% !important;
  }

  .saturn {
    height: 55px;
    width: 112.5px;
    margin-top: -7.5px;
    margin-left: -7.5px;
  }

  .uranus {
    height: 60px;
    width: 60px;
    margin-top: -7.5px;
    margin-left: -7.5px;
  }

  .pluto {
    height: 35.5px;
    width: 35.5px;
    margin-top: -4px;
    margin-left: -4px;
  }

  .rocket-man {
    height: 80px;
    width: 80px;
    background-image: url("../img/space-man.png");
    margin-top: -8px;
    margin-left: -8px;
    top: 100% !important;
    left: 10% !important;
    animation: rocket-entrance-tablet 12s 1s linear;
    opacity: 0;
  }

  .rocket-man2 {
    opacity: 0;
    height: 55px;
    width: 55px;
    top: 14.5%;
    z-index: 1;
  }

  .waves-effect.waves-light.btn.modal-trigger {
    width: 120px;
    height: 50px;
    line-height: 50px;
    left: 57%;
    top: 15%;
    z-index: 2;
  }
}
@media only screen and (min-width: 768px) {
  .page-footer {
    height: 180px !important;
  }

  #footer-content img {
    height: 2.5em;
    width: auto;
  }

  .black-text1 {
    font-size: 1.5em !important;
  }
}
@media only screen and (max-width: 899px) {
  nav ul a {
    font-size: 2.3em !important;
  }

  #divider {
    padding: 0 5px;
  }
}
@media only screen and (min-width: 900px) {
  .page-footer {
    height: 250px !important;
  }

  #footer-content {
    padding-top: 90px;
  }

  #footer-content img {
    height: 4em;
    width: auto;
  }

  #logo {
    height: 110px !important;
    width: 110px !important;
  }
}
@media only screen and (min-width: 1300px) {
  .page-footer {
    height: 300px !important;
  }

  #footer-content img {
    height: 5em;
    width: auto;
    margin-bottom: 10%;
  }

  .infobox {
    font-size: 14px !important;
  }

  .rocket-man {
    height: 80px;
    width: 80px;
    background-image: url("../img/space-man.png");
    margin-top: -8px;
    margin-left: -8px;
    top: 100% !important;
    left: 10% !important;
    animation: rocket-entrance-large 12s 1s linear;
    opacity: 0;
  }
}
@media only screen and (max-width: 1440px) {
  .waves-effect.waves-light.btn.modal-trigger {
    width: 170px;
    height: 50px;
    line-height: 50px;
    left: 62%;
    z-index: 2;
  }

  .rocket-man2 {
    opacity: 0;
    height: 60px;
    width: 60px;
    top: 14.5%;
    z-index: 1;
  }
}
@media only screen and (min-width: 1700px) {
  .page-footer {
    height: 300px !important;
  }

  #footer-content img {
    height: 6em;
    width: auto;
  }
}

/*# sourceMappingURL=style.cs.map */
