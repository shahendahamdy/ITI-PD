var win,
  x = 5,
  y = 5;
intervaal;
//open window
function openWin() {
  win = open("child1.html", "", "width=50,height=50");
  win.moveTo(0, 0);
  win.focus();
}
//close window
function closeWin() {
  win.close();
}
//move window
function moveWin() {
  intervaal = setInterval(() => {
    win.resizeTo(50, 50);
    win.moveBy(x, y);
    win.focus();

    if (win.screenY >= 685) {
      (x = -x), (y = -y);
    }
    if (win.screenY <= 0 || win.screenX <= 0) {
      x = -x;
      y = -y;
    }
  }, 50);
}
function stopWin() {
  clearInterval(intervaal);
}
