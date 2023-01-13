var arr = ["1.gif", "2.gif", "3.gif", "4.gif", "5.gif", "6.gif"];
var x = 0;
var col = [18, 81, 67, 76, 29, 92, 311, 113, 410, 104, 512, 125];
res = "";
var cnt = 0,
  i = 0,
  win = 0,
  f = 0;

var a = [];
a[0] = 3;
function init() {
  for (var i = 1; i <= 12; i++) {
    document.getElementById(i).src = "Moon.gif";
  }
}

function fun(obj) {
  if (cnt == 2) {
    //console.log("  ->   " + col.indexOf(parseInt(res)));
    if (col.indexOf(parseInt(res)) == -1) {
      //console.log("hii  ");
      document.getElementById(a[0]).src = "Moon.gif";
      document.getElementById(a[1]).src = "Moon.gif";
    } else {
      win++;
      res = "";
      cnt = 0;
      i = 0;
    }
    res = "";
    cnt = 0;
    i = 0;
  }

  if (obj.id == "1" || obj.id == "8") {
    obj.src = arr[1];
    res += obj.id;
    cnt++;
    a[i++] = parseInt(obj.id);
  } else if (obj.id == 6 || obj.id == 7) {
    obj.src = arr[0];
    res += obj.id;
    cnt++;
    a[i++] = parseInt(obj.id);
  } else if (obj.id == 2 || obj.id == 9) {
    obj.src = arr[5];
    res += obj.id;
    cnt++;
    a[i++] = parseInt(obj.id);
  } else if (obj.id == 3 || obj.id == 11) {
    obj.src = arr[2];
    res += obj.id;
    cnt++;
    a[i++] = parseInt(obj.id);
  } else if (obj.id == 4 || obj.id == 10) {
    obj.src = arr[4];
    res += obj.id;
    cnt++;
    a[i++] = parseInt(obj.id);
  } else if (obj.id == 5 || obj.id == 12) {
    obj.src = arr[3];
    res += obj.id;
    cnt++;
    a[i++] = parseInt(obj.id);
  }
  if (f == 1) {
    setTimeout(function () {
      win = -1;
      f = 0;
      alert("congrats");
    }, 0);
    setTimeout(function () {
      init();
    }, 0);
  }
  if (win == 5) f = 1;
  console.log("res -> " + res);
  console.log("cnt->  " + cnt);
  console.log("win->  " + win);
}
