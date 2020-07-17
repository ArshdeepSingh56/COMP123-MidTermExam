using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;

namespace COMP123_MidTermExam
{  /**
         Name =  Arshdeep Singh
         Student Id no = 301118326
         Course Name =  Programming 2
         Coures Number = COMP123
         Assignment Detail =  Mid-term Test
      **/
    /**
    * <summary>
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            :base(7,49)
        {
            
        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {
            for (int i = 0; i < 7; i++)
            {
                PickElements();
                Console.WriteLine("Ticket no " + (i+1) + ":-  ");
                Console.WriteLine(ToString());
            }
        }
    }
}