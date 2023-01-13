function viewHeading() {
  var t = prompt("enter your msg");
  for (var i = 1; i <= 6; i++) {
    document.write(`<h${i}> ${t} ${i} <\h${i}>`);
  }
}
viewHeading();

function sum() {
  var sm = 0,
    num;
  do {
    num = parseInt(prompt("enter num"));
    sm += num;
  } while (sm < 100 && isFinite(num) && num != 0);

  document.write("sum = " + sm);
}
sum();
