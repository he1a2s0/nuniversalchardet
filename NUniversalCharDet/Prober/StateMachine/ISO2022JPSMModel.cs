using System;
using System.Collections.Generic;
using System.Text;

namespace Mozilla.NUniversalCharDet.Prober.StateMachine
{
    public class ISO2022JPSMModel : SMModel
    {
        ////////////////////////////////////////////////////////////////
        // constants
        ////////////////////////////////////////////////////////////////
        public static int ISO2022JP_CLASS_FACTOR = 10;


        ////////////////////////////////////////////////////////////////
        // methods
        ////////////////////////////////////////////////////////////////
        public ISO2022JPSMModel()
            : base(
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, iso2022jpClassTable),
                ISO2022JP_CLASS_FACTOR,
                new PkgInt(PkgInt.INDEX_SHIFT_4BITS, PkgInt.SHIFT_MASK_4BITS, PkgInt.BIT_SHIFT_4BITS, PkgInt.UNIT_MASK_4BITS, iso2022jpStateTable),
                iso2022jpCharLenTable,
                Constants.CHARSET_ISO_2022_JP
                )
        {

        }


        ////////////////////////////////////////////////////////////////
        // constants continued
        ////////////////////////////////////////////////////////////////
        private static int[] iso2022jpClassTable = new int[] {
            2,	        //PkgInt.pack4bits(2,0,0,0,0,0,0,0),  // 00 - 07 
            570425344,	        //PkgInt.pack4bits(0,0,0,0,0,0,2,2),  // 08 - 0f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 10 - 17 
            4096,	        //PkgInt.pack4bits(0,0,0,1,0,0,0,0),  // 18 - 1f 
            458752,	        //PkgInt.pack4bits(0,0,0,0,7,0,0,0),  // 20 - 27 
            3,	        //PkgInt.pack4bits(3,0,0,0,0,0,0,0),  // 28 - 2f 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 30 - 37 
            0,	        //PkgInt.pack4bits(0,0,0,0,0,0,0,0),  // 38 - 3f 
            525318,	        //PkgInt.pack4bits(6,0,4,0,8,0,0,0),  // 40 - 47 
            1424,	        //PkgInt.pack4bits(0,9,5,0,0,0,0,0),  // 48 - 4f 
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

        private static int[] iso2022jpStateTable = new int[] {
            304,	        //PkgInt.pack4bits(START,    3,ERROR,START,START,START,START,START),//00-07 
            286331136,	        //PkgInt.pack4bits(START,START,ERROR,ERROR,ERROR,ERROR,ERROR,ERROR),//08-0f 
            572657937,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ITSME,ITSME,ITSME,ITSME),//10-17 
            287449634,	        //PkgInt.pack4bits(ITSME,ITSME,ITSME,ITSME,ITSME,ITSME,ERROR,ERROR),//18-1f 
            289476945,	        //PkgInt.pack4bits(ERROR,    5,ERROR,ERROR,ERROR,    4,ERROR,ERROR),//20-27 
            303194385,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,    6,ITSME,ERROR,ITSME,ERROR),//28-2f 
            571543825,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ERROR,ERROR,ITSME,ITSME),//30-37 
            286335249,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ITSME,ERROR,ERROR,ERROR,ERROR),//38-3f 
            1184017,	        //PkgInt.pack4bits(ERROR,ERROR,ERROR,ERROR,ITSME,ERROR,START,START) //40-47 
    };

        private static int[] iso2022jpCharLenTable = new int[] {
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0
    };
    }
}
