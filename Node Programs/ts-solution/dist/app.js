//- ReadMe- cd Node Programs/ts-solution
// run command tsc to build the solution put debugger in dist file
// and run command node dist/app.js

// solution1
const function1 = (name) => {   
    return `Hello ${name}!`;
};
const person = "apurv3";
const greeting = function1(person);
console.log('message:', greeting);

// solution2
const function2=(array)=>
{
    let sum=0;
    for(let i=0; i<array.length;i++)
    {
        sum+= array[i];
    }
}

const array=[1,2,3,4,5];
const sum = function3(array);
console.log('sum:', sum);

// solution3
const function3=(array)=>
{
    let sum=0;
    for(let i=0; i<array.length;i++)
    {
        sum+= array[i];
    }
    return sum;
}

//- ReadMe