var $table = $('#table');

 var myPromise = new Promise(function(s,f){
     var xhr = new XMLHttpRequest()
     xhr.open("GET","https://jsonplaceholder.typicode.com/users")
     xhr.onreadystatechange = function(){
         if(xhr.readyState==4){
             if(xhr.status == 200){
                 // var data = JSON.parse(xhr.responseText)
                 // console.log(data)
                 s(xhr.responseText)
             }
             else
             {
                 f('wrong data')
             }
         }
     }
 xhr.send('')
 })
 .then(function(data){
     var info = JSON.parse(data)
     $(function () {
        $('#table').bootstrapTable({
            data: info
        });
    });
     console.log(info)
 })
 .catch(function(msg){
     console.log(msg)
 })
 console.log('hii ')