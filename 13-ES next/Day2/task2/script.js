//2) Create a generator that returns fibonacci series that takes only one parameter. Make two different implementations as described below:

//a. the parameter passed determines the number of elements displayed from the series.
function fib1(noOfElements){
    const map1 = new Map();
    for(var i=0;i<noOfElements;i++){
        if(i<=1)map1.set(i,1);
        else map1.set(i,map1.get(i-1)+map1.get(i-2))
    }
    return map1
}
console.log("the first series")
fib1(10).forEach(element => {
    console.log(element)
});

//b. the parameter passed determines the max number of the displayed series should not exceed its value.
function fib2(maxNum){
    var num=1,i=0,prev=0;
    const map1 = new Map();

    while(num+prev<=maxNum){
        if(i<2){
            num=1;
            map1.set(i++,1)
        }
        else{
            num=map1.get(i-1)+map1.get(i-2)
            prev=map1.get(i-1);
            map1.set(i,num);
            i++ 
        
        }

    }
    
    return map1
}
console.log("the second series")

fib2(21).forEach(element => {
    console.log(element)
});
//a. the parameter passed determines the number of elements displayed from the series.
console.log("the first series")


function *fibonacci1(n) {
    let current = 1;
    let next = 1;
    
    while (n--) {
      yield current;
      [current, next] = [next, current + next];
    }
  }
  var result = fibonacci1(9)

for(var elem of fibonacci1(9)){
    console.log("value "+elem)
}

//b. the parameter passed determines the max number of the displayed series should not exceed its value.
console.log("the second series")

function *fibonacci2(n) {
    let current = 1;
    let next = 1;
    
    while (current<=n) {
      yield current;
      [current, next] = [next, current + next];
    }
  }
  var result = fibonacci2(13)

for(var elem of fibonacci2(14)){
    console.log("value "+elem)
}