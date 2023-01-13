onload = function () {
  ///without closure
  function fun1() {
    for (var i = 0; i < 5; i++) {
      var createBTN = document.createElement("input");
      createBTN.setAttribute("type", "button");
      createBTN.setAttribute("value", "click button: " + i);
      createBTN.onclick = function () {
        console.log("click" + i);
        alert("You Clilcked btn : " + i);
      };
      this.document.body.appendChild(createBTN);
    }
  }
  //fun1();

  ///with closure
  function fun2() {
    for (var i = 0; i < 5; i++) {
      (function () {
        var createBTN = document.createElement("input");
        createBTN.setAttribute("type", "button");
        createBTN.setAttribute("value", "click button: " + i);
        createBTN.onclick = function () {
          console.log("click" + i);
          alert("You Clilcked btn : " + i);
        };
        this.document.body.appendChild(createBTN);
      })();
    }
  }
  fun2();
};
