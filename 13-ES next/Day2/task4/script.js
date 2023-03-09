//4) Create an iterable object by implementing @@iterator method i.e. Symbol.iterator, so that you can use for..of 
//and retrieve its properties. Bonus: make proper updates to retrieve the object’s properties and its values.


var myObj={
    name:"ahmed",
    age:30,
    [Symbol.iterator]:function(){
        var cnt=0;
        var keys=Object.keys(myObj);
        return{
            next:function(){
                if(cnt==keys.length){
                    return{
                        value:undefined,
                        done:true
                    }
                }
                else{
                    return{
                        value:myObj[keys[cnt++]],
                        done:false
                    }
                }
            }
        }
    }
}

for(var elem of myObj){console.log(elem)}