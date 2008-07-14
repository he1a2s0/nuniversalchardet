
namespace Mozilla.NUniversalCharDet.Prober.StateMachine
{
    public class SJISSMModel : SMModel
    {
        ////////////////////////////////////////////////////////////////
        // constants
        ////////////////////////////////////////////////////////////////
        public static int SJIS_CLASS_FACTOR = 6;


        ////////////////////////////////////////////////////////////////
        // methods
        ////////////////////////////////////////////////////////////////
        public SJISSMModel()
            : base(
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, sjisClassTable),
                SJIS_CLASS_FACTOR,
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, sjisStateTable),
                sjisCharLenTable,
                Constants.CHARSET_SHIFT_JIS
                )
        {

        }


        ////////////////////////////////////////////////////////////////
        // constants continued
        ////////////////////////////////////////////////////////////////
        private static int[] sjisClassTable = new int[] {
//        PkgInt.pack4bits(0,1,1,1,1,1,1,1),  // 00 - 07 
            286331153,	//        PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 00 - 07 
            1118481,	//        PkgInt.pack4bits(1,1,1,1,1,1,0,0),  // 08 - 0f 
            286331153,	//        PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 10 - 17 
            286327057,	//        PkgInt.pack4bits(1,1,1,0,1,1,1,1),  // 18 - 1f 
            286331153,	//        PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 20 - 27 
            286331153,	//        PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 28 - 2f 
            286331153,	//        PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 30 - 37 
            286331153,	//        PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 38 - 3f 
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 40 - 47 
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 48 - 4f 
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 50 - 57 
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 58 - 5f 
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 60 - 67 
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 68 - 6f 
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 70 - 77 
            304226850,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,1),  // 78 - 7f 
            858993459,	//        PkgInt.pack4bits(3,3,3,3,3,3,3,3),  // 80 - 87 
            858993459,	//        PkgInt.pack4bits(3,3,3,3,3,3,3,3),  // 88 - 8f 
            858993459,	//        PkgInt.pack4bits(3,3,3,3,3,3,3,3),  // 90 - 97 
            858993459,	//        PkgInt.pack4bits(3,3,3,3,3,3,3,3),  // 98 - 9f 
            ////        0xa0 is illegal in sjis encoding, but some pages does 
            ////        contain such byte. We need to be more error forgiven.
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // a0 - a7     
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // a8 - af 
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // b0 - b7 
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // b8 - bf 
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // c0 - c7 
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // c8 - cf 
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // d0 - d7 
            572662306,	//        PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // d8 - df 
            858993459,	//        PkgInt.pack4bits(3,3,3,3,3,3,3,3),  // e0 - e7 
            1145254707,	//        PkgInt.pack4bits(3,3,3,3,3,4,4,4),  // e8 - ef 
            1145324612,	//        PkgInt.pack4bits(4,4,4,4,4,4,4,4),  // f0 - f7 
            279620,	//        PkgInt.pack4bits(4,4,4,4,4,0,0,0)   // f8 - ff 
    };

        private static int[] sjisStateTable = new int[] {
            286339073,	        //PkgInt.pack4bits(ERROR,START,START,    3,ERROR,ERROR,ERROR,ERROR),//00-07 
            572657937,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ITSME,ITSME,ITSME,ITSME),//08-0f 
            4386,	        //PkgInt.pack4bits(ITSME,ITSME,ERROR,ERROR,START,START,START,START) //10-17 
    };

        private static int[] sjisCharLenTable = new int[] {
        0, 1, 1, 2, 0, 0
    };
    }
}
