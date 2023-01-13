/* $(function () {
  $("#rabbit").draggable();
}); */
$("#rabbit").draggable({
  start: function () {
    coordinates("#rabbit");
  },
  stop: function () {
    coordinates("#rabbit");
  },
});
var coordinates = function (element) {
  element = $(element);
  var top = element.position().top;
  var left = element.position().left;
  if (left >= 240 && left <= 420 && top >= 2 && top <= 190) {
    console.log("danger");
    $("#rabbit").hide("explode", 3000);
  }
  $("#results").text("X: " + left + " " + "Y: " + top);
};
/*  x 240-420
 y 2 190 */
