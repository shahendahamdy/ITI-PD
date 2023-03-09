/* 
    ctor(s,e,stp)
    arr[2,4,6,8,10]
    getter setter
    using Accessor &descriptor 
    Cant delete any of properties
    Methods
    Append-prepend -deq-pop
    lw awl rqm hdefo not 2 throw Exception ETC;

 */

function List(_start, _end, _step) {
  this.Start = _start;
  this.End = _end;
  this.Step = _step;
  this.arr = [];
}

var l1 = new List(2, 10, 2);
function f() {
  return 0;
}
Object.defineProperty(l1, "push", {
  value: function (num) {
    length = this.arr.length;
    console.log(this.arr.length);
    ///if the Array is empty check the enterd number
    if (length == 0) {
      if (num == this.Start) this.arr.push(num);
      else throw "you shoud start with the specified start";
    }
    ///if the Array not Empty
    else {
      //check the last Elemnt in Array reached to End
      if (this.arr[length - 1] == this.End)
        throw "you Cant Exceed the specified End";
      else {
        if (this.arr[length - 1] + this.Step <= this.End) {
          if (this.arr[length - 1] + this.Step == num) {
            this.arr.push(num);
          } else {
            throw "Not in the sequence";
          }
        }
      }
    }
  },
  configurable: false,
  writable: false,
  enumerable: false,
});
Object.defineProperty(l1, "pop", {
  value: function () {
    if (this.arr.length == 0) throw "Cant pop";
    else {
      this.arr.pop();
    }
  },
  configurable: false,
  writable: false,
  enumerable: false,
});
Object.defineProperty(l1, "enqueue", {
  value: function (num) {
    length = this.arr.length;
    console.log(this.arr[0], "-" + this.Step + "==" + num);
    ///if the Array is empty check the enterd number
    if (length == 0) {
      if (num == this.Start) this.arr.push(num);
      else throw "you shoud start with the specified start";
    } else {
      if (this.arr[0] == num) throw "cant put num less than the start";
      else if (this.arr[0] - this.Step == num) {
        if (num >= this.Start) this.arr.unshift(num);
      } else throw "Not valid";
    }
  },
  configurable: false,
  writable: false,
  enumerable: false,
});
Object.defineProperty(l1, "dequeue", {
  value: function () {
    if (this.arr.length == 0) throw "Cant deq";
    else {
      this.arr.shift();
    }
  },
  configurable: false,
  writable: false,
  enumerable: false,
});
