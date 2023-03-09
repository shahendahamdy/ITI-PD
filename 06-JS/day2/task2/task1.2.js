function f1() {
  var temp1, temp2;
  flag = 0;

  var s1 = prompt("enter String");
  var s3 = confirm("is it case sensitive");

  if (s3 === true) {
    //case senstive
    temp1 = s1.split("");

    temp2 = s1.split("").reverse();

    for (var i = 0; i < temp1.length; i++) {
      if (temp1[i] !== temp2[i]) {
        flag = 1;
      }
    }

    if (flag === 1) {
      document.write("NOT PALINDROME");
      document.write("<br>");
    } else {
      document.write("PALINDROME");
      document.write("<br>");
    }
  } else if (s3 === false) {
    //not case
    s1 = s1.toLowerCase();
    temp1 = s1.split("");

    temp2 = s1.split("").reverse();

    for (var i = 0; i < temp1.length; i++) {
      if (temp1[i] !== temp2[i]) {
        flag = 1;
      }
    }

    if (flag === 1) {
      document.write("NOT PALINDROME");
      document.write("<br>");
    } else {
      document.write("PALINDROME");
      document.write("<br>");
    }
    //document.write("waiting");
  }
}
f1();
