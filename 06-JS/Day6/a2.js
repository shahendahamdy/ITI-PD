img1 = document.getElementsByTagName("img")[0];
img2 = document.createElement("img");
div = document.createElement("div");

img2.src = "images/dom.jpg";
document.body.prepend(div);
div.appendChild(img1);
div.style.textAlign = "right";
document.body.appendChild(img2);
document.images[0].style.align = "right";
document.getElementsByTagName("ul")[0].style.listStyleType = "circle";
