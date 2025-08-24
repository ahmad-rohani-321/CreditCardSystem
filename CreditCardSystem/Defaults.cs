using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardSystem
{
    internal static class Defaults
    {
        /// <summary>
        /// return party types
        /// 0 = mushtari
        /// 1 = suppiler
        /// 2 = system
        /// </summary>
        internal static string[] DefaultPartyTypes { 
            get { 
                return ["مشتري", "سپلایر", "سیسټم"]; 
            } 
        }
        /// <summary>
        /// transactions types
        /// 0 frosh
        /// 1 kharid
        /// 2 transfar
        /// 3 rasid
        /// </summary>
        internal static string[] DefaultTransactionTypes { 
            get {
                return ["فروش", "خرید", "ټرانسفر", "نقد"];
            }
        }
        /// <summary>
        /// physical database path
        /// </summary>
        internal static string DatabasePath
        {
            get
            {
                return $"{DatabaseFolderPath}\\Credit Card System.db";
           }
        }
        /// <summary>
        /// physical database folder
        /// </summary>
        internal static string DatabaseFolderPath
        {
            get
            {
                string path = @$"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\Credit Card System";
                return path;
           }
        }
        /// <summary>
        /// pops up for a questions and a yesno result as DeialogResult
        /// </summary>
        internal static DialogResult YesNoMessageBox(string message)
        {
            return XtraMessageBox.Show(message, "پوښتنه", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        /// <summary>
        /// just show up for OK with no parameters
        /// </summary>
        internal static void MessageBox()
        {
            XtraMessageBox.Show("عملیه ترسره سوه", "خبرتیا", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// just show up for OK with message parameter
        /// </summary>
        internal static void MessageBox(string message)
        {
            XtraMessageBox.Show(message, "خبرتیا", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// just show up for OK with no parameters, for error
        /// </summary>
        internal static void ErrorMessageBox()
        {
            XtraMessageBox.Show("عملیه ترسره نه سوه!", "خبرتیا", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// just show up for OK with message parameter, for error
        /// </summary>
        internal static void ErrorMessageBox(string message)
        {
            XtraMessageBox.Show(message, "خبرتیا", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
