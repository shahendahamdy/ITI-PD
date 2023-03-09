function f() {
  argumentsArray1 = Array.from(arguments);
  argumentsArray2 = Array.prototype.slice.call(arguments);

  console.log(argumentsArray1.reverse());
  console.log(argumentsArray2.reverse());
}

f(1, 2, 3);
f(1, 2, 3, 4);
