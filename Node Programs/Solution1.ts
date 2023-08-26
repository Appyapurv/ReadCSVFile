function  Solutions1()
{

// array ['1','2','3','6','5']
// decending order
// assending order
// find some value from array
// get the index of value

const array= ['1','4','6','9']
}

// decending order
function decendingArray()
{
    const array= ['1','4','6','9']
    const convertedIntoInt = array.map(x=>parseInt(x));
    convertedIntoInt.sort((a,b)=> b-a);
    convertedIntoInt.slice().sort((a,b)=>b-a);
}

//asseding order
function assedingArray()
{
    const array= ['1','4','6','9']
    const convertedIntoInt= array.map(x=>parseInt(x))
    convertedIntoInt.sort()
}
// find some value from array
function findValue()
{
const array= ['1','4','6','9']
const findValue= '6'

const convertIntoArray = array.map(x=>parseInt(x))
// if(convertIntoArray.includes(findValue))
const index= convertIntoArray.indexOf(parseInt(findValue))
if (index!=-1)
{
    console.log(`the value ${findValue} found at index ${index}`)

}
else
{
    console.log(`the value ${findValue} is not found`)
}
}
