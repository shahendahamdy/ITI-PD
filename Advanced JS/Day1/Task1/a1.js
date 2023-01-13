var linkedList = {
  arr: [],
  ///function to add element to the start of array with taking considration of ordering
  enqueue: function (num) {
    if (this.arr.length == 0) {
      this.arr.push(num);
    } else {
      if (this.arr[0] > num) this.arr.unshift(num);
      else if (this.arr[0] == num) throw "repeated num";
      else throw "can'y enqueue large num";
    }
  },
  ///function to add element to specific index of array with taking considration of ordering

  insert: function (num, idx) {
    if (idx > this.arr.length) throw " not allowd index";
    else if (idx == this.arr.length) {
      this.push(num);
    } else if (idx == 0) {
      this.enqueue(num);
    } else {
      if (num > this.arr[idx - 1] && num < this.arr[idx]) {
        this.arr.splice(idx, 0, num);
      } else throw "can't add this num ";
    }
  },
  ///function to remove last element

  pop: function () {
    if (this.arr.length == 0) throw "no elements to pop";
    else return this.arr.pop();
  },
  ///function to remove specific element

  remove: function (elm) {
    if (this.arr.includes(elm)) {
      indx = this.arr.indexOf(elm);
      this.arr.splice(indx, 1);
    } else throw "no elements to remove";
  },
  ///function to remove first elemnt

  dequeue: function () {
    if (this.arr.length == 0) throw "no elements to dequeue";
    else return this.arr.shift();
  },
  ///function to add elmnt at the end of array

  push: function (num) {
    if (this.arr.length == 0) this.arr.push(num);
    else {
      if (this.arr[this.arr.length - 1] < num) {
        this.arr.push(num);
      } else if (this.arr[this.arr.length - 1] == num) throw "repeated num";
      else throw "can't push slower num";
    }
  },
  ///function to disply the array

  disply: function () {
    for (var i = 0; i < this.arr.length; i++) console.log(this.arr[i] + "  ");
    return this.arr;
  },
};
