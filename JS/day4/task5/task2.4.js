var stmt = "";
var numArr;
var opArr,
  k = 0;
var j = 0;
var o = 0;
var num;
var symp;
function calc() {
  o = 0;
  console.log("arr ->", opArr[o]);

  var sm = parseInt(numArr[0]);
  console.log("a");
  for (var i = 1; i < numArr.length; i++) {
    if (opArr[o] == "+") {
      console.log("a " + sm);

      sm += parseInt(numArr[i]);
      console.log("a " + sm);
    } else if (opArr[o] == "-") {
      console.log("b");

      sm -= parseInt(numArr[i]);
    } else if (opArr[o] === "*") {
      console.log("c");

      sm *= parseInt(numArr[i]);
    } else if (opArr[o] == "/") {
      console.log("d");

      sm /= parseInt(numArr[i]);
    } else {
      console.log("bla bla ..");
    }
    o++;
  }
  return sm;
}

function EnterNumber(val) {
  document.getElementById("Answer").value += val;

  stmt += val;
  console.log(stmt);
}
function EnterOperator(val) {
  document.getElementById("Answer").value += val;

  stmt += val;
  console.log(stmt);
}
function EnterEqual() {
  num = "";
  symp = "";
  for (var i = 0; i < stmt.length; i++) {
    if (/^\d$/.test(stmt[i])) {
      num += stmt[i];
    } else {
      num += ",";
      symp += stmt[i];
    }
  }

  numArr = num.split(",");
  opArr = symp.split("");

  res = calc();
  console.log("res " + res);
  document.getElementById("Answer").value += "  = " + res;
}

function EnterClear() {
  document.getElementById("Answer").value = "";
  k = j = o = 0;
}
