const solution2=(input:string /*,args:string[]*/)=>{
    const lines=input.split('\n');
    const n=parseInt(lines[0]);
    const arr=lines[1].split(' ').map(x=>parseInt(x));
    const result=arr.reduce((acc,curr)=>acc+curr,0);
    console.log(result);
}