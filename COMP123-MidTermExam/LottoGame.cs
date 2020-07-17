using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{     /**
         Name =  Arshdeep Singh
         Student Id no = 301118326
         Course Name =  Programming 2
         Coures Number = COMP123
         Assignment Detail =  Mid-term Test
      **/
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE private fields here --------------------------------------------
        private List<int> _elementList;

        private int _elementNumber;

        private List<int> _numberList;

        private Random _random;

        private int _setSize;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE public properties here -----------------------------------------

        // this property will have all the random pick numbers from the NumberList and called as ElementList


        public List<int> ElementList
        {
            get
            {
                return this._elementList;
            }
        }


        //this poperty shows the count of random number has to be generated and known as ElementNumber


        public int ElementNumber
        {
            get
            {
                return this._elementNumber;
            }
            set
            {
                this._elementNumber = value;
            }
        }

        // this property stores all number from 1 to 49 and called NumberList


        public List<int> NumberList
        {
            get
            {
                return this._numberList;
            }
        }


        // this property picks the random number

        public Random random
        {
            get
            {
                return this._random;
            }
        }


        // the SetSize property is for the number of numberlist

        public int SetSize
        {
            get
            {
                return this._setSize;
            }
            set
            {
                this._setSize = value;
            }
        }


        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the private _initialize method here -----------------------------
        private void _initialize()
        {

            this._elementList = new List<int>();
            this._numberList = new List<int>();
            this._random = new Random();
        }
        // CREATE the private _build method here -----------------------------------
        private void _build()
        {

            for (int i = 0; i < SetSize; i++)
            {
                NumberList.Add(i + 1);
            }
        }
        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the public PickElements method here ----------------------------
        public void PickElements()
        {
           

            if (ElementList.Count > 0)
            {
                ElementList.Clear();
                NumberList.Clear();

                this._build();
            }

            for (int i = 0; i < ElementNumber; i++)
            {
               int chance = this.random.Next(0, NumberList.Count);
                NumberList.Remove(chance);
                ElementList.Add(chance);
                
            }
            ElementList.Sort();
        }
    }
}
