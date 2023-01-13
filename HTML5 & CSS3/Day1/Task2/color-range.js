console.log('hi')
document.getElementById('btn').onclick=function(){
   // console.log(document.getElementById('r').value)
}
var r=0 ,g=0,b=0
document.getElementById('r').addEventListener("change", (event) => {
    r= event.target.value
    console.log(r)
    document.getElementById('p1').style.color= "rgb("+r+','+ g+','+b+")"; 

    
  })
  document.getElementById('g').addEventListener("change", (event) => {
    g= event.target.value
    document.getElementById('p1').style.color= "rgb("+r+','+ g+','+b+")"; 
  })
  document.getElementById('b').addEventListener("change", (event) => {
    b= event.target.value
    document.getElementById('p1').style.color= "rgb("+r+','+ g+','+b+")"; 
  })
  //document.getElementById('btn').onclick=function(){
