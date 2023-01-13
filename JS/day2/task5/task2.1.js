function f() {
  var arr = new Array();
  var sm = 0,
    mul = 1;
  div = 0;
  for (var i = 0; i < 3; i++) {
    arr[i] = parseInt(prompt("enter element " + (i + 1)));
    sm += arr[i];
    mul *= arr[i];
    if (i == 0) div = arr[i] * arr[i];
    div /= arr[i];
  }

  document.write(`<h1>Adding multiplaying and dividing</h1>` + "<hr>");
  document.write(
    `<b style="color:red">sum of 3 values </b>` +
      " " +
      arr[0] +
      " + " +
      arr[1] +
      " + " +
      arr[2] +
      " = " +
      sm +
      "<br/>" +
      `<b style="color:red">mul of 3 values </b>` +
      " " +
      arr[0] +
      " * " +
      arr[1] +
      " * " +
      arr[2] +
      " = " +
      mul +
      "<br/>" +
      `<b style="color:red">div of 3 values </b>` +
      " " +
      arr[0] +
      " / " +
      arr[1] +
      " / " +
      arr[2] +
      " = " +
      div +
      "<br/>"
  );
}
f();
