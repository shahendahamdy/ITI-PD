var win,
  i = 0;
var arr = "hello this is child window ..";
//open window
function openWin() {
  win = open("child2.html", "", "width=200,height=200");
  win.moveTo(800, 0);
  win.focus();
}
openWin();
var int = setInterval(() => {
  if (i === arr.length - 1) clearInterval(int);

  win.document.write(arr[i]);
  i++;
}, 20);

//close window
function closeWin() {
  win.close();
}
setTimeout(closeWin, 5000);
