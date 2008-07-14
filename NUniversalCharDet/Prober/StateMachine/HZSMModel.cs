
namespace Mozilla.NUniversalCharDet.Prober.StateMachine
{
    public class HZSMModel : SMModel
    {
        ////////////////////////////////////////////////////////////////
        // constants
        ////////////////////////////////////////////////////////////////
        public static int HZS_CLASS_FACTOR = 6;


        ////////////////////////////////////////////////////////////////
        // methods
        ////////////////////////////////////////////////////////////////
        public HZSMModel()
            : base(
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, hzsClassTable),
                HZS_CLASS_FACTOR,
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, hzsStateTable),
                hzsCharLenTable,
                Constants.CHARSET_HZ_GB_2312
                )
        {
        }


        ////////////////////////////////////////////////////////////////
        // constants continued
        ////////////////////////////////////////////////////////////////
        private static int[] hzsClassTable = new int[] {
            1,	        //PkgInt.pack4bits(1,0,0,0,0,0,0,0),  // 00 - 07 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 08 - 0f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 10 - 17 
            4096,	        //PkgInt.pack4bits(0,0,0,1,0,0,0,0),  // 18 - 1f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 20 - 27 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 28 - 2f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 30 - 37 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 38 - 3f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 40 - 47 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 48 - 4f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 50 - 57 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 58 - 5f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 60 - 67 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 68 - 6f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 70 - 77 
            38813696,	        //PkgInt.pack4bits(0,0,0,4,0,5,2,0),  // 78 - 7f 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 80 - 87 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 88 - 8f 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 90 - 97 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 98 - 9f 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // a0 - a7 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // a8 - af 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // b0 - b7 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // b8 - bf 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // c0 - c7 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // c8 - cf 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // d0 - d7 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // d8 - df 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // e0 - e7 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // e8 - ef 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // f0 - f7 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1)   // f8 - ff 
    };

        private static int[] hzsStateTable = new int[] {
            285213456,	        //PkgInt.pack4bits(START,ERROR,    3,START,START,START,ERROR,ERROR),//00-07 
            572657937,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ITSME,ITSME,ITSME,ITSME),//08-0f 
            335548706,	        //PkgInt.pack4bits(ITSME,ITSME,ERROR,ERROR,START,START,    4,ERROR),//10-17 
            341120533,	        //PkgInt.pack4bits(    5,ERROR,    6,ERROR,    5,    5,    4,ERROR),//18-1f 
            336872468,	        //PkgInt.pack4bits(    4,ERROR,    4,    4,    4,ERROR,    4,ERROR),//20-27 
            36,	        //PkgInt.pack4bits(    4,ITSME,START,START,START,START,START,START) //28-2f 
    };

        private static int[] hzsCharLenTable = new int[] {
        0, 0, 0, 0, 0, 0
    };
    }
}
