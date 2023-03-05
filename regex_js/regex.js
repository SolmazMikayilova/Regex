//task1

let finCodes = ['94FMDDD', '1JH92CH'];
while(true){
    let enterFin = window.prompt("Enter finCode");
    let regex = /^[\w]{7}$/;
if(!regex.test(enterFin)){
    window.alert("Wrong finCode format! Please try again.");
    continue;
}
let index = finCodes.indexOf(enterFin);
if(index==-1){
    window.alert("finCode not found! Please try again.");
   continue;
}

window.alert("User found.Index: " +""+index);
break;

} 


