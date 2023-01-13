
var arr = [
  "images/1.jpg",
  "images/2.jpg",
  "images/3.jpg",
  "images/4.jpg",
  "images/5.jpg",
  "images/6.jpg",
];
var intervaal;
function srch() {
  var x = document.getElementById("1").src;
  for (var i = 0; i < arr.length; i++) {
    //console.log(x)

    if (arr[i] === x) return i;
    
  }
}

function next() {
  var x= document.getElementById(1).src
  x=x[x.length-5]
  console.log(x)
  if (x < 6) {
    document.getElementById(1).src = arr[x++];
  }
}
function previous() {
 var y= document.getElementById(1).src
  y=y[y.length-5]
  console.log(y)

  if (y > 1) {
    document.getElementById(1).src = arr[y-2];
    console.log(document.getElementById(1).src)
  }
}
function slideShow() {
  var x= document.getElementById(1).src
  x=x[x.length-5]
  console.log(x)
  intervaal = setInterval(function () {
    x++;
    if (x >= 6) x = 0;
    document.getElementById(1).src = arr[x];
  }, 500);
}
function stop() {
  clearInterval(intervaal);
}
