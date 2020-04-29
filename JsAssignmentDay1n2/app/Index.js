//BAsic Setting for html 
disableQuestionDiv();










//------------------------------------------------------------------------------------------------------------->
//Question1: Given this array: `[3,62,234,7,23,74,23,76,92]`, Using arrow function, 
//create an array of the numbers greater than `70`.

document.getElementById("q1").addEventListener("click", ques1);

//function on click event
function ques1(){
    //basic settings for html
    document.getElementById("main_div").style.display="none";
    disableQuestionDiv();
    document.getElementById("div_of_question1").style.display="block";
    

    document.getElementById("q1btn").addEventListener("click",()=>{
    //array from to be fetched 
    let arr = [3,62,234,7,23,74,23,76,92];
    //array where found will be stored
    let finalArray=[];
    //arrow function performing operation
    let fetchAboveSeventy=()=>{
        for(let no of arr){
            if(no>70){
                finalArray.push(no)
        }}}
        //calling method
    fetchAboveSeventy();
    //adding in DOM
    document.getElementById("a1").insertAdjacentHTML("afterbegin",`${finalArray}`)
        

})
}





















//------------------------------------------------------------------------------------------------------------->
//Question2:
document.getElementById("q2").addEventListener("click", ques2);

//function on click event
function ques2(){
    //basic settings for html
    document.getElementById("main_div").style.display="none";
    disableQuestionDiv();
    document.getElementById("div_of_question2").style.display="block";
    //------------------------------------------------------------------------------------------------->
    //question 2(a) event listener ~ fetching all items from list as an array
    document.getElementById("q2abtn").addEventListener("click",()=>{
        //array where found will be stored
        let finalArray=[];
        let listElements = document.getElementById("q2ul").getElementsByTagName("li");
        for(let element of listElements){
            finalArray.push(element.textContent)
        }
        //adding in DOM
        document.getElementById("a2a").insertAdjacentHTML("afterbegin",`${finalArray}`)
        
    })
        

        
    //question 2(b) event listener ~ fetching all items from list as an array who have felxbox in it
    document.getElementById("q2bbtn").addEventListener("click",()=>{
        //array where found will be stored
        let finalArray=[];
        let listElements = document.getElementById("q2ul").getElementsByTagName("li");
        for(let element of listElements){
            if(element.textContent.includes("Flexbox")){
            finalArray.push(element.textContent)
            }
          
        
        }
        
        //adding in DOM
        document.getElementById("a2b").insertAdjacentHTML("afterbegin",`${finalArray}`)   
    })
        
     
        
    //question 2(c) event listener ~ fetching all date time from list
    document.getElementById("q2cbtn").addEventListener("click",()=>{
        //array where found will be stored
        let finalArray=[];
        let listElements = document.getElementById("q2ul").getElementsByTagName("li");
        for(let element of listElements){
            finalArray.push( element.attributes[0].value)
        }
        
        //adding in DOM
        document.getElementById("a2c").insertAdjacentHTML("afterbegin",`${finalArray}`)   
    })
        
        
    //question 2(d) event listener ~ map to an array of seconds
    document.getElementById("q2dbtn").addEventListener("click",()=>{
        //array where found will be stored
        let secondsFinalArray=[];
        let finalArray=[];
        let listElements = document.getElementById("q2ul").getElementsByTagName("li");
        for(let element of listElements){
            finalArray.push( element.attributes[0].value)
        }
        let finalSeconds;
        finalArray.map((time)=>{
            finalSeconds=  Number(time.split(":")[0]) *60 + Number(time.split(":")[1])
            secondsFinalArray.push(finalSeconds)
        })
        //adding in DOM
        document.getElementById("a2d").insertAdjacentHTML("afterbegin",`${secondsFinalArray}`)   
    })
        
    //question 2(e) event listener ~ reducing to get total time
    document.getElementById("q2ebtn").addEventListener("click",()=>{
      
        let secondsFinalArray=[];
        let finalArray=[];
        let listElements = document.getElementById("q2ul").getElementsByTagName("li");
        for(let element of listElements){
            finalArray.push( element.attributes[0].value)
        }
        let finalSeconds;
        finalArray.map((time)=>{
            finalSeconds=  Number(time.split(":")[0]) *60 + Number(time.split(":")[1])
            secondsFinalArray.push(finalSeconds)
        })
     
        let totalTime=secondsFinalArray.reduce((total,num)=>{
            return total+num;
        })
        
        //adding in DOM
        document.getElementById("a2e").insertAdjacentHTML("afterbegin",`${totalTime}`)   
    })
}    













