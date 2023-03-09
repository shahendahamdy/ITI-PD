//1) Create your own function that accepts multiple parameters to generate course information and display it. 
//Assume that the function accepts course information as object that contains courseName, courseDuation, courseOwner. 
//if any of required field is not set in function call it should have default values as follows: courseName=”ES6” , courseDuration=”3days”,
// courseOwner=”JavaScript”.
function fun1(obj){
    var defaultobj={
        courseName:"ES6", courseDuation:"3days", courseOwner:"JavaScript"
    }
    var result= Object.assign({},defaultobj,obj);

    return `course name is ${result.courseName} and course duration is ${result.courseDuation} and course owner is ${result.courseOwner}`;
}

console.log(fun1({ courseName:".Net", duration:"5days", courseOwner:"JavaScript"}))
console.log(fun1({ x:".Net", y:"5days", z:"dd"}))

//Version 2
//Bonus: through exception if passed object includes properties other than those described above
//Note: user is allowed not to pass all of these properties, he can pass needed properties only
function fun2(obj){
    if (obj.hasOwnProperty("courseName")&&obj.hasOwnProperty("courseDuation")&&obj.hasOwnProperty("courseOwner")){    
    var defaultobj={
        courseName:"ES6", courseDuation:"3days", courseOwner:"JavaScript"
    }
    var result= Object.assign({},defaultobj,obj);

    return `course name is ${result.courseName} and course duration is ${result.courseDuation} and course owner is ${result.courseOwner}`;
}
else{
throw " Properties not valid"}

}

console.log(fun2({ courseName:".Net", courseDuation:"5days", courseOwner:"JavaScript"}))
console.log(fun2({ x:".Net", y:"5days", z:"dd"}))
