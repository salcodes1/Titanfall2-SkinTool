﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData
{
    class WeaponDataControl
    {
        public string[,] FilePath = new string[1, 4];
        //col，nml，gls，spc，ilm，ao，cav
        //2为2048x2048,1为1024x1024,0为512x512
        public WeaponDataControl(string WeaponName, int imagecheck)
        {

            string s = WeaponName;
            int toname = s.IndexOf("_");
            string str = s.Substring(toname, s.Length - toname);
            s = s.Replace(str, "");
            if (WeaponName.Contains("Default"))
            {
                switch (s)
                {
                    //步枪类
                    case "R301":
                        Default.AssaultRifle.R301 r301 = new Default.AssaultRifle.R301();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = r301.R301_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = r301.R301_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = r301.R301_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = r301.R301_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = r301.R301_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = r301.R301_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(r301.R301_cav[imagecheck].seeklength);
                        }
                        break;
                    case "Hemlok":
                        Default.AssaultRifle.Hemlok hemlok = new Default.AssaultRifle.Hemlok();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = hemlok.Hemlok_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = hemlok.Hemlok_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = hemlok.Hemlok_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = hemlok.Hemlok_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = hemlok.Hemlok_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = hemlok.Hemlok_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(hemlok.Hemlok_cav[imagecheck].seeklength);
                        }
                        break;
                    case "VK47Flatline":
                        Default.AssaultRifle.VK47Flatline vk47flatline = new Default.AssaultRifle.VK47Flatline();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = vk47flatline.VK47Flatline_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = vk47flatline.VK47Flatline_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = vk47flatline.VK47Flatline_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = vk47flatline.VK47Flatline_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = vk47flatline.VK47Flatline_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = vk47flatline.VK47Flatline_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(vk47flatline.VK47Flatline_cav[imagecheck].seeklength);
                        }
                        break;
                    case "Havoc":
                        Default.AssaultRifle.Havoc havoc = new Default.AssaultRifle.Havoc();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = havoc.Havoc_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = havoc.Havoc_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = havoc.Havoc_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = havoc.Havoc_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ilm"))
                        {
                            int i = 0;
                            FilePath[0, i] = havoc.Havoc_ilm[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_ilm[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_ilm[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_ilm[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = havoc.Havoc_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = havoc.Havoc_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(havoc.Havoc_cav[imagecheck].seeklength);
                        }
                        break;
                    case "ChargeRifle":
                        Default.AssaultRifle.ChargeRifle chargerifle = new Default.AssaultRifle.ChargeRifle();
                        //col，nml，gls，spc，ilm，ao，cav
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = chargerifle.ChargeRifle_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(chargerifle.ChargeRifle_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(chargerifle.ChargeRifle_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(chargerifle.ChargeRifle_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = chargerifle.ChargeRifle_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(chargerifle.ChargeRifle_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(chargerifle.ChargeRifle_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(chargerifle.ChargeRifle_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = chargerifle.ChargeRifle_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(chargerifle.ChargeRifle_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(chargerifle.ChargeRifle_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(chargerifle.ChargeRifle_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = chargerifle.ChargeRifle_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(chargerifle.ChargeRifle_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(chargerifle.ChargeRifle_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(chargerifle.ChargeRifle_spc[imagecheck].seeklength);
                        }
                        //需要修复
                        break;
                    //轻机枪类
                    case "Devotion":
                        Default.LightMachineGun.Devotion devotion = new Default.LightMachineGun.Devotion();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = devotion.Devotion_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = devotion.Devotion_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = devotion.Devotion_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = devotion.Devotion_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ilm"))
                        {
                            int i = 0;
                            FilePath[0, i] = devotion.Devotion_ilm[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_ilm[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_ilm[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_ilm[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = devotion.Devotion_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = devotion.Devotion_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(devotion.Devotion_cav[imagecheck].seeklength);
                        }
                        break;
                    case "LSTAR":
                        Default.LightMachineGun.LSTAR lstar = new Default.LightMachineGun.LSTAR();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = lstar.LSTAR_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = lstar.LSTAR_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = lstar.LSTAR_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = lstar.LSTAR_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = lstar.LSTAR_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = lstar.LSTAR_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(lstar.LSTAR_cav[imagecheck].seeklength);
                        }
                        break;
                    case "Spitfire":
                        Default.LightMachineGun.Spitfire spitfire = new Default.LightMachineGun.Spitfire();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = spitfire.Spitfire_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = spitfire.Spitfire_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = spitfire.Spitfire_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = spitfire.Spitfire_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = spitfire.Spitfire_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = spitfire.Spitfire_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(spitfire.Spitfire_cav[imagecheck].seeklength);
                        }
                        break;
                    //手枪类
                    //没有2048
                    case "P2020":
                        Default.Pistol.P2020 p2020 = new Default.Pistol.P2020();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = p2020.P2020_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = p2020.P2020_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = p2020.P2020_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = p2020.P2020_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = p2020.P2020_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = p2020.P2020_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(p2020.P2020_cav[imagecheck].seeklength);
                        }
                        break;
                    case "RE45":
                        Default.Pistol.RE45 re45 = new Default.Pistol.RE45();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = re45.RE45_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = re45.RE45_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = re45.RE45_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = re45.RE45_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ilm"))
                        {
                            int i = 0;
                            FilePath[0, i] = re45.RE45_ilm[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_ilm[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_ilm[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(re45.RE45_ilm[imagecheck].seeklength);
                        }
                        break;
                    case "Wingman":
                        Default.Pistol.Wingman wingman = new Default.Pistol.Wingman();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = wingman.Wingman_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = wingman.Wingman_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = wingman.Wingman_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = wingman.Wingman_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = wingman.Wingman_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = wingman.Wingman_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(wingman.Wingman_cav[imagecheck].seeklength);
                        }
                        break;
                    //霞弹枪类
                    case "EVA8":
                        Default.Shotgun.EVA8 eva8 = new Default.Shotgun.EVA8();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = eva8.EVA8_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = eva8.EVA8_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = eva8.EVA8_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = eva8.EVA8_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = eva8.EVA8_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = eva8.EVA8_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(eva8.EVA8_cav[imagecheck].seeklength);
                        }
                        break;
                    case "Mastiff":
                        Default.Shotgun.Mastiff mastiff = new Default.Shotgun.Mastiff();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = mastiff.Mastiff_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = mastiff.Mastiff_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = mastiff.Mastiff_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = mastiff.Mastiff_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = mastiff.Mastiff_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = mastiff.Mastiff_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(mastiff.Mastiff_cav[imagecheck].seeklength);
                        }
                        break;
                    //莫桑比克只有512和1024，没有2048
                    case "Mozambique":
                        Default.Shotgun.Mozambique mozambique = new Default.Shotgun.Mozambique();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = mozambique.Mozambique_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = mozambique.Mozambique_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = mozambique.Mozambique_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = mozambique.Mozambique_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = mozambique.Mozambique_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = mozambique.Mozambique_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(mozambique.Mozambique_cav[imagecheck].seeklength);
                        }
                        break;
                    case "Peacekeeper":
                        Default.Shotgun.Peacekeeper peacekeeper = new Default.Shotgun.Peacekeeper();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = peacekeeper.Peacekeeper_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = peacekeeper.Peacekeeper_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = peacekeeper.Peacekeeper_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = peacekeeper.Peacekeeper_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ilm"))
                        {
                            int i = 0;
                            FilePath[0, i] = peacekeeper.Peacekeeper_ilm[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_ilm[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_ilm[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_ilm[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = peacekeeper.Peacekeeper_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = peacekeeper.Peacekeeper_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(peacekeeper.Peacekeeper_cav[imagecheck].seeklength);
                        }
                        break;
                    //狙击枪类
                    case "G2A7":
                        Default.Sniper.G2A7 g2a7 = new Default.Sniper.G2A7();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = g2a7.G2A7_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = g2a7.G2A7_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = g2a7.G2A7_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = g2a7.G2A7_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ilm"))
                        {
                            int i = 0;
                            FilePath[0, i] = g2a7.G2A7_ilm[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_ilm[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_ilm[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_ilm[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = g2a7.G2A7_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = g2a7.G2A7_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(g2a7.G2A7_cav[imagecheck].seeklength);
                        }
                        break;
                    case "Kraber":
                        Default.Sniper.Kraber kraber = new Default.Sniper.Kraber();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = kraber.Kraber_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = kraber.Kraber_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = kraber.Kraber_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = kraber.Kraber_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = kraber.Kraber_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = kraber.Kraber_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(kraber.Kraber_cav[imagecheck].seeklength);
                        }
                        break;
                    case "Longbow":
                        Default.Sniper.Longbow longbow = new Default.Sniper.Longbow();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = longbow.Longbow_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = longbow.Longbow_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = longbow.Longbow_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = longbow.Longbow_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = longbow.Longbow_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = longbow.Longbow_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(longbow.Longbow_cav[imagecheck].seeklength);
                        }
                        break;
                    case "TripleTake":
                        Default.Sniper.TripleTake tripletake = new Default.Sniper.TripleTake();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = tripletake.TripleTake_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = tripletake.TripleTake_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = tripletake.TripleTake_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = tripletake.TripleTake_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ilm"))
                        {
                            int i = 0;
                            FilePath[0, i] = tripletake.TripleTake_ilm[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_ilm[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_ilm[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_ilm[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = tripletake.TripleTake_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = tripletake.TripleTake_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(tripletake.TripleTake_cav[imagecheck].seeklength);
                        }
                        break;
                    //冲锋枪类
                    case "Alternator":
                        Default.SubmachineGun.Alternator alternator = new Default.SubmachineGun.Alternator();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = alternator.Alternator_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = alternator.Alternator_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = alternator.Alternator_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = alternator.Alternator_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = alternator.Alternator_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = alternator.Alternator_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(alternator.Alternator_cav[imagecheck].seeklength);
                        }
                        break;
                    case "PDW":
                        Default.SubmachineGun.PDW pdw = new Default.SubmachineGun.PDW();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = pdw.PDW_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = pdw.PDW_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = pdw.PDW_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = pdw.PDW_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = pdw.PDW_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = pdw.PDW_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(pdw.PDW_cav[imagecheck].seeklength);
                        }
                        break;
                    case "R99":
                        Default.SubmachineGun.R99 r99 = new Default.SubmachineGun.R99();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = r99.R99_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = r99.R99_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = r99.R99_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = r99.R99_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_spc[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ilm"))
                        {
                            int i = 0;
                            FilePath[0, i] = r99.R99_ilm[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_ilm[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_ilm[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_ilm[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("ao"))
                        {
                            int i = 0;
                            FilePath[0, i] = r99.R99_ao[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_ao[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_ao[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_ao[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("cav"))
                        {
                            int i = 0;
                            FilePath[0, i] = r99.R99_cav[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_cav[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_cav[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(r99.R99_cav[imagecheck].seeklength);
                        }
                        break;
                    case "Volt":
                        Default.SubmachineGun.Volt volt = new Default.SubmachineGun.Volt();
                        if (WeaponName.Contains("col"))
                        {
                            int i = 0;
                            FilePath[0, i] = volt.Volt_col[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(volt.Volt_col[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(volt.Volt_col[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(volt.Volt_col[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("nml"))
                        {
                            int i = 0;
                            FilePath[0, i] = volt.Volt_nml[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(volt.Volt_nml[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(volt.Volt_nml[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(volt.Volt_nml[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("gls"))
                        {
                            int i = 0;
                            FilePath[0, i] = volt.Volt_gls[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(volt.Volt_gls[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(volt.Volt_gls[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(volt.Volt_gls[imagecheck].seeklength);
                        }
                        if (WeaponName.Contains("spc"))
                        {
                            int i = 0;
                            FilePath[0, i] = volt.Volt_spc[imagecheck].name;
                            i++;
                            FilePath[0, i] = Convert.ToString(volt.Volt_spc[imagecheck].seek);
                            i++;
                            FilePath[0, i] = Convert.ToString(volt.Volt_spc[imagecheck].length);
                            i++;
                            FilePath[0, i] = Convert.ToString(volt.Volt_spc[imagecheck].seeklength);
                        }
                        //需要修复
                        break;
                    default:
                        break;
                }
            }
            else if (WeaponName.Contains("Skin31"))
            {
                //等待RPAK文件开发中...
                //To do...
            }
        }
    }
}
