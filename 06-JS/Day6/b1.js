onload = function () {
  document.getElementsByTagName("input")[0].onkeydown = function () {
    console.log(event.keyCode);
    console.log(event.code);
    document.getElementsByTagName("p")[0].innerHTML = event.code;
    document.getElementsByTagName("p")[1].innerHTML = event.keyCode;
  };
};
