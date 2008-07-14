
namespace Mozilla.NUniversalCharDet.Prober.StateMachine
{
    public class EUCTWSMModel : SMModel
    {
        ////////////////////////////////////////////////////////////////
        // constants
        ////////////////////////////////////////////////////////////////
        public static int EUCTW_CLASS_FACTOR = 7;


        ////////////////////////////////////////////////////////////////
        // methods
        ////////////////////////////////////////////////////////////////
        public EUCTWSMModel()
            : base(
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, euctwClassTable),
                EUCTW_CLASS_FACTOR,
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, euctwStateTable),
                euctwCharLenTable,
                Constants.CHARSET_EUC_TW
                )
        {
        }


        ////////////////////////////////////////////////////////////////
        // constants continued
        ////////////////////////////////////////////////////////////////
        private static int[] euctwClassTable = new int[] {
//        PkgInt.pack4bits(0,2,2,2,2,2,2,2),  // 00 - 07 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 00 - 07 
            2236962,	        //PkgInt.pack4bits(2,2,2,2,2,2,0,0),  // 08 - 0f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 10 - 17 
            572654114,	        //PkgInt.pack4bits(2,2,2,0,2,2,2,2),  // 18 - 1f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 20 - 27 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 28 - 2f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 30 - 37 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 38 - 3f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 40 - 47 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 48 - 4f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 50 - 57 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 58 - 5f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 60 - 67 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 68 - 6f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 70 - 77 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 78 - 7f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 80 - 87 
            100663296,	        //PkgInt.pack4bits(0,0,0,0,0,0,6,0),  // 88 - 8f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 90 - 97 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 98 - 9f 
            1145324592,	        //PkgInt.pack4bits(0,3,4,4,4,4,4,4),  // a0 - a7 
            286331221,	        //PkgInt.pack4bits(5,5,1,1,1,1,1,1),  // a8 - af 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // b0 - b7 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // b8 - bf 
            858985233,	        //PkgInt.pack4bits(1,1,3,1,3,3,3,3),  // c0 - c7 
            858993459,	        //PkgInt.pack4bits(3,3,3,3,3,3,3,3),  // c8 - cf 
            858993459,	        //PkgInt.pack4bits(3,3,3,3,3,3,3,3),  // d0 - d7 
            858993459,	        //PkgInt.pack4bits(3,3,3,3,3,3,3,3),  // d8 - df 
            858993459,	        //PkgInt.pack4bits(3,3,3,3,3,3,3,3),  // e0 - e7 
            858993459,	        //PkgInt.pack4bits(3,3,3,3,3,3,3,3),  // e8 - ef 
            858993459,	        //PkgInt.pack4bits(3,3,3,3,3,3,3,3),  // f0 - f7 
            53687091,	        //PkgInt.pack4bits(3,3,3,3,3,3,3,0)   // f8 - ff 
    };

        private static int[] euctwStateTable = new int[] {
            338898961,	        //PkgInt.pack4bits(ERROR,ERROR,START,    3,    3,    3,    4,ERROR),//00-07 
            571543825,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ITSME,ITSME),//08-0f 
            269623842,	        //PkgInt.pack4bits(ITSME,ITSME,ITSME,ITSME,ITSME,ERROR,START,ERROR),//10-17 
            286330880,	        //PkgInt.pack4bits(START,START,START,ERROR,ERROR,ERROR,ERROR,ERROR),//18-1f 
            1052949,	        //PkgInt.pack4bits(    5,ERROR,ERROR,ERROR,START,ERROR,START,START),//20-27 
            16,	        //PkgInt.pack4bits(START,ERROR,START,START,START,START,START,START) //28-2f 
    };

        private static int[] euctwCharLenTable = new int[] {
        0, 0, 1, 2, 2, 2, 3
    };
    }
}
