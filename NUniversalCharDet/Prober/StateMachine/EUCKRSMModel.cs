
namespace Mozilla.NUniversalCharDet.Prober.StateMachine
{
    public class EUCKRSMModel : SMModel
    {
        ////////////////////////////////////////////////////////////////
        // constants
        ////////////////////////////////////////////////////////////////
        public static int EUCKR_CLASS_FACTOR = 4;


        ////////////////////////////////////////////////////////////////
        // methods
        ////////////////////////////////////////////////////////////////
        public EUCKRSMModel()
            : base(
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, euckrClassTable),
                EUCKR_CLASS_FACTOR,
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, euckrStateTable),
                euckrCharLenTable,
                Constants.CHARSET_EUC_KR
                )
        {
        }


        ////////////////////////////////////////////////////////////////
        // constants continued
        ////////////////////////////////////////////////////////////////
        private static int[] euckrClassTable = new int[] {
        //PkgInt.pack4bits(0,1,1,1,1,1,1,1),  // 00 - 07 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 00 - 07 
        1118481,	        //PkgInt.pack4bits(1,1,1,1,1,1,0,0),  // 08 - 0f 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 10 - 17 
        286327057,	        //PkgInt.pack4bits(1,1,1,0,1,1,1,1),  // 18 - 1f 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 20 - 27 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 28 - 2f 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 30 - 37 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 38 - 3f 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 40 - 47 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 48 - 4f 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 50 - 57 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 58 - 5f 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 60 - 67 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 68 - 6f 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 70 - 77 
        286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 78 - 7f 
        0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 80 - 87 
        0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 88 - 8f 
        0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 90 - 97 
        0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 98 - 9f 
        572662304,	        //PkgInt.pack4bits(0,2,2,2,2,2,2,2),  // a0 - a7 
        858923554,	        //PkgInt.pack4bits(2,2,2,2,2,3,3,3),  // a8 - af 
        572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // b0 - b7 
        572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // b8 - bf 
        572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // c0 - c7 
        572662322,	        //PkgInt.pack4bits(2,3,2,2,2,2,2,2),  // c8 - cf 
        572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // d0 - d7 
        572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // d8 - df 
        572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // e0 - e7 
        572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // e8 - ef 
        572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // f0 - f7 
        35791394,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,0)   // f8 - ff 
    };

        private static int[] euckrStateTable = new int[] {
        286331649,//PkgInt.pack4bits(ERROR,START,    3,ERROR,ERROR,ERROR,ERROR,ERROR),//00-07 
        1122850,//PkgInt.pack4bits(ITSME,ITSME,ITSME,ITSME,ERROR,ERROR,START,START) //08-0f 
    };

        private static int[] euckrCharLenTable = new int[] {
        0, 1, 2, 0
    };

    }
}
