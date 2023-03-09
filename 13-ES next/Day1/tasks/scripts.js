//Swap the values of x and y using destructuring
var x=3 ,y=4;
console.log("x= "+x+" y= "+y);
[x,y]=[y,x];
console.log("x= "+x+" y= "+y);
//--------------------------------------------------------------------------------------
//Using rest parameter and spread operator return min and max value from any array passed to function call and 
//display each of them separately after function call note: array length is not fixed

function fun(...params){
    return Math.min(...params)+"  "+Math.max(...params);

}

var arr=[5,2,-5,9,6];
console.log(fun(...arr));

//--------------------------------------------------------------------------------------

///Study new array api methods then create the following methods and apply it on this array
var fruits = ["apple", "strawberry", "banana", "orange", "mango"];

//a. test that every element in the given array is a string
console.log(fruits.every(s=> typeof s === 'string') );

//b. test that some of array elements starts with "a"
console.log(fruits.some(s=> s.startsWith('a') ));

//c. generate new array filtered from the given array with only elements that starts with "b" or "s"
newfruits= fruits.filter(s=> s.startsWith('b')|| s.startsWith('s') );
console.log(newfruits);

//d. generate new array, each element of the new array contains a string declaring that you like the give fruit element
newfruits2= fruits.map(s=> s="I Love "+s );
console.log(newfruits2);

//e. use forEach to display all elements of the new array from previouse point
newfruits2.forEach(element => {
    console.log(element)
});

