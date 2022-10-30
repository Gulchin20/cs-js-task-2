 let num=64;
 let q ;
 let p = true;
 while (num>=2 )
 {
    
     q=num % 2;
     num = num / 2;
     if (q!=0)
     {
         p = false;
         console.log("2 nin quvveti deyil");
         break;
     }

    
 }
 if(p)
 {
     console.log("2 nin quvvetidir");
 }

