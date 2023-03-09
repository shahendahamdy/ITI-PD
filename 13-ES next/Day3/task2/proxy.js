/*

Proxy create a dynamic object using Proxy such that it has only the following properties
 name property that accepts only string of 7 characters
 address property that accepts only string value
 age property that accepts numerical value between 25 and 60 
 
*/

var obj={
    namee:"hh",
    address:"kk",
    age:15
}
var handler ={
    set(target,prop,value){
        if(prop==="namee"){
            if (value.length==7)target[prop]=value;
            else throw "length not 7" 
        }
        else if(prop==="address"){
            if (typeof(value)==String|| typeof(value)=="string")target[prop]=value;
            else throw "wrongDT"
        }
        else if(prop==="age"){
            if (typeof(value)==Number ||typeof(value)=="number"){
               if(value>=25 && value<=60) target[prop]=value;
               else throw "invalid range"
            }
            else throw "wrongDT"
        }        
    },
    get(target,prop){
        if(target.hasOwnProperty(prop)) return target[prop];
        else throw "invalid property name "
    }
}
var proxy1 =new Proxy(obj,handler);
//proxy1.age="Dddd"; ///proxy.js:30 Uncaught wrongDT
//proxy1.namee="kkk" ///proxy.js:19 Uncaught length not 7
proxy1.namee="kkklllk" 
console.log(proxy1.namee); 
//proxy1.address=55 ///uncaught wrongDT
//proxy1.age=15 //proxy.js:28 Uncaught invalid range
proxy1.age=35 
console.log(proxy1.age); 