//------------------------------------------------------------------------------------------------------------->
//Question3: Given this array: `[3,62,234,7,23,74,23,76,92]`, Using arrow function, 
//create an array of the numbers greater than `70`.

document.getElementById("q3").addEventListener("click", ques3);

//function on click event
function ques3(){
    //basic settings for html
    document.getElementById("main_div").style.display="none";
    disableQuestionDiv();
    document.getElementById("div_of_question3").style.display="block";
    
    document.getElementById("q3btn").addEventListener("click", ()=>{
        const song = {
                name: 'Dying to live',
                artist: 'Tupac',
                featuring: 'Biggie Smalls'
               };
        
        //adding in DOM
        document.getElementById("a3").insertAdjacentHTML("afterbegin",`
            <div class="song">
            <p>
                ${song.name}
                (Featuring ${song.featuring})
            </p>
            </div>
            `)   
        
    })
}















//------------------------------------------------------------------------------------------------------------->
//Question4:(a) Extract all keys inside address object from user object using destructuring
//Question4:(b)  Filter unique array members using Set. 
document.getElementById("q4").addEventListener("click", ques4);

//function on click event
function ques4(){
    //basic settings for html
    document.getElementById("main_div").style.display="none";
    disableQuestionDiv();
    document.getElementById("div_of_question4").style.display="block";
    
    // answer of ques4(a)
    document.getElementById("q4btn").addEventListener("click", ()=>{
        const user = {
                firstName: "Sahil",
                lastName: "Dua",
                Address:
        {
        Line1: "address line 1",
                Line2: "address line 2",
                State: "Delhi",
                Pin: 110085,
                Country: "India",
                City: "New Delhi",
                },
                phoneNo: 9999999999
                }
        
        //adding in DOM
        document.getElementById("a4").insertAdjacentHTML("afterbegin",`${ Object.keys(user.Address)}`)   
                   
        
        })


        // answer of ques4(b)
        document.getElementById("q4bbtn").addEventListener("click", ()=>{
            //array from to be fetched 
            let arr = [3, 62, 3, 9, 92, 234, 23, 3, 234, 7, 23, 74, 23, 76, 92];
            //array where found will be stored
            let setData = new Set(arr)
            //adding in DOM
            document.getElementById("a4b").insertAdjacentHTML("afterbegin",`${ Array.from(setData)}`)
        })
}















//------------------------------------------------------------------------------------------------------------->
//Ques5: Find the possible combinations of a string and store them in a MAP?  
document.getElementById("q5").addEventListener("click", ques5);

