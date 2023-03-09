function f1() {
  var temp1,
    c,
    cnt = 0;
  var s1 = prompt("enter String");
  var s2 = prompt("enter char");
  var s3 = parseInt(prompt("if case senstive enter 1 , else enter 0"));
  if (s3 == 0) {
    //not case senstive
    temp1 = s1.toLowerCase();
    c = s2.toLowerCase();
    for (var i = 0; i < temp1.length; i++) {
      if (temp1[i] == c) cnt++;
    }
    document.write(cnt);
  } else {
    for (var i = 0; i < s1.length; i++) {
      if (s1[i] == s2) {
        cnt++;
      }
    }
    document.write(cnt);
  }
}
f1();
