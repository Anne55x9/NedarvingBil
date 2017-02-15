using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedarvingBil
{
    public abstract class Bil : IBil
    {
        public int BilPrisExAfgift { get; set; }

        public int KøbsÅr { get; set; }

        public string Mærke { get; set; }

        public string RegistreringsNr { get; set; }

        public int RegistreringsAfgift { get; set; }


        /// <summary>
        /// ingen default ctor længere
        /// </summary>
        /// <param name="pris"></param>

        //public Bil(int pris)
        //{
        //    this.pris = pris;
        //}

        /// <summary>
        /// Afgift må gerne blive overskrevet, behøves ikke men kan godt, deraf virtual navnet
        /// </summary>
        /// <returns></returns>

        public Bil(string mærke, int bilPrisExAfgift, int købsÅr, string registreringsNr) //int kmPrLiter)
        {
            this.Mærke = mærke;
            this.BilPrisExAfgift = bilPrisExAfgift;
            this.KøbsÅr = købsÅr;
            this.RegistreringsNr = registreringsNr;
            //this.KmPrLiter = kmPrLiter;
        }

        public virtual int GetRegistreringsAfgift()
        {

            if (BilPrisExAfgift <= 0)
            {
                throw new HalvÅrligEjerAfgiftException();
                //throw new ArgumentException("BilPris må ikke være 0.");
            }
            //if (KøbsÅr < 2014)
            //{
            //    throw new HalvÅrligEjerAfgiftException();
            //    //throw new ArgumentException("Købsåret er før 2014.");
            //}
  
            RegistreringsAfgift = 0;
          
            if (KøbsÅr <= 2014)
            {
                if (BilPrisExAfgift <= 80500)
                {
                    RegistreringsAfgift = BilPrisExAfgift * 105 / 100;
                }
                else if (BilPrisExAfgift > 80500)
                {
                    RegistreringsAfgift = 80500 * 105/100;
                    RegistreringsAfgift = RegistreringsAfgift + (BilPrisExAfgift - 80500) * 180/100;
                }
            }
            else if (KøbsÅr > 2014 && KøbsÅr <= 2016)
            {
                if (BilPrisExAfgift <= 81700)
                {
                    RegistreringsAfgift = BilPrisExAfgift * 105 / 100;
                }
                else if (BilPrisExAfgift > 81700)
                {
                    RegistreringsAfgift = 81700 * 105 / 100;
                    RegistreringsAfgift = RegistreringsAfgift + (BilPrisExAfgift - 81700) * 180 / 100;
                }
            }
            else 
            {
                if (BilPrisExAfgift <= 106600)
                {
                    RegistreringsAfgift = BilPrisExAfgift * 105 / 100;
                }
                else if (BilPrisExAfgift > 106600)
                {
                    RegistreringsAfgift = 106600 * 105 / 100;
                    RegistreringsAfgift = RegistreringsAfgift + (BilPrisExAfgift - 106600) * 150 / 100;
                }

            }
            return RegistreringsAfgift;
        }

        public int TotalPris()
        {
            return BilPrisExAfgift + GetRegistreringsAfgift();
        }

        public virtual int HalvÅrligEjerafgift()
        {
            return 1000;
        }

        public abstract int GetRækkeVidde();

        //Når overrider hvilkenBilErjeg i de specialiserede klasser 
        //så gælder det og ikke metoden fra base klassen.

        public abstract string HvilkenBilErJeg();
    }
}
