using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MIS
{
  public class Utility
    {
        public static Point FormsLocation;
        Form currentForm = null;
        private static frmMain homeForm;
        public static frmMain HomeForm { get { return homeForm; } set { homeForm = value; } }

        public static void ApplyNumericOnlyFormat(TextBox txt)
        {
            txt.KeyPress += new KeyPressEventHandler(Numeric_KeyPress);
        }
        static void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                if (Convert.ToInt32(e.KeyChar) != 8)// 8 for back space ,46 for delete
                {
                    e.Handled = true;
                }
            }
        }

        // A-Z or a-z only
        public static void ApplyCharacterOnlyFormat(TextBox txt)
        {
            txt.KeyPress += new KeyPressEventHandler(Character_KeyPress);
        }
        static void Character_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) == false)
            {
                if (Convert.ToInt32(e.KeyChar) != 8)// 8 for back space ,46 for delete
                {
                    e.Handled = true;
                }
            }
        }

        // for money format
        public static void ApplyMoneyOnlyFormat(TextBox txt)
        {
            txt.KeyPress += new KeyPressEventHandler(Money_KeyPress);
        }
        static void Money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                if (Convert.ToInt32(e.KeyChar) != 8)
                {
                    if (Convert.ToInt32(e.KeyChar) == 46 && ((TextBox)sender).Text.Contains(".") == false)
                    {
                        e.Handled = false;
                    }
                    else if (Convert.ToInt32(e.KeyChar) == 45 && ((TextBox)sender).SelectionStart == 0 && ((TextBox)sender).Text.Contains("-") == false)
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        public static void ApplyPhoneFormat(TextBox txt)
        {
            txt.KeyPress += new KeyPressEventHandler(Phone_KeyPress);
        }
        static void Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false)
            {
                if (Convert.ToInt32(e.KeyChar) != 8 && e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
        }


        public static void ShowMessage(string BodyText, string HeaderText)
        {
            MessageBox.Show(BodyText, HeaderText);
        }

        public static DialogResult ShowConfirmMessage(string BodyText, string HeaderText)
        {
            return MessageBox.Show(BodyText, HeaderText, MessageBoxButtons.YesNo);
        }
        public static void WriteToLog(Exception ex, Form frmOwner)
        {
            string filePath = Application.StartupPath + "\\ErrorLog.txt";
            if (!File.Exists(filePath))
            {
                FileStream fs = File.Create(filePath);
                fs.Close();
                fs.Dispose();
            }
            StreamWriter writer = File.AppendText(filePath);
            writer.WriteLine("-------------------------------------------" + DateTime.Now.ToString() + "-------------------------------------------");
            writer.WriteLine(ex.Message);
            writer.WriteLine(ex.InnerException);
            writer.WriteLine(ex.StackTrace);
            writer.WriteLine("----------------------------------------------------------------------------");
            MessageBox.Show("There was a problem in doing this action. Please contact support.", "");
            writer.Flush();
            writer.Close();
        }


        public static bool isEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        public static Boolean ValidatePhone(string ObjName)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ObjName.Trim(), "^[0-9,-/]+$") == true)
                return true;
            else
                return false;
        }
        public static Boolean ValidateEmail(string ObjName)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ObjName.Trim(), "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*") == true)
                return true;
            else
                return false;
        }
        public static Boolean ValidateNumeric(string ObjName)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ObjName.Trim(), "^[0-9.]+$") == true)
                return true;
            else
                return false;
        }
        public static Boolean ValidateAlphaNumeric(string ObjName)
        {
            //            if (System.Text.RegularExpressions.Regex.IsMatch(ObjName.Trim(), "^[A-Za-z0-9(/)- # ]+$") == true)
            if (System.Text.RegularExpressions.Regex.IsMatch(ObjName.Trim(), "^[A-Za-z0-9 .\'\"&%?,#/-]+$") == true)
                return true;
            else
                return false;
        }
        ///
        public static Boolean ValidateUrl(string ObjName)
        {
            //            if (System.Text.RegularExpressions.Regex.IsMatch(ObjName.Trim(), "^[A-Za-z0-9(/)- # ]+$") == true)
            if (System.Text.RegularExpressions.Regex.IsMatch(ObjName.Trim(), "^([\\w-]+\\.)+[\\w-]+(/[\\w- ./?%&=]*)?") == true)
                return true;
            else
                return false;
        }
        public static Boolean ValidateLetter(string ObjName)
        {
            // if (System.Text.RegularExpressions.Regex.IsMatch(ObjName.Trim(), "^[A-Za-z0-9(/)- # ]+$") == true)
            if (System.Text.RegularExpressions.Regex.IsMatch(ObjName.Trim(), "^[a-zA-Z ]+$") == true)
            {
                return true;
            }
            else if (ObjName == "")
            {
                return true;
            }
            else
                return false;
        }


        //private void validateTextCharacterCustomized(object sender, EventArgs e)
        //{
        //    TextBox T = (TextBox)sender;

        //    try
        //    {
        //        //Not Allowing Numbers, Underscore or Hash
        //        char[] UnallowedCharacters = { '0', '1',
        //                                   '2', '3', 
        //                                   '4', '5',
        //                                   '6', '7',
        //                                   '8', '9','_','#'};

        //        if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
        //        {
        //            int CursorIndex = T.SelectionStart - 1;
        //            T.Text = T.Text.Remove(CursorIndex, 1);

        //            //Align Cursor to same index
        //            T.SelectionStart = CursorIndex;
        //            T.SelectionLength = 0;
        //        }
        //    }
        //    catch (Exception) { }
        //}         


        //private void validateTextCharacter(object sender, EventArgs e)
        //{
        //    TextBox T = (TextBox)sender;
        //    try
        //    {
        //        //Not Allowing Numbers
        //        char[] UnallowedCharacters = { '0', '1',
        //                                   '2', '3', 
        //                                   '4', '5',
        //                                   '6', '7',
        //                                   '8', '9'};

        //        if (textContainsUnallowedCharacter(T.Text, UnallowedCharacters))
        //        {
        //            int CursorIndex = T.SelectionStart - 1;
        //            T.Text = T.Text.Remove(CursorIndex, 1);

        //            //Align Cursor to same index
        //            T.SelectionStart = CursorIndex;
        //            T.SelectionLength = 0;
        //        }
        //    }
        //    catch (Exception) { }
        //}





        // validate range


        //public static Boolean validateRange(string ObjName)
        //{
        //    if (System.Text.RegularExpressions.Regex.IsMatch(ObjName.Trim(), "{10,45}") == true)
        //        return true;
        //    else
        //        return false;

        //}

        //for pattern validation (222-345-5647)
        //      "^\\d{3}-\\d{3}-\\d{4}$";


        //public static void LoadInitialSettings()
        //{
        //    Setting st = ListClassTemp.GetSettings();
        //    MISCurrentSettings.CompanyName = st.CompanyName;
        //    MISCurrentSettings.LeavesPerAnum = st.LeavesPerAnum;
        //    MISCurrentSettings.OffDaysAWeek = st.OffDaysAWeek;
        //    MISCurrentSettings.OfficeTimeFrom = st.OfficeTimeFrom;
        //    MISCurrentSettings.OfficeTimeTo = st.OfficeTimeTo;
        //    MISCurrentSettings.ReportsFooter = st.ReportsFooter;
        //    MISCurrentSettings.ReportsHeader = st.ReportsHeader;
        //}
    }
}
