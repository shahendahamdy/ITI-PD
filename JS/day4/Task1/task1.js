var x = window.location.href.substring(40);
for (var i = 0; i < 10; i++) {
  x = x.replace("=", "*");
  x = x.replace("&", "*");
  x = x.replace("%20", " ");
  x = x.replace("+", " ");
  x = x.replace("%40", "@");
}

var arr1 = x.split("*");
var cntr = 0;
document.getElementsByTagName("h1")[0].innerHTML =
  "hello  " + arr1[7] + " " + arr1[1];
for (var i = 2; i < arr1.length; i += 2) {
  if (i != 4 && i != 6)
    document.getElementsByTagName("p")[cntr++].innerHTML =
      arr1[i] + " --> " + arr1[i + 1];
}
