using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

   
        public static void Main(string[] args)
    {

    }
    
    public static int ServClasseD(){
        //TaxaServ + Hosp
        return 10+200;
    }
    
    public static int ServClasseC(){
        //TaxaServ + Hosp + Cafe + Almoço
        return 10+350+30+70;
    }

public static int ServClasseB(){
        //TaxaServ + Hosp + Cafe + Almoço + Janta
        return 10+350+30+70+80;
    }
    
    public static int ServClasseA(){
        //TaxaServ + Hosp + Cafe + Almoço + Janta + VIP
        return 10+350+30+70+80+500;
    }