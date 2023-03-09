var timeout = new Event("timeout");
var flag = 0;
document.body.addEventListener("timeout", function () {
  if (!flag) alert("timeout fired ,please enter your data");
});
for (var i = 0; i < 3; i++) {
  document.getElementsByTagName("input")[i].oninput = function () {
    flag = 1;
  };
  setTimeout(() => {
    if (flag == 0) {
      document.body.dispatchEvent(timeout);
    }
  }, 30000);
}

function fun() {
  var res = confirm("continue");
  console.log(res);
  if (res == true) {
    document.getElementById("btn1").type = "submit";
    document.getElementsByTagName("p")[0].innerHTML =
      "look at the url you have submitted successfully";
  }
}
