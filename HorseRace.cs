.field {
  height:300px;
  width:1000px;
  background-color:brown;
}

img {
  height:60px;
}

div div {
    width: 100px;
    height: 75px;
    position: relative;
    animation: horsemove 8s 1;
}

#div1 {animation-timing-function: linear;}
#div2 {animation-timing-function: ease;}
#div3 {animation-timing-function: ease-in;}
#div4 {animation-timing-function: ease-out;}

@keyframes horsemove {
    from {left: 0px;}
    to {left: 900px;}
}