//function on click event
function ques5(){
    //basic settings for html
    document.getElementById("main_div").style.display="none";
    disableQuestionDiv();
    document.getElementById("div_of_question5").style.display="block";
    document.getElementById("q5btn").addEventListener("click", ()=>{
        let str1 = document.getElementById("stringVal").value;
        var array1 = [];
        var count = 0;
        let finalMap = new Map();
        for (var x = 0, y = 1; x < str1.length; x++, y++)
        {
        array1[x] = str1.substring(x, y);
        }
        var combi = [];
        var temp = "";
        var slent = Math.pow(2, array1.length);
        
        for (var i = 0; i < slent; i++)
        {
        temp = "";
        for (var j = 0; j < array1.length; j++)
        {
        if ((i & Math.pow(2, j)))
        {
        temp += array1[j];
        }
        }
        if (temp !== "")
        {
        finalMap.set(`key_${ count++}`,temp);
        combi.push(temp);
        }
        }
        console.log("Answer for question 5--------------->")
        console.log(finalMap)
        document.getElementById("a5").insertAdjacentHTML("afterbegin",`${ finalMap}
        Attention - Please check answer in console for this`)
    })
}
        
        










        
//------------------------------------------------------------------------------------------------------------->
//Question6: Write a program to implement inheritance upto 3 classes.
//The Class must  public variables and static functions.
document.getElementById("q6").addEventListener("click", ques6);

//function on click event
function ques6(){
    //basic settings for html
    document.getElementById("main_div").style.display="none";
    disableQuestionDiv();
    document.getElementById("div_of_question6").style.display="block";

    class Animal
    {
        constructor(type)
        {
            this.type = type;
        }
        static aboutAnimalClass()
        {
            console.log("Basic animal details")
        }

    }

    class Lion extends Animal
    {
        constructor(type,age,location){
            super(type)
            this.age = age
            this.location = location
        }
        static aboutLionClass()
        {
            console.log("This class hold info about lion")
        }
    }

    class Cub extends Lion
    {
        constructor(type,age,location,gender){
            super(type, age, location)
            this.gender = gender
            this.info = () => {
                console.log(type, age, gender, location)
            }

        }
        static aboutCubClass()
        {
        console.log("This class holds data about cub")
        }
    }

    console.log("Below is the output of question 6--------------->")
    let cub = new Cub("carnivorous", 1, "africa", "male");
    cub.info();

    Cub.aboutCubClass()
    Cub.aboutLionClass()
    Cub.aboutAnimalClass()



}












//------------------------------------------------------------------------------------------------------------->
//Question7: Write a program to implement a class having static functions
document.getElementById("q7").addEventListener("click", ques7);

//function on click event
function ques7(){
    //basic settings for html
    document.getElementById("main_div").style.display="none";
    disableQuestionDiv();
    document.getElementById("div_of_question7").style.display="block";
    class MyUtility
    {
        static add(x, y)
        {
            console.log(x + y)
        }
        static subtract(x, y)
        {
            console.log(x - y)
        }
        static multiply(x, y)
        {
            console.log(x * y)
        }
        static divide(x, y)
        {
            console.log(x / y)
        }
    }

    console.log("Below is Output of question 7--------------->")
    MyUtility.add(2,5);
    MyUtility.subtract(2,5);
    MyUtility.multiply(2,5);
    MyUtility.divide(2,5);
}


















//------------------------------------------------------------------------------------------------------------->
// Ques8:Import a module containing the constants and method for calculating area of circle,
// rectangle, cylinder.

//importing methods and constants from Area.js
import {message_for_q8,CalculateArea } from './Area.js';

//Click on ques8 in side bar to see the result
document.getElementById("q8").addEventListener("click", ques8);

//function on click event
function ques8(){
    //basic settings for html
    document.getElementById("main_div").style.display="none";
    disableQuestionDiv();
    document.getElementById("div_of_question8").style.display="block";
    document.getElementById("div_of_question8").innerHTML=message_for_q8;

    //prompt to let user enter his/her choice to select area
    const choice=(prompt("Enter the figure(circle,rectangle,cylinder)for which you want to calculate area","choice"))
             .toLowerCase();
    //function is called to calculate the respecctive area
    CalculateArea(choice);
}













//------------------------------------------------------------------------------------------------------------->
//Ques9: Import a module for filtering unique elements in an array.
//import the function from the module
import {RemoveDuplicate} from './FilterElements.js';

//Click on ques9 in side bar to see the result
document.getElementById("q9").addEventListener("click", ques9);

