// logic
const solution2=(input:string /*,args:string[]*/)=>{
    const lines=input.split('\n');
    const n=parseInt(lines[0]);
    const arr=lines[1].split(' ').map(x=>parseInt(x));
    const result=arr.reduce((acc,curr)=>acc+curr,0);
    console.log(result);
}

// main
const input=`5
1000000001 1000000002 1000000003 1000000004 1000000005`;
solution2(input);

// test cases
describe('solution2', () => {
  it('should return the sum of all elements in the array', () => {
    const input = '5\n1 2 3 4 5\n';
    const expectedOutput = 15;
    expect(solution2(input)).toEqual(expectedOutput);
  });

  it('should handle an array with only one element', () => {
    const input = '1\n42\n';
    const expectedOutput = 42;
    expect(solution2(input)).toEqual(expectedOutput);
  });

  it('should handle an empty array', () => {
    const input = '0\n\n';
    const expectedOutput = 0;
    expect(solution2(input)).toEqual(expectedOutput);
  });

  it('should handle negative numbers in the array', () => {
    const input = '4\n-1 2 -3 4\n';
    const expectedOutput = 2;
    expect(solution2(input)).toEqual(expectedOutput);
  });

  it('should handle large arrays', () => {
    const input = '1000\n' + Array.from({ length: 1000 }, (_, i) => i + 1).join(' ') + '\n';
    const expectedOutput = 500500;
    expect(solution2(input)).toEqual(expectedOutput);
  });
});
