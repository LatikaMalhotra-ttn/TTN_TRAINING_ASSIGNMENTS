function f1(){
    // alert("sdafasd");
    var str= document.getElementById("palindrome-string").value;
    var str= str.toUpperCase();
    var size= (str.length)-1;
    var l=0;
    while(size>l)
    {
        if (str[l++] != str[size--]) 
        { 
            document.getElementById("unsucess-msg").style.display="block";
            document.getElementById("re").style.display="block";
            document.getElementById("click-btn").style.display="none";
            document.getElementById("palindrome-string").disabled = true;
            return;
        } 
    }
    document.getElementById("success-msg").style.display="block";
    document.getElementById("re").style.display="block";
    document.getElementById("palindrome-string").disabled = true;
    document.getElementById("click-btn").style.display="none";


}

function f2(){
    document.getElementById("palindrome-string").focus();
    document.getElementById("unsucess-msg").style.display="none";
    document.getElementById("success-msg").style.display="none";
    document.getElementById("palindrome-string").focus();
    // f1();
}