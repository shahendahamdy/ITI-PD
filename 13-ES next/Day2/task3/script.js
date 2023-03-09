//3) create your own object that has [Symbol.replace] method so that if any long string (e.g. its length exceed 15 characters )
//called replace and pass your object as replace method parameter it will display only 15 character of string with terminating “…”

var myObj={
    [Symbol.replace]:function(str){
        strTemp="";
       (str.length>15) ? strTemp= str.substring(0,15):strTemp=str;
       return strTemp;
    }
}
console.log("012345678912345678".replace(myObj));
console.log("012345678912345".replace(myObj));
console.log("01".replace(myObj));