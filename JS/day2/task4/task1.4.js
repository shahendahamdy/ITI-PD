function f() {
  var nameX = /^[A-Za-z]+$/;
  var phoneX = /^([0-9]){8}$/;
  var mobileX = /^(010|011|012)[0-9]{8}$/;
  //var emailX = /^[a-z A-Z 0-9]+(@)([a-z A-Z])(\.)([a-z A-Z]+)$/;
  var emailX = /^[a-z0-9]+@[a-z]+\.[a-z]{2,3}$/;

  do {
    var name = prompt("enter name");
  } while (nameX.test(name) === false);
  do {
    var phone = prompt("enter phone");
  } while (phoneX.test(phone) === false);
  do {
    var mobile = prompt("enter mobile");
  } while (mobileX.test(mobile) === false);
  do {
    var email = prompt("enter email");
  } while (emailX.test(email) === false);
  /* do {
    var color = prompt("Enter a color:");
  } while (color !== "red" || color !== green);*/
  document.write(`<h1> ENTERING USER INFO</h1>` + "<hr>");
  document.write(
    `<b style="color:red">Welcome Dear Guest </b>` +
      " " +
      name +
      "<br/>" +
      `<b style="color:red">your telephone number is  </b>` +
      " " +
      phone +
      "<br/>" +
      `<b style="color:red">your mobile number is  </b>` +
      " " +
      mobile +
      "<br/>" +
      `<b style="color:red">your email is  </b>` +
      " " +
      email +
      "<br />"
  );
}
f();
