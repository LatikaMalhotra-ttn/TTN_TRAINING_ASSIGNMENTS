function f1()
{
    var num= document.getElementById('input-radius').value;

    if (isNaN(num) || num < 0) {
        document.getElementById("result-div1").innerHTML="Please enter valid input";
        document.getElementById("btn-a").style.display="block";
        document.getElementById("margin-btn").style.display="none";
        document.getElementById('input-radius').disabled=true;
    } 
    else {  
        var result= 2* 3.14* num *num;
        var fnum = 2*num;

        document.getElementById("result-div").innerHTML=result;
        document.getElementById("btn-a").style.display="block";
        document.getElementById("res").style.display="block";
        document.getElementById("margin-btn").style.display="none";
        document.getElementById('input-radius').disabled=true;
        document.getElementById("circle-div").style.height=fnum+"px";
        document.getElementById("circle-div").style.width=fnum+"px";
        document.getElementById("circle-div").style.borderRadius="50%";
        document.getElementById("circle-div").style.backgroundColor="black";

      }
}

function f2(){
    // alert("dfas");
    document.getElementById("result-div").innerHTML=" ";
    document.getElementById("result-div1").innerHTML=" ";
    document.getElementById('input-radius').value=""; 
    document.getElementById("btn-a").style.display="none"; 
    document.getElementById("margin-btn").style.display="block";   
    document.getElementById("circle-div").style.height="0px";
    document.getElementById("circle-div").style.width="0px";
    document.getElementById('input-radius').disabled=false;
    document.getElementById("res").style.display="none";

}