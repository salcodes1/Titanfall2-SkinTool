﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.LightMachineGun
{
    class LSTAR
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] LSTAR_col;
        public ReallyData[] LSTAR_nml;
        public ReallyData[] LSTAR_gls;
        public ReallyData[] LSTAR_spc;

        public LSTAR()
        {


            LSTAR_col = new ReallyData[3];
            LSTAR_nml = new ReallyData[3];
            LSTAR_gls = new ReallyData[3];
            LSTAR_spc = new ReallyData[3];

            //2为2048x2048,1为1024x1024,0为512x512

            LSTAR_col[1].name = "col";
            LSTAR_col[1].seek = 7317753856;
            LSTAR_col[1].length = 524288;
            LSTAR_col[1].seeklength = 128;

            LSTAR_col[2].name = "col";
            LSTAR_col[2].seek = LSTAR_col[2 - 1].seek + LSTAR_col[2 - 1].length;
            LSTAR_col[2].length = LSTAR_col[2 - 1].length * 4;
            LSTAR_col[2].seeklength = 128;


            LSTAR_nml[1].name = "nml";
            LSTAR_nml[1].seek = 7320375296;
            LSTAR_nml[1].length = 1048576;
            LSTAR_nml[1].seeklength = 128;

            LSTAR_nml[2].name = "nml";
            LSTAR_nml[2].seek = LSTAR_nml[2 - 1].seek + LSTAR_nml[2 - 1].length;
            LSTAR_nml[2].length = LSTAR_nml[2 - 1].length * 4;
            LSTAR_nml[2].seeklength = 128;


            LSTAR_gls[1].name = "gls";
            LSTAR_gls[1].seek = 7325618176;
            LSTAR_gls[1].length = 524288;
            LSTAR_gls[1].seeklength = 128;

            LSTAR_gls[2].name = "gls";
            LSTAR_gls[2].seek = LSTAR_gls[2 - 1].seek + LSTAR_gls[2 - 1].length;
            LSTAR_gls[2].length = LSTAR_gls[2 - 1].length * 4;
            LSTAR_gls[2].seeklength = 128;


            LSTAR_spc[1].name = "spc";
            LSTAR_spc[1].seek = 7328239616;
            LSTAR_spc[1].length = 524288;
            LSTAR_spc[1].seeklength = 128;

            LSTAR_spc[2].name = "spc";
            LSTAR_spc[2].seek = LSTAR_spc[2 - 1].seek + LSTAR_spc[2 - 1].length;
            LSTAR_spc[2].length = LSTAR_spc[2 - 1].length * 4;
            LSTAR_spc[2].seeklength = 128;



        }
    }
}
