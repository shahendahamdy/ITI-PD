function area() {
  var r = prompt("enter raduis");
  return Math.PI * Math.pow(r, 2);
}
var area = area();
alert("area is" + area);

function sqroot() {
  var x = prompt("enter x");
  return Math.sqrt(x);
}
var sqroot = sqroot();
alert("squareroot is" + sqroot);

function cosine() {
  var angle = prompt("enter angle");
  return Math.cos((angle * 3.14) / 180);
}
var cosine = cosine();
alert("cos is" + cosine);
