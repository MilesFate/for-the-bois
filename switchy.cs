using System;

namespace switchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Project.\nThis project will show you the basic information of every \nelement of the periodic table.");
            //this is fancy time sleep for c#
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Type the number, name, or symbol of the element you wish to see.");
            //this is for a switch case later
            //that i made to make closing the program easy
            bool exit = false;
            while(exit == false){
    //switch cases are if statements
    //but more efficient due to the amount of cases and how they are choosen
    switch (Console.ReadLine()){
        //abandon all hope ye who enter here
        case "1":
        case "Hydrogen":
        case "hydrogen":
        case "H":
            Console.WriteLine("\tElement Name: Hydrogen");
            Console.WriteLine("\tAtomic Number: 1");
            Console.WriteLine("\tAtomic Weight: 1.008");
            Console.WriteLine("\tState of Matter: Gas");
            Console.WriteLine("\tFamily: Reactive nonmetal");
            Console.WriteLine("\tSymbol: H");
            Console.WriteLine("\tFun Fact: 'Scientists estimate that Hydrogen makes up \n\tover 90 percent of all the atoms in the universe.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "2":
        case "Helium":
        case "helium":
        case "He":
            Console.WriteLine("\tElement Name: Helium");
            Console.WriteLine("\tAtomic Number: 2");
            Console.WriteLine("\tAtomic Weight: 4.0026");
            Console.WriteLine("\tState of Matter: Gas");
            Console.WriteLine("\tFamily: Noble gas");
            Console.WriteLine("\tSymbol: He");
            Console.WriteLine("\tFun Fact: 'Helium is so light that Earth's gravity \n\tis not strong enough to hold on to it.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "3":
        case "Lithium":
        case "lithium":
        case "Li":
            Console.WriteLine("\tElement Name: Lithium");
            Console.WriteLine("\tAtomic Number: 3");
            Console.WriteLine("\tAtomic Weight: 6.94");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Alkali metal");
            Console.WriteLine("\tSymbol: Li");
            Console.WriteLine("\tFun Fact: 'Lithium has the lowest density of any metal.\n\tLithium can float on water.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "4":
        case "Beryllium":
        case "beryllium":
        case "Be":
            Console.WriteLine("\tElement Name: Beryllium");
            Console.WriteLine("\tAtomic Number: 4");
            Console.WriteLine("\tAtomic Weight: 9.0122");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Alkaline earth metals");
            Console.WriteLine("\tSymbol: Be");
            Console.WriteLine("\tFun Fact: 'Only three countries, the United States, China, \n\tand Kazakhstan currently process beryllium ores and \n\tconcentrates into beryllium products. ");
            Console.WriteLine("\tChoice another Element or type quit.'");
            break;
        case "5":
        case "Boron":
        case "boron":
        case "B":
            Console.WriteLine("\tElement Name: Boron");
            Console.WriteLine("\tAtomic Number: 5");
            Console.WriteLine("\tAtomic Weight: 10.81");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Metalloids");
            Console.WriteLine("\tSymbol: B");
            Console.WriteLine("\tFun Fact: 'Boron has the highest melting point of the metalloids.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "6":
        case "Carbon":
        case "carbon":
        case "C":
            Console.WriteLine("\tElement Name: Carbon");
            Console.WriteLine("\tAtomic Number: 6");
            Console.WriteLine("\tAtomic Weight: 12.011");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Reactive Nonmetals");
            Console.WriteLine("\tSymbol: C");
            Console.WriteLine("\tFun Fact: 'Diamonds and graphite are among the hardest and softest \n\tnatural materials known, respectively. The only difference between the \n\ttwo is their crystal structure.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "7":
        case "Nitrogen":
        case "nitrogen":
        case "N":
            Console.WriteLine("\tElement Name: Nitrogen");
            Console.WriteLine("\tAtomic Number: 7");
            Console.WriteLine("\tAtomic Weight: 14.007");
            Console.WriteLine("\tState of Matter: Gas");
            Console.WriteLine("\tFamily: Reactive Nonmetals");
            Console.WriteLine("\tSymbol: N");
            Console.WriteLine("\tFun Fact: 'Nitrogen has no odor,  is tasteless, and colorless.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "8":
        case "Oxygen":
        case "oxygen":
        case "O":
            Console.WriteLine("\tElement Name: Oxygen");
            Console.WriteLine("\tAtomic Number: 8");
            Console.WriteLine("\tAtomic Weight: 15.999");
            Console.WriteLine("\tState of Matter: Gas");
            Console.WriteLine("\tFamily: Reactive Nonmetals");
            Console.WriteLine("\tSymbol: O");
            Console.WriteLine("\tFun Fact: 'Animals and plants require oxygen for respiration.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "9":
        case "Fluorine":
        case "fluorine":
        case "F":
            Console.WriteLine("\tElement Name: Fluorine");
            Console.WriteLine("\tAtomic Number: 9");
            Console.WriteLine("\tAtomic Weight: 18.998");
            Console.WriteLine("\tState of Matter: Gas");
            Console.WriteLine("\tFamily: Reactive Nonmetals");
            Console.WriteLine("\tSymbol: F");
            Console.WriteLine("\tFun Fact: 'Fluorine is the most reactive and the most \n\telectronegative of all the elements.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "10":
        case "Neon":
        case "neon":
        case "Ne":
            Console.WriteLine("\tElement Name: Neon");
            Console.WriteLine("\tAtomic Number: 10");
            Console.WriteLine("\tAtomic Weight: 20.180");
            Console.WriteLine("\tState of Matter: Gas");
            Console.WriteLine("\tFamily: Noble Gases");
            Console.WriteLine("\tSymbol: Ne");
            Console.WriteLine("\tFun Fact: 'Neon has over forty times the refrigerating ability of \n\tliquid helium and three times that of liquid hydrogen.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "11":
        case "Sodium":
        case "sodium":
        case "Na":
            Console.WriteLine("\tElement Name: Sodium");
            Console.WriteLine("\tAtomic Number: 11");
            Console.WriteLine("\tAtomic Weight: 22.990");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Alkali Metals");
            Console.WriteLine("\tSymbol: Na");
            Console.WriteLine("\tFun Fact: 'Molten sodium is used as a heat transfer medium in some \n\tfast nuclear reactors.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "12":
        case "Magnesium":
        case "magnesium":
        case "Mg":
            Console.WriteLine("\tElement Name: Magnesium");
            Console.WriteLine("\tAtomic Number: 12");
            Console.WriteLine("\tAtomic Weight: 24.305");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Alkaline earth metal");
            Console.WriteLine("\tSymbol: Mg");
            Console.WriteLine("\tFun Fact: 'Magnesium burns very brightly and is used in fireworks \n\tto make white sparkles.'");
            Console.WriteLine("\tThis is also my favorite Element");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "13":
        case "Aluminium":
        case "aluminium":
        case "Al":
            Console.WriteLine("\tElement Name: Aluminium");
            Console.WriteLine("\tAtomic Number: 13");
            Console.WriteLine("\tAtomic Weight: 26.982");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Post-Transition Metal");
            Console.WriteLine("\tSymbol: Al");
            Console.WriteLine("\tFun Fact: 'It’s the World’s Most Abundant Metal.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "14":
        case "Silicon":
        case "silicon":
        case "Si":
            Console.WriteLine("\tElement Name: Silicon");
            Console.WriteLine("\tAtomic Number: 14");
            Console.WriteLine("\tAtomic Weight: 28.085");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Metalloid");
            Console.WriteLine("\tSymbol: Si");
            Console.WriteLine("\tFun Fact: 'Sand has a high percentage of silicon and is the starting \n\tmaterial to make high-purity silicon wafers on which semiconductor \n\tdevices are made.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "15":
        case "Phosphorus":
        case "phosphorus":
        case "P":
            Console.WriteLine("\tElement Name: Phosphorus");
            Console.WriteLine("\tAtomic Number: 15");
            Console.WriteLine("\tAtomic Weight: 30.974");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Reactive Nonmetal");
            Console.WriteLine("\tSymbol: P");
            Console.WriteLine("\tFun Fact: 'Phosphorus is highly reactive. \n\tIt is not found free in nature.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "16":
        case "Sulfur":
        case "sulfur":
        case "S":
            Console.WriteLine("\tElement Name: Sulfur");
            Console.WriteLine("\tAtomic Number: 16");
            Console.WriteLine("\tAtomic Weight: 32.06");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Reactive Nonmetal");
            Console.WriteLine("\tSymbol: S");
            Console.WriteLine("\tFun Fact: 'Sulfur makes up almost 3 percent of the \n\tEarth's mass, according to Chemicool.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "17":
        case "Chlorine":
        case "chlorine":
        case "Cl":
            Console.WriteLine("\tElement Name: Chlorine");
            Console.WriteLine("\tAtomic Number: 17");
            Console.WriteLine("\tAtomic Weight: 35.45");
            Console.WriteLine("\tState of Matter: Gas");
            Console.WriteLine("\tFamily: Reactive Nonmetals");
            Console.WriteLine("\tSymbol: Cl");
            Console.WriteLine("\tFun Fact: 'Chlorine gas is has a yellow-green color and a strong smell.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "18":
        case "Argon":
        case "argon":
        case "Ar":
            Console.WriteLine("\tElement Name: Argon");
            Console.WriteLine("\tAtomic Number: 18");
            Console.WriteLine("\tAtomic Weight: 39.948");
            Console.WriteLine("\tState of Matter: Gas");
            Console.WriteLine("\tFamily: Noble Gas");
            Console.WriteLine("\tSymbol: Ar");
            Console.WriteLine("\tFun Fact: 'Argon is produced industrially by cryogenically \n\tdistilling air.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "19":
        case "Potassium":
        case "potassium":
        case "K":
            Console.WriteLine("\tElement Name: Potassium");
            Console.WriteLine("\tAtomic Number: 19");
            Console.WriteLine("\tAtomic Weight: 39.098");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Alkali Metals");
            Console.WriteLine("\tSymbol: K");
            Console.WriteLine("\tFun Fact: 'Potassium was the first metal to be \n\tdiscovered by electrolysis.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "20":
        case "Calcium":
        case "calcium":
        case "Ca":
            Console.WriteLine("\tElement Name: Calcium");
            Console.WriteLine("\tAtomic Number: 20");
            Console.WriteLine("\tAtomic Weight: 40.078");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Alkaline Earth Metals");
            Console.WriteLine("\tSymbol: Ca");
            Console.WriteLine("\tFun Fact: 'Calcium forms alloys with aluminum, \n\tberyllium, copper, lead, and magnesium.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "21":
        case "Scandium":
        case "scandium":
        case "Sc":
            Console.WriteLine("\tElement Name: Scandium");
            Console.WriteLine("\tAtomic Number: 21");
            Console.WriteLine("\tAtomic Weight: 44.956");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metals");
            Console.WriteLine("\tSymbol: Sc");
            Console.WriteLine("\tFun Fact: 'The color associated with aquamarine \n\tgemstones is due to the presence of scandium.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "22":
        case "Titanium":
        case "titanium":
        case "Ti":
            Console.WriteLine("\tElement Name: Titanium");
            Console.WriteLine("\tAtomic Number: 22");
            Console.WriteLine("\tAtomic Weight: 47.867");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metals");
            Console.WriteLine("\tSymbol: Ti");
            Console.WriteLine("\tFun Fact: 'Titanium is Naturally Resistant to Corrosion.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "23":
        case "Vanadium":
        case "vanadium":
        case "V":
            Console.WriteLine("\tElement Name: Vanadium");
            Console.WriteLine("\tAtomic Number: 23");
            Console.WriteLine("\tAtomic Weight: 50.942");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metals");
            Console.WriteLine("\tSymbol: V");
            Console.WriteLine("\tFun Fact: 'One of the first uses of vanadium was in the \n\tsteel chassis of the 1908 Model T Ford.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "24":
        case "Chromium":
        case "chromium":
        case "Cr":
            Console.WriteLine("\tElement Name: Chromium");
            Console.WriteLine("\tAtomic Number: 24");
            Console.WriteLine("\tAtomic Weight: 51.996");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metals");
            Console.WriteLine("\tSymbol: Cr");
            Console.WriteLine("\tFun Fact: 'Chromium is the Hardest Metal.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "25":
        case "Manganese":
        case "manganese":
        case "Mn":
            Console.WriteLine("\tElement Name: Manganese");
            Console.WriteLine("\tAtomic Number: 25");
            Console.WriteLine("\tAtomic Weight: 54.938");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metals");
            Console.WriteLine("\tSymbol: Mn");
            Console.WriteLine("\tFun Fact: 'Pure manganese is reactive, burns in oxygen, rusts in \n\twater and dissolves in dilute acids, according to Lenntech.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "26":
        case "Iron":
        case "iron":
        case "Fe":
            Console.WriteLine("\tElement Name: Iron");
            Console.WriteLine("\tAtomic Number: 26");
            Console.WriteLine("\tAtomic Weight: 55.845");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metals");
            Console.WriteLine("\tSymbol: Fe");
            Console.WriteLine("\tFun Fact: 'Iron was most likely first discovered before the \n\t5th millennium BC (5000 BC).'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "27":
        case "Cobalt":
        case "cobalt":
        case "Co":
            Console.WriteLine("\tElement Name: Cobalt");
            Console.WriteLine("\tAtomic Number: 27");
            Console.WriteLine("\tAtomic Weight: 58.933");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metals");
            Console.WriteLine("\tSymbol: Co");
            Console.WriteLine("\tFun Fact: 'Pure Cobalt does not naturally exist on earth.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "28":
        case "Nickel":
        case "nickel":
        case "Ni":
            Console.WriteLine("\tElement Name: Nickel");
            Console.WriteLine("\tAtomic Number: 28");
            Console.WriteLine("\tAtomic Weight: 58.693");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metals");
            Console.WriteLine("\tSymbol: Ni");
            Console.WriteLine("\tFun Fact: 'Nickel plays a role in the cells of plants \n\tand some microorganisms.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "29":
        case "Copper":
        case "copper":
        case "Cu":
            Console.WriteLine("\tElement Name: Copper");
            Console.WriteLine("\tAtomic Number: 29");
            Console.WriteLine("\tAtomic Weight: 63.546");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metals");
            Console.WriteLine("\tSymbol: Cu");
            Console.WriteLine("\tFun Fact: 'The Statue of Liberty is made from 179,000 \n\tpounds of copper.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "30":
        case "Zinc":
        case "zinc":
        case "Zn":
            Console.WriteLine("\tElement Name: Zinc");
            Console.WriteLine("\tAtomic Number: 30");
            Console.WriteLine("\tAtomic Weight: 65.38");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metals");
            Console.WriteLine("\tSymbol: Zn");
            Console.WriteLine("\tFun Fact: 'Recently, zinc is found to enhance eyesight, preventing the \n\tonset of macular degeneration.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "31":
        case "Gallium":
        case "gallium":
        case "Ga":
            Console.WriteLine("\tElement Name: Gallium");
            Console.WriteLine("\tAtomic Number: 31");
            Console.WriteLine("\tAtomic Weight: 69.723");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Post-transition metal");
            Console.WriteLine("\tSymbol: Ga");
            Console.WriteLine("\tFun Fact: 'Liquid gallium cannot be kept in a glass or metal container \n\tbecause it expands 3.1 percent when it freezes.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "32":
        case "Germanium":
        case "germanium":
        case "Ge":
            Console.WriteLine("\tElement Name: Germanium");
            Console.WriteLine("\tAtomic Number: 32");
            Console.WriteLine("\tAtomic Weight: 72.630");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Metalloid");
            Console.WriteLine("\tSymbol: Ge");
            Console.WriteLine("\tFun Fact: 'Scientists are studying germanium for use in chemotherapy to \n\thelp treat cancer.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "33":
        case "Arsenic":
        case "arsenic":
        case "As":
            Console.WriteLine("\tElement Name: Arsenic");
            Console.WriteLine("\tAtomic Number: 33");
            Console.WriteLine("\tAtomic Weight: 74.922");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Metalloids");
            Console.WriteLine("\tSymbol: As");
            Console.WriteLine("\tFun Fact: 'Arsenic is a well-known poison. Arsenic compounds are \n\tsometimes used as rat poisons and \n\tinsecticides but their use is strictly controlled.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "34":
        case "Selenium":
        case "selenium":
        case "Se":
            Console.WriteLine("\tElement Name: Selenium");
            Console.WriteLine("\tAtomic Number: 34");
            Console.WriteLine("\tAtomic Weight: 78.971");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Reactive Nonmetal");
            Console.WriteLine("\tSymbol: Se");
            Console.WriteLine("\tFun Fact: 'When light is shown on selenium, it conducts electricity \n\tbetter. The brighter the light, the better the better the conduction \n\tis, according to Jefferson Lab.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "35":
        case "Bromine":
        case "bromine":
        case "Br":
            Console.WriteLine("\tElement Name: Bromine");
            Console.WriteLine("\tAtomic Number: 35");
            Console.WriteLine("\tAtomic Weight: 79.904");
            Console.WriteLine("\tState of Matter: Liquid");
            Console.WriteLine("\tFamily: Reactive Nonmetal");
            Console.WriteLine("\tSymbol: Br");
            Console.WriteLine("\tFun Fact: One of only a few elements that are naturally a liquid.");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "36":
        case "Krypton":
        case "krypton":
        case "Kr":
            Console.WriteLine("\tElement Name: Krypton");
            Console.WriteLine("\tAtomic Number: 36");
            Console.WriteLine("\tAtomic Weight: 83.798");
            Console.WriteLine("\tState of Matter: Gas");
            Console.WriteLine("\tFamily: Noble Gases");
            Console.WriteLine("\tSymbol: Kr");
            Console.WriteLine("\tFun Fact: 'When exposed to an electrical current under low pressure, \n\tkrypton gas lights up like neon.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "37":
        case "Rubidium":
        case "rubidium":
        case "Rb":
            Console.WriteLine("\tElement Name: Rubidium");
            Console.WriteLine("\tAtomic Number: 37");
            Console.WriteLine("\tAtomic Weight: 85.468");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Alkali Metals");
            Console.WriteLine("\tSymbol: Rb");
            Console.WriteLine("\tFun Fact: 'Rubidium chloride is used in biochemistry as a biomarker \n\tto track where potassium is taken up by living organisms.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "38":
        case "Strontium":
        case "strontium":
        case "Sr":
            Console.WriteLine("\tElement Name: Strontium");
            Console.WriteLine("\tAtomic Number: 38");
            Console.WriteLine("\tAtomic Weight: 87.62");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Alkaline Earth Metal");
            Console.WriteLine("\tSymbol: Sr");
            Console.WriteLine("\tFun Fact: 'It was used then to produce sugar from the sugar beet plant.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "39":
        case "Yttrium":
        case "yttrium":
        case "Y":
            Console.WriteLine("\tElement Name: Yttrium");
            Console.WriteLine("\tAtomic Number: 39");
            Console.WriteLine("\tAtomic Weight: 88.906");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metal");
            Console.WriteLine("\tSymbol: Y");
            Console.WriteLine("\tFun Fact: ' This mineral was found in Ytterby, Sweden, \n\tgiving it its name.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "40":
        case "Zirconium":
        case "zironium":
        case "Zr":
            Console.WriteLine("\tElement Name: Zirconium");
            Console.WriteLine("\tAtomic Number: 40");
            Console.WriteLine("\tAtomic Weight: 91.224");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metal");
            Console.WriteLine("\tSymbol: Zr");
            Console.WriteLine("\tFun Fact: 'South Africa and Australia possess the most abundant sources \n\tof this metal.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "41":
        case "Niobium":
        case "niobium":
        case "Nb":
            Console.WriteLine("\tElement Name: Niobium");
            Console.WriteLine("\tAtomic Number: 41");
            Console.WriteLine("\tAtomic Weight: 92.906");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metal");
            Console.WriteLine("\tSymbol: Nb");
            Console.WriteLine("\tFun Fact: 'Niobium uses include pipeline construction, superalloys \n\tfor heat resistant equipment including jet engines, \n\tand in jewelry.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "42":
        case "Molybdenum":
        case "molybdenum":
        case "Mo":
            Console.WriteLine("\tElement Name: Molybdenum");
            Console.WriteLine("\tAtomic Number: 42");
            Console.WriteLine("\tAtomic Weight: 95.95");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metals");
            Console.WriteLine("\tSymbol: Mo");
            Console.WriteLine("\tFun Fact: 'Molybdenite, or molybdena, is a soft black mineral once \n\tused to make pencils. The mineral was thought to contain lead \n\tand was often confused for graphite.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "43":
        case "Technetium":
        case "technetium":
        case "Tc":
            Console.WriteLine("\tElement Name: Technetium");
            Console.WriteLine("\tAtomic Number: 43");
            Console.WriteLine("\tAtomic Weight: 98");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metal");
            Console.WriteLine("\tSymbol: Tc");
            Console.WriteLine("\tFun Fact: 'Technetium serves a key role in nuclear medicine.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "44":
        case "Ruthenium":
        case "ruthenium":
        case "Ru":
            Console.WriteLine("\tElement Name: Ruthenium");
            Console.WriteLine("\tAtomic Number: 44");
            Console.WriteLine("\tAtomic Weight: 101.07");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metal");
            Console.WriteLine("\tSymbol: Ru");
            Console.WriteLine("\tFun Fact: 'Ruthenium was the last of the platinum group metals \n\tto be discovered.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "45":
        case "Rhodium":
        case "rhodium":
        case "Rh":
            Console.WriteLine("\tElement Name: Rhodium");
            Console.WriteLine("\tAtomic Number: 45");
            Console.WriteLine("\tAtomic Weight: 102.91");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metals");
            Console.WriteLine("\tSymbol: Rh");
            Console.WriteLine("\tFun Fact: 'An alloy of rhodium-platinum is used in heart pacemakers.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "46":
        case "Palladium":
        case "palladium":
        case "Pd":
            Console.WriteLine("\tElement Name: Palladium");
            Console.WriteLine("\tAtomic Number: 47");
            Console.WriteLine("\tAtomic Weight: 106.42");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition Metals");
            Console.WriteLine("\tSymbol: Pd");
            Console.WriteLine("\tFun Fact: 'Palladium is relatively biologically inactive, but can \n\tcause allergic reactions in some people.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "47":
        case "Silver":
        case "silver":
        case "Ag":
            Console.WriteLine("\tElement Name: Silver");
            Console.WriteLine("\tAtomic Number: 47");
            Console.WriteLine("\tAtomic Weight: 107.87");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition metals");
            Console.WriteLine("\tSymbol: Ag");
            Console.WriteLine("\tFun Fact: 'Silver has the highest thermal conductivity of any element'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "48":
        case "Cadmium":
        case "cadmium":
        case "Cd":
            Console.WriteLine("\tElement Name: Cadmium");
            Console.WriteLine("\tAtomic Number: 48");
            Console.WriteLine("\tAtomic Weight: 112.41");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Transition metals");
            Console.WriteLine("\tSymbol: Cd");
            Console.WriteLine("\tFun Fact: 'Cadmium is toxic and can lead to cadmium poisoning.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "49":
        case "Indium":
        case "indium":
        case "In":
            Console.WriteLine("\tElement Name: Indium");
            Console.WriteLine("\tAtomic Number: 49");
            Console.WriteLine("\tAtomic Weight: 114.82");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Post-Transition Metal");
            Console.WriteLine("\tSymbol: In");
            Console.WriteLine("\tFun Fact: 'Indium metal gives off a high-pitched scream, when bent.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "50":
        case "Tin":
        case "tin":
        case "Sn":
            Console.WriteLine("\tElement Name: Tin");
            Console.WriteLine("\tAtomic Number: 50");
            Console.WriteLine("\tAtomic Weight: 118.71");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Post-Transition Metal");
            Console.WriteLine("\tSymbol: Sn");
            Console.WriteLine("\tFun Fact: 'When tin is bent at room temperature, it makes a high-pitched\n\tcreaking sound known as the tin cry.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "51":
        case "Antimony":
        case "antimony":
        case "Sb":
            Console.WriteLine("\tElement Name: Antimony");
            Console.WriteLine("\tAtomic Number: 51");
            Console.WriteLine("\tAtomic Weight: 121.76");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Metalloid");
            Console.WriteLine("\tSymbol: Sb");
            Console.WriteLine("\tFun Fact: 'Antimony was used in ancient Egypt as a form of \n\teyeliner (kohl).'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "52":
        case "Tellurium":
        case "tellurium":
        case "Te":
            Console.WriteLine("\tElement Name: Tellurium");
            Console.WriteLine("\tAtomic Number: 52");
            Console.WriteLine("\tAtomic Weight: 127.60");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Metalloids");
            Console.WriteLine("\tSymbol: Te");
            Console.WriteLine("\tFun Fact: 'Tellurium is one of the rarest elements on Earth, \n\tbut is abundant in space.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "53":
        case "Iodine":
        case "iodine":
        case "I":
            Console.WriteLine("\tElement Name: Iodine");
            Console.WriteLine("\tAtomic Number: 53");
            Console.WriteLine("\tAtomic Weight: 126.90");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Reactive nonmetal");
            Console.WriteLine("\tSymbol: I");
            Console.WriteLine("\tFun Fact: 'Iodine is a good test for starch as it turns a deep blue \n\tcolor when it comes in contact with it.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "54":
        case "Xenon":
        case "xenon":
        case "Xe":
            Console.WriteLine("\tElement Name: Xenon");
            Console.WriteLine("\tAtomic Number: 54");
            Console.WriteLine("\tAtomic Weight: 131.29");
            Console.WriteLine("\tState of Matter: Gas");
            Console.WriteLine("\tFamily: Noble Gases");
            Console.WriteLine("\tSymbol: Xe");
            Console.WriteLine("\tFun Fact: 'Xenon is a trace element in the Earth's atmosphere.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "55":
        case "Caesium":
        case "caesium":
        case "Cs":
            Console.WriteLine("\tElement Name: Caesium");
            Console.WriteLine("\tAtomic Number: 55");
            Console.WriteLine("\tAtomic Weight: 132.91");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Alkali Metals");
            Console.WriteLine("\tSymbol: Cs");
            Console.WriteLine("\tFun Fact: 'It was the first element ever to be discovered using the \n\tnewly created spectroscope.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "56":
        case "Barium":
        case "barium":
        case "Ba":
            Console.WriteLine("\tElement Name: Barium");
            Console.WriteLine("\tAtomic Number: 56");
            Console.WriteLine("\tAtomic Weight: 137.33");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Alkaline Earth Metals");
            Console.WriteLine("\tSymbol: Ba");
            Console.WriteLine("\tFun Fact: 'Its half-life is longer than the age of the Universe by \n\tas much as one thousand times.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "57":
        case "Lanthanum":
        case "lanthanum":
        case "La":
            Console.WriteLine("\tElement Name: Lanthanum");
            Console.WriteLine("\tAtomic Number: 57");
            Console.WriteLine("\tAtomic Weight: 138.91");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: La");
            Console.WriteLine("\tFun Fact: 'It is the first member of the periodic table's \n\tlanthanides series.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "58":
        case "Cerium":
        case "cerium":
        case "Ce":
            Console.WriteLine("\tElement Name: Cerium");
            Console.WriteLine("\tAtomic Number: 58");
            Console.WriteLine("\tAtomic Weight: 140.12");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Ce");
            Console.WriteLine("\tFun Fact: 'It is practically non-existent in the \n\tatmosphere.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "59":
        case "Praseodyium":
        case "praseodyium":
        case "Pr":
            Console.WriteLine("\tElement Name: Praseodymium");
            Console.WriteLine("\tAtomic Number: 59");
            Console.WriteLine("\tAtomic Weight: 140.91");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Pr");
            Console.WriteLine("\tFun Fact: 'Storing praseodymium in mineral oil or \n\tin sealed glass prevents this oxidation.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "60":
        case "Neodymium":
        case "neodymium":
        case "Nd":
            Console.WriteLine("\tElement Name: Neodymium");
            Console.WriteLine("\tAtomic Number: 60");
            Console.WriteLine("\tAtomic Weight: 144.24");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Nd");
            Console.WriteLine("\tFun Fact: 'It is most often found as a component \n\tin monazite and bastnasite minerals.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "61":
        case "Promethium":
        case "promethium":
        case "Pm":
            Console.WriteLine("\tElement Name: Promethium");
            Console.WriteLine("\tAtomic Number: Pm");
            Console.WriteLine("\tAtomic Weight: 145");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Pm");
            Console.WriteLine("\tFun Fact: 'Because of its radioactivity, promethium \n\tis considered toxic.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "62":
        case "Samarium":
        case "samarium":
        case "Sm":
            Console.WriteLine("\tElement Name: Samarium");
            Console.WriteLine("\tAtomic Number: 62");
            Console.WriteLine("\tAtomic Weight: 150.36");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Sm");
            Console.WriteLine("\tFun Fact: 'Ingesting the right dose of samarium chloride will \n\tallow it to bind with alcohol and prevent you from \n\tgetting intoxicated.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "63":
        case "Europium":
        case "europium":
        case "Eu":
            Console.WriteLine("\tElement Name: Europium");
            Console.WriteLine("\tAtomic Number: 63");
            Console.WriteLine("\tAtomic Weight: 151.96");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Eu");
            Console.WriteLine("\tFun Fact: 'Europium is about as hard as lead and is quite \n\tductile.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "64":
        case "Gadolinium":
        case "gadolinium":
        case "Gd":
            Console.WriteLine("\tElement Name: Gadolinium");
            Console.WriteLine("\tAtomic Number: 64");
            Console.WriteLine("\tAtomic Weight: 157.25");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Gd");
            Console.WriteLine("\tFun Fact: 'Gadolinium has superconductive properties.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "65":
        case "Terbium":
        case "terbium":
        case "Tb":
            Console.WriteLine("\tElement Name: Terbium");
            Console.WriteLine("\tAtomic Number: 65");
            Console.WriteLine("\tAtomic Weight: 158.93");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Tb");
            Console.WriteLine("\tFun Fact: 'Since terbium was used to manufacture the first rewritable \n\tCD, the element has been represented by the compact \n\tdisc symbol.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "66":
        case "Dysprosium":
        case "dysprosium":
        case "Dy":
            Console.WriteLine("\tElement Name: Dysprosium");
            Console.WriteLine("\tAtomic Number: 66");
            Console.WriteLine("\tAtomic Weight: 162.50");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Dy");
            Console.WriteLine("\tFun Fact: 'The abundance of dysprosium is 5.2 mg/kg in the Earth's \n\tcrust and 0.9 ng/L in sea water.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "67":
        case "Holmium":
        case "hulmium":
        case "Ho":
            Console.WriteLine("\tElement Name: Holmium");
            Console.WriteLine("\tAtomic Number: 67");
            Console.WriteLine("\tAtomic Weight: 164.93");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Ho");
            Console.WriteLine("\tFun Fact: 'Holmium does not react in dry air at normal temperatures, \n\tbut rapidly oxidizes to a yellow oxide (Ho2O3) in moist \n\tair or when heated.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "68":
        case "Erbium":
        case "erbium":
        case "Er":
            Console.WriteLine("\tElement Name: Erbium");
            Console.WriteLine("\tAtomic Number: 68");
            Console.WriteLine("\tAtomic Weight: 167.26");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Er");
            Console.WriteLine("\tFun Fact: 'Erbium is used in alloys especially with vanadium to \n\tdecrease the hardness of metals.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "69":
        case "Thulium":
        case "thulium":
        case "Tm":
            Console.WriteLine("\tElement Name: Thulium");
            Console.WriteLine("\tAtomic Number: 69");
            Console.WriteLine("\tAtomic Weight: 168.93");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Tm");
            Console.WriteLine("\tFun Fact: 'Thulium is not toxic, although it has no known \n\tbiological function.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "70":
        case "Ytterbium":
        case "ytterbium":
        case "Yb":
            Console.WriteLine("\tElement Name: Ytterbium");
            Console.WriteLine("\tAtomic Number: 70");
            Console.WriteLine("\tAtomic Weight: 173.05");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Yb");
            Console.WriteLine("\tFun Fact: 'Uses of ytterbium include use as a radiation source for \n\tx-ray machines.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "71":
        case "Lutetium":
        case "lutetium":
        case "Lu":
            Console.WriteLine("\tElement Name: Lutetium");
            Console.WriteLine("\tAtomic Number: 71");
            Console.WriteLine("\tAtomic Weight: 174.97");
            Console.WriteLine("\tState of Matter: Solid");
            Console.WriteLine("\tFamily: Lanthanoids");
            Console.WriteLine("\tSymbol: Lu");
            Console.WriteLine("\tFun Fact: 'Only 2.5% of the lutetium found on Earth is in the \n\tunstable form.'");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "72":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "73":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "74":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "75":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "76":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "77":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "78":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "79":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "80":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "81":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "82":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "83":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "84":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "85":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "86":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "87":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "88":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "89":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "90":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "91":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "92":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "93":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "94":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "95":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "96":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "97":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "98":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "99":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "100":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "101":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "102":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "103":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "104":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "105":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "106":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "107":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "108":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "109":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "110":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "111":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "112":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "113":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "114":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;  
        case "115":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "116":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        case "117":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break; 
        case "118":
            Console.WriteLine("\tElement Name: ");
            Console.WriteLine("\tAtomic Number: ");
            Console.WriteLine("\tAtomic Weight: ");
            Console.WriteLine("\tState of Matter: ");
            Console.WriteLine("\tFamily: ");
            Console.WriteLine("\tSymbol: ");
            Console.WriteLine("\tFun Fact: ");
            Console.WriteLine("\tChoice another Element or type quit.");
            break;
        //these are just to break the while loop and close the program
        //this is much better then telling the user to ctrl c
        case "quit":
        case "Quit":
        case "exit":
        case "Exit":
        case "au revoir shoshanna": // nice little joke
            exit = true;
            break;
                }
            }
        }
    }
}