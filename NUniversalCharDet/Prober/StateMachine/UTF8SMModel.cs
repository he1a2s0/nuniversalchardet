
namespace Mozilla.NUniversalCharDet.Prober.StateMachine
{
    public class UTF8SMModel : SMModel
    {
        ////////////////////////////////////////////////////////////////
        // constants
        ////////////////////////////////////////////////////////////////
        public static int UTF8_CLASS_FACTOR = 16;


        ////////////////////////////////////////////////////////////////
        // methods
        ////////////////////////////////////////////////////////////////
        public UTF8SMModel()
            : base(
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, utf8ClassTable),
                UTF8_CLASS_FACTOR,
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, utf8StateTable),
                utf8CharLenTable,
                Constants.CHARSET_UTF_8
                )
        {
        }


        ////////////////////////////////////////////////////////////////
        // constants continued
        ////////////////////////////////////////////////////////////////
        private static int[] utf8ClassTable = new int[] {
//        PkgInt.pack4bits(0,1,1,1,1,1,1,1),  // 00 - 07 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 00 - 07  //allow 0x00 as a legal value
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
            858989090,	        //PkgInt.pack4bits(2,2,2,2,3,3,3,3),  // 80 - 87 
            1145324612,	        //PkgInt.pack4bits(4,4,4,4,4,4,4,4),  // 88 - 8f 
            1145324612,	        //PkgInt.pack4bits(4,4,4,4,4,4,4,4),  // 90 - 97 
            1145324612,	        //PkgInt.pack4bits(4,4,4,4,4,4,4,4),  // 98 - 9f 
            1431655765,	        //PkgInt.pack4bits(5,5,5,5,5,5,5,5),  // a0 - a7 
            1431655765,	        //PkgInt.pack4bits(5,5,5,5,5,5,5,5),  // a8 - af 
            1431655765,	        //PkgInt.pack4bits(5,5,5,5,5,5,5,5),  // b0 - b7 
            1431655765,	        //PkgInt.pack4bits(5,5,5,5,5,5,5,5),  // b8 - bf 
            1717986816,	        //PkgInt.pack4bits(0,0,6,6,6,6,6,6),  // c0 - c7 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // c8 - cf 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // d0 - d7 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // d8 - df 
            -2004318073,	        //PkgInt.pack4bits(7,8,8,8,8,8,8,8),  // e0 - e7 
            -2003269496,	        //PkgInt.pack4bits(8,8,8,8,8,9,8,8),  // e8 - ef 
            -1145324614,	        //PkgInt.pack4bits(10,11,11,11,11,11,11,11),  // f0 - f7 
            16702940,	        //PkgInt.pack4bits(12,13,13,13,14,15,0,0)   // f8 - ff 
    };

        private static int[] utf8StateTable = new int[] {
            -1408167679,	        //PkgInt.pack4bits(ERROR,START,ERROR,ERROR,ERROR,ERROR,   12,   10),//00-07 
            878082233,	        //PkgInt.pack4bits(    9,   11,    8,    7,    6,    5,    4,    3),//08-0f 
            286331153,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//10-17 
            286331153,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//18-1f 
            572662306,	        //PkgInt.pack4bits(ITSME,ITSME,ITSME,ITSME,ITSME,ITSME,ITSME,ITSME),//20-27 
            572662306,	        //PkgInt.pack4bits(ITSME,ITSME,ITSME,ITSME,ITSME,ITSME,ITSME,ITSME),//28-2f 
            290805009,	        //PkgInt.pack4bits(ERROR,ERROR,    5,    5,    5,    5,ERROR,ERROR),//30-37 
            286331153,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//38-3f 
            290803985,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,    5,    5,    5,ERROR,ERROR),//40-47 
            286331153,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//48-4f 
            293041937,	        //PkgInt.pack4bits(ERROR,ERROR,    7,    7,    7,    7,ERROR,ERROR),//50-57 
            286331153,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//58-5f 
            293015825,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,    7,    7,ERROR,ERROR),//60-67 
            286331153,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//68-6f 
            295278865,	        //PkgInt.pack4bits(ERROR,ERROR,    9,    9,    9,    9,ERROR,ERROR),//70-77 
            286331153,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//78-7f 
            294719761,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,    9,ERROR,ERROR),//80-87 
            286331153,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//88-8f 
            298634257,	        //PkgInt.pack4bits(ERROR,ERROR,   12,   12,   12,   12,ERROR,ERROR),//90-97 
            286331153,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//98-9f 
            297865489,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,   12,ERROR,ERROR),//a0-a7 
            286331153,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//a8-af 
            287099921,	        //PkgInt.pack4bits(ERROR,ERROR,   12,   12,   12,ERROR,ERROR,ERROR),//b0-b7 
            286331153,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//b8-bf 
            285212689,	        //PkgInt.pack4bits(ERROR,ERROR,START,START,START,START,ERROR,ERROR),//c0-c7 
            286331153,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR) //c8-cf 
    };

        private static int[] utf8CharLenTable = new int[] {
        0, 1, 0, 0, 0, 0, 2, 3,
        3, 3, 4, 4, 5, 5, 6, 6
    };
    }
}
