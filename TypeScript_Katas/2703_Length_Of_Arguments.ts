type JSONValue = null | boolean | number | string | JSONValue[] | { [key: string]: JSONValue };

function argumentsLength(...args: JSONValue[]): number {
   var counter: number = 0;

   for(var arg = 0; arg < arguments.length; ++arg){
    ++counter;
   }
   return counter;
};