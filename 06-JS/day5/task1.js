var x = "http://localhost:5500/day5/task1.html";
var y = "http://localhost:5500/day5/welcome.html";

console.log(document.getElementsByTagName("input"));
console.log(document.getElementsByTagName("span"));
console.log(window.location);

if (window.location == x) {
  function fun() {
    setCookie(
      document.getElementsByTagName("input")[0].name,
      document.getElementsByTagName("input")[0].value
    );
    setCookie(
      document.getElementsByTagName("input")[1].name,
      document.getElementsByTagName("input")[1].value
    );
    setCookie(
      document.getElementsByName("gender")[0].name,
      document.getElementsByName("gender")[0].value
    );
    setCookie(
      document.getElementsByTagName("select")[0].name,
      document.getElementsByTagName("select")[0].value
    );
    setCookie("counter", "0");
    location.href = "welcome.html";
  }
}
if (window.location == y) {
  var namee = getCookie("name");
  var num = getCookieCounter();
  //etCookie("counter", num++);
  console.log(namee);
  var imgg = getCookie("gender");
  if (imgg == "male") {
    imgg = "1.jpg";
  } else imgg = "2.jpg";
  document.getElementsByTagName("span")[0].innerHTML = namee;
  document.getElementsByTagName("span")[0].style.color = getCookie("color");

  document.getElementsByTagName("img")[0].src = imgg;
  document.getElementsByTagName("span")[1].innerHTML = num;

  console.log(document.getElementsByTagName("span")[0].innerHTML);
}
