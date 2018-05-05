using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ClinicSystem.App_Code
{
    public class Valid
    {
        /// <summary> 
        /// 判断是否是正确的身份证格式，只支持18位 
        /// </summary> 
        /// <param name="str"></param> 
        /// <returns></returns> 
        /// 
        public static bool IsPersonID(string str)
        {
            if (String.IsNullOrEmpty(str) | !Regex.IsMatch(str, @"^((1[1-5])|(2[1-3])|(3[1-7])|(4[1-6])|(5[0-4])|(6[1-5])|71|(8[12])|91)\d{4}(((19|20)\d{2}(0[13-9]|1[012])(0[1-9]|[12]\d|30))|((19|20)\d{2}(0[13578]|1[02])31)|((19|20)\d{2}02(0[1-9]|1\d|2[0-8]))|((19|20)([13579][26]|[2468][048]|0[48])0229))\d{3}(\d|X|x)$"))
                return false;

            if (str.ToString().Length == 18)
            {
                string birthday = string.Empty;
                birthday = String.Format("{0}-{1}-{2}", str.ToString().Substring(6, 4), str.ToString().Substring(10, 2), str.ToString().Substring(12, 2));
                try
                {
                    if (DateTime.Parse(birthday) > DateTime.Now)
                        return false;
                }
                catch (Exception ex)
                {
                    return false;
                }

                //char[] code = str.ToString().ToArray();
                ////加权因子 
                //int[] factor = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
                ////校验位 
                //char[] parity = { '1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2' };
                //int sum = 0;
                //for (int i = 0; i < 17; i++)
                //{
                //    sum = Convert.ToInt32(code[i].ToString()) * factor[i];
                //}
                //char last = parity[sum % 11];
                //try
                //{
                //    if (last != char.ToUpper(code[17]))
                //    {
                //        return false;
                //    }
                //}
                //catch (Exception)
                //{
                //    if (last != code[17])
                //    {
                //        return false;
                //    }
                //}
            }

            return true;
        }

        /// <summary>
        /// 判断是否是做正确的联系方式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsContact(string str){
            if (String.IsNullOrEmpty(str) | !Regex.IsMatch(str, @"^(0|86|17951)?([1][3-9][0-9]{9})$"))
                return false;
            return true;
        }
    }
}
