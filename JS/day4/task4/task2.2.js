var x = 1,
  y = 2,
  i = 1,
  intervaal,
  flag = 0;

function go() {
  if (flag == 0) {
    intervaal = setInterval(function () {
      // console.log(x + " " + y);
      if (x == 6) x = 1;
      if (y == 6) y = 1;
      document.getElementById(x).src = "marble1.jpg";
      document.getElementById(y).src = "marble3.jpg";
      x++;
      y++;
    }, 300);
  }
}
function stop() {
  clearInterval(intervaal);
}
go();
