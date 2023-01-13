function f() {
  if (arguments.length != 2) {
    throw "invalid number of arguments";
  } else console.log("TWO ARG");
}

f(1, 2);
f(1, 2, 3);
f();
f(1);