//function on click event
function ques9(){
    //basic settings for html
    document.getElementById("main_div").style.display="none";
    disableQuestionDiv();
    document.getElementById("div_of_question9").style.display="block";

    //prompt to let user enter his/her choice of array
    const array_to_be_filtered=(prompt("Eneter array in which you want to remove dublications","Please enter array"));
    //to convert string to array
    var array_converted = array_to_be_filtered.split(',');
    //function call to remove dublicate elemets
    var result_array=RemoveDuplicate(array_converted);
    //to display result
    document.getElementById("div_of_question9").innerHTML="The resultened array is: <br/>"+result_array;
}













//------------------------------------------------------------------------------------------------------------->
//Ques10: Write a program to flatten a nested array to single level using arrow functions.

//Click on ques10 in side bar to see the result
document.getElementById("q10").addEventListener("click", ques10);

//function on click event
function ques10(){

    //basic settings for html
    document.getElementById("main_div").style.display="none";
    disableQuestionDiv();
    document.getElementById("div_of_question10").style.display="block";

    //let user enter the array
    var string_for_array=prompt("Enter array for which you want to see flatten of a nested array");

    //convert array to string
    var number_array = JSON.parse("[" + string_for_array + "]");
    //calling the flattenaraay function to flat the nested array
    
    document.getElementById("div_of_question10").innerHTML="The resulted flatten array is :-<br/>"+number_array ;
}


















//------------------------------------------------------------------------------------------------------------->
//Question11:  Implement a singly linked list in es6 and implement addFirst() addLast(), length(), getFirst(), 
//getLast(). (without using array)

//first build a node class
class Node{
    constructor(data, next = null){
        this.data = data,
        this.next = next
    }
}

//create a class for linked list
class LinkedList{
    constructor(){
        this.head = null;
    }
}


//Insert an element in linked list
LinkedList.prototype.insertAtBeggining = function(data){
    let startNode = new Node(data);
    if(!this.head){
        this.head = startNode;
        console.log(startNode.data);
    }
    else{

        startNode.next = this.head;
        this.head=startNode;
    }

}


//Insert an element at the end of the list
LinkedList.prototype.insertAtEnd = function(data){
    let endNode = new Node(data);
    if(!this.head){
        this.head = endNode;
        //return this.head;
    }
    else{

        let tail = this.head;
        while(tail.next !== null){
            tail = tail.next;
        }
        tail.next = endNode;
    }

    //return this.head;
}

//get at starting element of linked list
LinkedList.prototype.getAtFirst = function(){
    let getFirstNode=this.head;
    if(!this.head){
        document.getElementById("check11").innerHTML="Linked list is empty";
    }
    else{
        document.getElementById("check11").innerHTML="The first element of linked list is:-<br/>" +getFirstNode.data;
        
    }
}


//get the end element of linked list
LinkedList.prototype.getAtLast = function(){
    let getLastNode=this.head;
    if(!this.head){
        document.getElementById("check11").innerHTML="Linked list is empty";
    }
    else{
        while(getLastNode.next==null){
            node = node.next;
        }
    }
    document.getElementById("check11").innerHTML="The first element of linked list is:-<br/>" +getLastNode.data;
}


//find length of linked list
LinkedList.prototype.lengthOfList = function(){
    let counter = 0;
    let node = this.head;
    if(!this.head){
        document.getElementById("check11").innerHTML="Linked list is empty";
    }
    else{
        while(node.next!=null){
            counter++;
            node=node.next;
            console.log(counter);
        }
        counter+=1;
        document.getElementById("check11").innerHTML="The length of list is:- <br/>"+counter;
    }
}

//function to get all elemets of linked list
LinkedList.prototype.getAllElements = function(){
    var currentNode = this.head; 
    var resultList = currentNode.data+" ,"; 
    while (currentNode.next!=null) { 
        currentNode = currentNode.next; 
        resultList += currentNode.data + ","; 
    } 
    
    document.getElementById("check11").innerHTML="The resultent list is:<br>"+ resultList;
    
}

