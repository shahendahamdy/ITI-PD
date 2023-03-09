var Rectangle = function (width = 3, height = 4) {
  this.width = width;
  this.height = height;
  this.calcArea = function () {
    return this.width * this.height;
  };
  this.calcPerimeter = function () {
    return (this.width + this.height) * 2;
  };
};
var r1 = new Rectangle();
console.log("AREA -> " + r1.calcArea());
console.log("prem  -> " + r1.calcPerimeter());

var r2 = new Rectangle(5, 6);
console.log("AREA -> " + r2.calcArea());
console.log("prem  -> " + r2.calcPerimeter());
