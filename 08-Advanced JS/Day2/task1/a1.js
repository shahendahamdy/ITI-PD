var x;
obj = {
  id: "SD-10",
  location: "SV",
  addr: "123 st.",
  getSetGen: function () {
    /*should be implemented*/
    x = Object.entries(this);
    for (var i = 0; i < x.length; i++) {
      this["get" + x[i][0]] = (function (i) {
        return function () {
          return this[x[i][0]];
        };
      })(i);
      this["set" + x[i][0]] = (function (i) {
        return function (val) {
          this[x[i][0]] = val;
        };
      })(i);
      //console.log("get" + x[i][0]);
    }
  },
};
obj.getSetGen();
ob2 = {
  name: "x",
  age: 11,
};
obj.getSetGen.apply(ob2);
