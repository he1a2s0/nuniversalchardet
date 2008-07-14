
namespace Mozilla.NUniversalCharDet.Prober.StateMachine
{
    public class GB18030SMModel : SMModel
    {
        ////////////////////////////////////////////////////////////////
        // constants
        ////////////////////////////////////////////////////////////////
        public static int GB18030_CLASS_FACTOR = 7;


        ////////////////////////////////////////////////////////////////
        // methods
        ////////////////////////////////////////////////////////////////
        public GB18030SMModel()
            : base(
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, gb18030ClassTable),
                GB18030_CLASS_FACTOR,
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, gb18030StateTable),
                gb18030CharLenTable,
                Constants.CHARSET_GB18030
                )
        {

        }


        ////////////////////////////////////////////////////////////////
        // constants continued
        ////////////////////////////////////////////////////////////////
        private static int[] gb18030ClassTable = new int[] {
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 00 - 07 
            1118481,	        //PkgInt.pack4bits(1,1,1,1,1,1,0,0),  // 08 - 0f 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 10 - 17 
            286327057,	        //PkgInt.pack4bits(1,1,1,0,1,1,1,1),  // 18 - 1f 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 20 - 27 
            286331153,	        //PkgInt.pack4bits(1,1,1,1,1,1,1,1),  // 28 - 2f 
            858993459,	        //PkgInt.pack4bits(3,3,3,3,3,3,3,3),  // 30 - 37 
            286331187,	        //PkgInt.pack4bits(3,3,1,1,1,1,1,1),  // 38 - 3f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 40 - 47 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 48 - 4f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 50 - 57 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 58 - 5f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 60 - 67 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 68 - 6f 
            572662306,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,2),  // 70 - 77 
            1109533218,	        //PkgInt.pack4bits(2,2,2,2,2,2,2,4),  // 78 - 7f 
            1717986917,	        //PkgInt.pack4bits(5,6,6,6,6,6,6,6),  // 80 - 87 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // 88 - 8f 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // 90 - 97 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // 98 - 9f 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // a0 - a7 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // a8 - af 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // b0 - b7 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // b8 - bf 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // c0 - c7 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // c8 - cf 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // d0 - d7 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // d8 - df 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // e0 - e7 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // e8 - ef 
            1717986918,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,6),  // f0 - f7 
            107374182,	        //PkgInt.pack4bits(6,6,6,6,6,6,6,0)   // f8 - ff 
    };

        private static int[] gb18030StateTable = new int[] {
            318767105,	        //PkgInt.pack4bits(ERROR,START,START,START,START,START,    3,ERROR),//00-07 
            571543825,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ITSME,ITSME),//08-0f 
            17965602,	        //PkgInt.pack4bits(ITSME,ITSME,ITSME,ITSME,ITSME,ERROR,ERROR,START),//10-17 
            286326804,	        //PkgInt.pack4bits(    4,ERROR,START,START,ERROR,ERROR,ERROR,ERROR),//18-1f 
            303109393,	        //PkgInt.pack4bits(ERROR,ERROR,    5,ERROR,ERROR,ERROR,ITSME,ERROR),//20-27 
            17,	        //PkgInt.pack4bits(ERROR,ERROR,START,START,START,START,START,START) //28-2f 
    };

        private static int[] gb18030CharLenTable = new int[] {
        0, 1, 1, 1, 1, 1, 2
    };
    }

}
