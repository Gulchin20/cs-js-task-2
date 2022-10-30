let num = 121858122;
let temp = num;
let sum = 0;
let q;

while(num>0)
{
    q = num % 10;
    num = Math.floor( num / 10);
    sum = sum * 10 + q;
    
}
 if (temp==sum)
{
    console.log("polindirom ededdir");
}
else
{
    console.log("polindirom eded deyil");
}