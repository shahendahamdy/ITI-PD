function f() {
  var s = prompt("Enter string");
  var a = s.split(" ");
  mx = "";
  var mxS = a[0].length;
  mx = a[0];
  for (var i = 0; i < a.length; i++) {
    if (a[i].length > mxS) {
      mxS = a[i].length;
      mx = a[i];
    }
  }
  document.write("RES " + mx);
  document.write("<br />");
}

f();
