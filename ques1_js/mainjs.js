function f1()
{
    // document.getElementById('hi').innerHTML="hi";
    var principle_amount = prompt("Enter Principle Amount");
    principle_amount=parseInt(principle_amount);
    if(principle_amount>0 && typeof principle_amount =="number")
    {
        var rate_of_interest= prompt("Enter Rate of interest");
        rate_of_interest=parseInt(rate_of_interest);
        if(rate_of_interest>0 && rate_of_interest<100 &&typeof rate_of_interest =="number")
        {
            var time_period= prompt("Enter time period");
            time_period = parseInt(time_period);
            if(time_period>0 && typeof time_period =="number")
            {
                var result= (principle_amount * rate_of_interest *time_period) / 100;
                document.getElementById('hlo').style.display="block";
                document.getElementById('hlo').innerHTML ="Simple interest  =" + result ;
                document.getElementById('btn-a').style.display="block";
                document.getElementById("btn").style.display="none";
                document.getElementById('btn-r').style.display="none";
            }
            else{
                document.getElementById('hi').innerHTML="You entered an invalid time period" ; 
                document.getElementById("btn-r").style.display="block"; 
                document.getElementById("btn").style.display="none"; 
                document.getElementById('btn-a').style.display="none";
            }
        
        }
        else
        {
            document.getElementById('hi').innerHTML="You entered an invalid rate of interest"
            document.getElementById("btn-r").style.display="block"; 
            document.getElementById("btn").style.display="none";
            document.getElementById('btn-a').style.display="none";
        }
    }
    else{
        document.getElementById('hi').innerHTML="You entered an invalid Principle Amount";
        document.getElementById("btn-r").style.display="block"; 
        document.getElementById("btn").style.display="none";
        document.getElementById('btn-a').style.display="none";
    }
    
    
    
    
}




function f2()

{
    
    document.getElementById("hi").innerHTML=" ";
    document.getElementById("hlo").innerHTML=" ";
    f1();
}

