$(function () {
  var counter;
  var timer = setInterval(function () {
    var left = 500;
    $("#img").eq(0).animate({ left: "500px" }, 5000, "linear"); //easing["linea","swing",.....]
    counter = getComputedStyle($("#img").get(0));

    if (left == counter) {
      clearInterval(timer);
    } else {
      $("#imgSrc")
        .eq(0)
        .text('<img src="12.gif" style="left:"' + counter["left"] + "/>");
      counter += 10;
    }
  }, 100);
});
