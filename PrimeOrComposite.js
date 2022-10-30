let num = 112;
let q;
let i=2;
let t = true;
while(i<num)
{
    q = num % i;
   if( q == 0)
    {
        t = false;
        console.log("murekkeb ededdir");
        break;
    }
    i++;
    
}
if (t)
{
    console.log("sade ededdir");
}