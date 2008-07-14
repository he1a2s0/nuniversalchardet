
namespace Mozilla.NUniversalCharDet.Prober.StateMachine
{
    public class ISO2022CNSMModel : SMModel
    {
        ////////////////////////////////////////////////////////////////
        // constants
        ////////////////////////////////////////////////////////////////
        public static int ISO2022CN_CLASS_FACTOR = 9;


        ////////////////////////////////////////////////////////////////
        // methods
        ////////////////////////////////////////////////////////////////
        public ISO2022CNSMModel()
            : base(
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, iso2022cnClassTable),
                ISO2022CN_CLASS_FACTOR,
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, iso2022cnStateTable),
                iso2022cnCharLenTable,
                Constants.CHARSET_ISO_2022_CN
                )
        {

        }


        ////////////////////////////////////////////////////////////////
        // constants continued
        ////////////////////////////////////////////////////////////////
        private static int[] iso2022cnClassTable = new int[] {
            2,	        //PkgInt.pack4bits(2,0,0,0,0,0,0,0),  // 00 - 07 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 08 - 0f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 10 - 17 
            4096,	        //PkgInt.pack4bits(0,0,0,1,0,0,0,0),  // 18 - 1f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 20 - 27 
            48,	        //PkgInt.pack4bits(0,3,0,0,0,0,0,0),  // 28 - 2f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 30 - 37 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 38 - 3f 
            16384,	        //PkgInt.pack4bits(0,0,0,4,0,0,0,0),  // 40 - 47 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 48 - 4f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 50 - 57 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 58 - 5f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 60 - 67 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 68 - 6f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 70 - 77 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 78 - 7f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 80 - 87 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 88 - 8f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 90 - 97 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 98 - 9f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // a0 - a7 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // a8 - af 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // b0 - b7 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // b8 - bf 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // c0 - c7 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // c8 - cf 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // d0 - d7 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // d8 - df 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // e0 - e7 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // e8 - ef 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // f0 - f7 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2)   // f8 - ff 
    };

        private static int[] iso2022cnStateTable = new int[] {
            304,	        //PkgInt.pack4bits(START,    3,ERROR,START,START,START,START,START),//00-07 
            286331152,	        //PkgInt.pack4bits(START,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//08-0f 
            572662289,	        //PkgInt.pack4bits(ERROR,ERROR,ITSME,ITSME,ITSME,ITSME,ITSME,ITSME),//10-17 
            336663074,	        //PkgInt.pack4bits(ITSME,ITSME,ITSME,ERROR,ERROR,ERROR,    4,ERROR),//18-1f 
            286335249,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ITSME,ERROR,ERROR,ERROR,ERROR),//20-27 
            286331237,	        //PkgInt.pack4bits(    5,    6,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//28-2f 
            286335249,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ITSME,ERROR,ERROR,ERROR,ERROR),//30-37 
            18944273,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ITSME,ERROR,START) //38-3f 
    };

        private static int[] iso2022cnCharLenTable = new int[] {
        0, 0, 0, 0, 0, 0, 0, 0, 0
    };
    }
}
