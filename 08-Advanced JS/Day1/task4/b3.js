function f() {
  sum = 0;
  argumentsArray = Array.from(arguments);
  for (var i = 0; i < argumentsArray.length; i++) {
    if (typeof argumentsArray[i] != "number") throw "not number";
    sum += argumentsArray[i];
  }
  return sum;
}

console.log(f(1, 2, 3, 4));

console.log(f(1, "hh", 3));
