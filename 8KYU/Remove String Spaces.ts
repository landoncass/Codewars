// Simple, remove the spaces from the string, then return the resultant string.

export function noSpace(x: string): string {
  let newString = "";
  for (let index = 0; index < x.length; index++) {
    if (x[index] === " ") {
      newString += "";
    } else {
      newString += x[index];
    }
  }
  return newString;
}
