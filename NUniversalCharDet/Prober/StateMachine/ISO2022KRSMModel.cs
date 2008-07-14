
namespace Mozilla.NUniversalCharDet.Prober.StateMachine
{
    public class ISO2022KRSMModel : SMModel
    {
        ////////////////////////////////////////////////////////////////
        // constants
        ////////////////////////////////////////////////////////////////
        public static int ISO2022KR_CLASS_FACTOR = 6;


        ////////////////////////////////////////////////////////////////
        // methods
        ////////////////////////////////////////////////////////////////
        public ISO2022KRSMModel()
            : base(
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, iso2022krClassTable),
                ISO2022KR_CLASS_FACTOR,
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, iso2022krStateTable),
                iso2022krCharLenTable,
                Constants.CHARSET_ISO_2022_KR
                )
        {
        }


        ////////////////////////////////////////////////////////////////
        // constants continued
        ////////////////////////////////////////////////////////////////
        private static int[] iso2022krClassTable = new int[] {
            2,	        //PkgInt.pack4bits(2,0,0,0,0,0,0,0),  // 00 - 07 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 08 - 0f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 10 - 17 
            4096,	        //PkgInt.pack4bits(0,0,0,1,0,0,0,0),  // 18 - 1f 
            196608,	        //PkgInt.pack4bits(0,0,0,0,3,0,0,0),  // 20 - 27 
            64,	        //PkgInt.pack4bits(0,4,0,0,0,0,0,0),  // 28 - 2f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 30 - 37 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 38 - 3f 
            20480,	        //PkgInt.pack4bits(0,0,0,5,0,0,0,0),  // 40 - 47 
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

        private static int[] iso2022krStateTable = new int[] {
            285212976,	        //PkgInt.pack4bits(START,    3,ERROR,START,START,START,ERROR,ERROR),//00-07 
            572657937,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ITSME,ITSME,ITSME,ITSME),//08-0f 
            289476898,	        //PkgInt.pack4bits(ITSME,ITSME,ERROR,ERROR,ERROR,    4,ERROR,ERROR),//10-17 
            286593297,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,    5,ERROR,ERROR,ERROR),//18-1f 
            8465,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ITSME,START,START,START,START) //20-27 
    };

        private static int[] iso2022krCharLenTable = new int[] {
        0, 0, 0, 0, 0, 0
    };
    }
}
