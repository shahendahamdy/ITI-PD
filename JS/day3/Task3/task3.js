var win;
//open window
function openWin() {
  win = open("child3.html", "", "width=1000,height=1000,top=0,left=0");
  win.moveTo(800, 0);
  win.focus();
}
openWin();
var i = 1;
var int = setInterval(() => {
  win.scrollBy(0, 50);
  console.log(50 * i++, win.innerHeight);
  if (i * 50 >= win.innerHeight) {
    setTimeout(() => {
      clearInterval(int);
      win.close();
    }, 1000);
  }
}, 50);
