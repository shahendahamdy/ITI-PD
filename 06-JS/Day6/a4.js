img1 = document.getElementById("icon1");
img2 = document.getElementById("icon2");
img3 = document.getElementById("top");
var x1 = 10,
  x2 = 350,
  x3 = 380;
offst1 = 10;
offst2 = 10;
offst3 = -10;
console.log("hi");
function f1() {
  i0 = setInterval(function () {
    x1 += offst1;
    if (x1 >= 350) offst1 = -10;
    if (x1 <= 10) offst1 = 10;
    img1.style.left = x1 + "px";
  }, 100);

  i1 = setInterval(function () {
    x2 += offst2;
    if (x2 <= 10) offst2 = 10;
    if (x2 >= 350) offst2 = -10;
    img2.style.left = x2 + "px";
  }, 100);
  i2 = setInterval(function () {
    x3 += offst3;
    if (x2 <= 10) offst3 = 10;
    if (x2 >= 410) offst3 = -10;
    img3.style.top = x2 + "px";
  }, 100);
}
function f2() {
  clearInterval(i0);
  clearInterval(i1);
  clearInterval(i2);
}
f1();
var bool = true;
document.getElementById("stop").onclick = function () {
  if (bool) {
    f2();
    bool = false;
  } else {
    f1();
    bool = true;
  }
};
document.getElementById("reset").onclick = function () {
  f2();
  x1 = 10;
  x2 = 350;
  x3 = 380;
  offst1 = 10;
  offst2 = 10;
  offst3 = -10;
  f1();
};
