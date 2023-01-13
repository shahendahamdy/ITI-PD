var resImg, resText;
var prevI = 7;
if (location.href === "http://localhost:5500/day6/a3.html") {
  function fun(i) {
    resImg = i + ".jpg";
    console.log(prevI, i);
    if (prevI >= 0 && prevI <= 5) {
      document.getElementsByTagName("img")[prevI - 1].style.border = "none";
    }
    prevI = i;

    document.getElementsByTagName("img")[i - 1].style.border = "5px solid red";
  }
}
document.getElementById("btn1").onclick = function () {
  txt = document.getElementsByTagName("textarea")[0].value;
  console.log(txt);
  win = open("a3.1.html", "", "width=300,height=300");
  win.focus();
  win.onload = function () {
    img = win.document.createElement("img");
    img.src = "images/" + resImg;

    text = win.document.createElement("p");
    text.innerHTML = txt;
    win.document.body.appendChild(text);
    win.document.body.prepend(img);
    win.document.getElementsByTagName("img")[0].style.width = "200px";
    win.document.getElementsByTagName("img")[0].style.height = "200px";
    input = win.document.createElement("input");
    input.setAttribute("type", "button");
    input.setAttribute("value", "close");
    win.document.body.appendChild(input);
    win.document.getElementsByTagName("input")[0].onclick = function () {
      win.close();
    };

    win.console.log("hi");
  };
};

resText = console.log(resImg, resText);
