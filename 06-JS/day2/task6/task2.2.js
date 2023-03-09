function f() {
  var arr = new Array();

  for (var i = 0; i < 5; i++) {
    arr[i] = parseInt(prompt("enter element " + (i + 1)));
  }
  document.write(`<h1>sorting</h1>` + "<hr>");
  document.write(
    `<b style="color:red">you have entered </b>` +
      " " +
      arr +
      "<br/>" +
      `<b style="color:red">sorting ascending</b>` +
      " " +
      arr.sort(function (a, b) {
        return a - b;
      }) +
      "<br/>" +
      `<b style="color:red">sorting descending </b>` +
      " " +
      arr.reverse() +
      "<br/>"
  );
}
f();
