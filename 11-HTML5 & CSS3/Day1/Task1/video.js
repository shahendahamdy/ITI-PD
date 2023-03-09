var myVid=document.getElementById('vid');
var line=document.getElementById('line');


line.addEventListener("change", (event) => {

    myVid.currentTime=event.target.value
    console.log(myVid.currentTime)
    document.getElementById('crnt').innerHTML=Math.floor(myVid.currentTime/60)+":"+(myVid.currentTime%60).toFixed(0)

});

var interval= setInterval(function(){
    //current time
    
    //end time
    document.getElementById('crnt').innerHTML=Math.floor(myVid.currentTime/60)+":"+(myVid.currentTime%60).toFixed(0)
    document.getElementById('total').innerHTML=Math.floor(myVid.duration/60)+":"+(myVid.duration%60).toFixed(0)
line.value=myVid.currentTime

},500)




//MAXimmum of line
//* play video
document.getElementById('play').onclick=function(){
    console.log("played")
    myVid.play()
}

//* Pause video
document.getElementById('stop').onclick=function(){
    myVid.pause()
}
//* << button
document.getElementById('<<').onclick=function(){
    myVid.currentTime=0
}
//* >> button
document.getElementById('>>').onclick=function(){
    myVid.currentTime=myVid.duration
}
//* < button
document.getElementById('<').onclick=function(){
    myVid.currentTime-=5
}
//* > button
document.getElementById('>').onclick=function(){
    myVid.currentTime+=5
}


//* Speed
document.getElementById('speed').onchange = function(){
    myVid.playbackRate = parseInt(this.value)
    document.getElementById('speed').value = myVid.currentTime

}


//* Volume
document.getElementById('sound').onchange = function(){
    myVid.volume = this.value / 100    ;
}

//* mute
document.getElementById('mute').onclick = function(){
    myVid.volume = 0    ;
    console.log(myVid.volume)
    document.getElementById('sound').value = 0
    

}
//* mute
document.getElementById('full').onclick = function(){
    myVid.requestFullscreen();


}
