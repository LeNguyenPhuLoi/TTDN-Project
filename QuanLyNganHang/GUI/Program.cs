﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_KhachHang());
        }
    }



    // MỞ RA KHI MUỐN SỬ DỤNG ĐĂNG NHẬP

    //internal static class Program
    //{
    //    /// <summary>
    //    /// The main entry point for the application.
    //    /// </summary>
    //    [STAThread]
    //    static void Main()
    //    {
    //        Application.EnableVisualStyles();
    //        Application.SetCompatibleTextRenderingDefault(false);
    //        while (true)
    //        {
    //            using (frmDangNhap log = new frmDangNhap())
    //            {
    //                DialogResult result = log.ShowDialog();
    //                if (result == DialogResult.OK && log.NextForm != null)
    //                {
    //                    Application.Run(log.NextForm);
    //                }
    //                else
    //                {
    //                    break;
    //                }
    //            }
    //        }

    //    }
    //}
}
