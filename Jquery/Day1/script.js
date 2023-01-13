///the default for Divs

$("#div1, #div2, #div3 ,#div4, #out").hide(0);

//Activate about button

$("#btn1").click(function () {
  $(" #div2, #div3 ,#div4, #out").hide(0);
  $("#div1").show(0);
});

//Activate Gallery button

$("#btn2").click(function () {
  $("#div1,  #div3 ,#div4, #out").hide(0);
  $("#div2").show(0);
});

//Activate Services button

$("#btn3").click(function () {
  $("#div1, #div2,#div4, #out").hide(0);
  $("#div3").show(0);
});
//Activate Complain button

$("#btn4").click(function () {
  $("#div1, #div2, #div3 , #out").hide(0);
  $("#div4").show(0);
});
var x;
//  handling left Arrow

$("#left").click(function () {
  srcc = $("#crntImg").attr("src");
  x = parseInt(srcc[8]) - 1;
  if (x == 0) x = 8;
  console.log(x);
  $("#crntImg").attr("src", "imagess/" + x + ".jpg");
});

//  handling right Arrow

$("#right").click(function () {
  srcc = $("#crntImg").attr("src");
  x = parseInt(srcc[8]) + 1;
  if (x == 9) x = 1;
  console.log(x);
  $("#crntImg").attr("src", "imagess/" + x + ".jpg");
});

//Activate send button

$("#snd").click(function () {
  $("#div1, #div2, #div3 ,#div4 ").hide(0);
  $("#out").show(0);

  $("#b1").text($(t4).val());
  $("#b2").text($(t1).val());
  $("#b3").text($(t2).val());
  $("#b4").text($(t3).val());
});

//Activate back button

$("#bck").click(function () {
  $("#div1, #div2, #div3 ,#out").hide(0);

  $("#div4").show(0);
});