//link list formation
var ll=new LinkedList();

//event llistner that will handle the request to show functionality of link list
document.getElementById("q11").addEventListener("click", ques11);

//function on click event for getting all option of link list
function ques11(){

    //basic settings for html
    document.getElementById("main_div").style.display="none";
    disableQuestionDiv();
    document.getElementById("div_of_question11").style.display="block";
    document.getElementById("check11").style.display="block";

}

 //event llistner that will handle the request of getting all elements of linked list
document.getElementById("linkListAllElemets").addEventListener("click",GetlinkListAllElemets);

//function on click event to get all elements of link list
function GetlinkListAllElemets(){
    document.getElementById("check11").style.display="block";
    ll.getAllElements();
}


 //event llistner that will handle the request of insert elements at beggining of linked list 
document.getElementById("linkListInsertBeg").addEventListener("click", linkListInsertBeggining);

//function on click event to handle the insert operation
function linkListInsertBeggining(){
    document.getElementById("check11").style.display="block";
    var data=prompt("Enter data to be inserted at beggining of linked list");
    ll.insertAtBeggining(data);
    ll.getAllElements();
}


//event llistner that will handle the request of insert elements at end of linked list  
document.getElementById("linkListInsertEnd").addEventListener("click", linkListsInsertEnd);

//function on click event to handle the insert operation
function linkListsInsertEnd(){
    document.getElementById("check11").style.display="block";
    var data=prompt("Enter data to be inserted at end of linked list");
    ll.insertAtEnd(data);
    ll.getAllElements();
}

 //event llistner that will handle the request to get length of linked list
document.getElementById("linkListLength").addEventListener("click", linkListsLength);

//function on click event to get length of linked list
function linkListsLength(){
    document.getElementById("check11").style.display="block";
    ll.lengthOfList();
}

 //event llistner that will handle the request to get first elemet of linked list
document.getElementById("linkListGetFirst").addEventListener("click", linkListsGetFirst);

//function on click event to get first element of linked list
function linkListsGetFirst(){
    ll.getAtFirst();
}
//event llistner that will handle the request to get last elemet of linked list
document.getElementById("linkListInsertGetLast").addEventListener("click", linkListsInsertGetLast);

//function on click event to get end element of linked list
function linkListsInsertGetLast(){
    ll.getAtlast();
}











//------------------------------------------------------------------------------------------------------------->
//Question12: Implement Map and Set using Es6
document.getElementById("q12").addEventListener("click", ques12);

//function on click event
function ques12(){
    //basic settings for html
    document.getElementById("main_div").style.display="none";
    disableQuestionDiv();
    document.getElementById("div_of_question12").style.display="block";

    console.log("Below is the output of question 12--------------->")
    let sett = new Set([1, 2, 3, 4, 5, 6]);
    sett.add(7)
    sett.delete(2)
    console.log(sett)

    let mapp = new Map()
    mapp.set("key1","value1")
    mapp.set("key2","value2")
    mapp.set("key3","value3")
    console.log(mapp)
    console.log(mapp.get("key1"))


}













//------------------------------------------------------------------------------------------------------------->
//Question13:  Implementation of stack (using linked list)

//Stack using linkedlist

//first build a node class
class NodeStack{
    constructor(item, next = null){
        this.item = item,
        this.next = next
    }
}

//create a class for stack
class StackUsingLinkedList{
    constructor(){
        this.top = null;
    }
    //Insert operation on stack
    push(item){
        let nodeStack=new NodeStack(item);
        if(this.top){
            nodeStack.next=this.top;
            this.top=nodeStack;
        }
        else{
            this.top=nodeStack;
        }
    }
    //delete operation on stack
    pop() 
    {
        if( this.top ) {
          let itemToPop = this.top
          this.top = this.top.next
          //return itemToPop.data
        } 
        else {
          document.getElementById("check13").innerHTML="The stack is empty";
          return false;
        }
    }
    //return first element without deleting it
    peek() {
        if( this.top ) {
            document.getElementById("check13").innerHTML="Element at top of stack is;- "+this.top.item;
         
        } else {
            document.getElementById("check13").innerHTML="The stack is empty";
        }
    }
    //find length of stack
    length() {
        let current = this.top
        let counter = 0
        while( current ) {
         counter++
         current = current.next
        }
        document.getElementById("check13").innerHTML="The length of stack is;- "+counter;
    }
    //traverse the whle stack
    traverse() 
    {
        if(this.top){
            var current = this.top; 
            var resultStack = current.item+" ,"; 
            while (current.next!=null) { 
                current = current.next; 
                resultStack += current.item + ","; 
            } 
            
            
            document.getElementById("check13").innerHTML="The resultent list is:<br>"+ resultStack;
        }
        else{
            document.getElementById("check13").innerHTML="The stack is empty";   
        }

    }
}





//creating new instance of Stack
let st = new StackUsingLinkedList();   
//event llistner that will handle the request to show functionality of link list
document.getElementById("q13").addEventListener("click", ques13);

//function on click event for getting all option of stack
function ques13(){

    //basic settings for html
    document.getElementById("main_div").style.display="none";
    disableQuestionDiv();
    document.getElementById("div_of_question13").style.display="block";
    document.getElementById("check13").style.display="block";

}
 //event llistner that will handle the request of getting all elements of stack
document.getElementById("stackAllElement").addEventListener("click",allElementsOfStack);

//function on click event to get all elements of stack
function allElementsOfStack(){
    document.getElementById("check13").style.display="block";
    st.traverse();
}


 //event llistner that will handle the request of insert element in stack
document.getElementById("PushStack").addEventListener("click", PushInStack);

//function on click event to handle the innsert operation
function PushInStack(){
    document.getElementById("check13").style.display="block";
    var item=prompt("Enter data to be inserted at beggining of linked list");
    st.push(item);
    st.traverse();

}

 //event llistner that will handle the request of pop elemet of stack
 document.getElementById("popStack").addEventListener("click", pop_Stack);

 //function on click event to handle the pop operation
 function pop_Stack(){
     document.getElementById("check13").style.display="block";
     st.pop();
     st.traverse();
 
 }

 //event llistner that will handle the request to get length of stack
document.getElementById("lengthStack").addEventListener("click", lengthOfStack);

//function on click event to get length of stack
function lengthOfStack(){
    document.getElementById("check11").style.display="block";
    st.length();
}

 //event llistner that will handle the request to get first elemet of stack
document.getElementById("PeekStack").addEventListener("click", Peek_Stack);

//function on click event to get first element of stack
function Peek_Stack(){
    st.peek();
}








//for basic settings of html
function disableQuestionDiv(){
    document.getElementById("div_of_question1").style.display="none";
    document.getElementById("div_of_question2").style.display="none";
    document.getElementById("div_of_question3").style.display="none";
    document.getElementById("div_of_question4").style.display="none";
    document.getElementById("div_of_question5").style.display="none";
    document.getElementById("div_of_question6").style.display="none";
    document.getElementById("div_of_question7").style.display="none";
    document.getElementById("div_of_question8").style.display="none";
    document.getElementById("div_of_question9").style.display="none";
    document.getElementById("div_of_question10").style.display="none"
    document.getElementById("div_of_question11").style.display="none"
    document.getElementById("div_of_question12").style.display="none"
    document.getElementById("div_of_question13").style.display="none"
    document.getElementById("check11").style.display="none"
    document.getElementById("check13").style.display="none"

}
document.getElementById("home_a").addEventListener("click", homeFun);
function homeFun(){
    document.getElementById("main_div").style.display="block";
    disableQuestionDiv();
}




