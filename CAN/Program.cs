
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace CAN
{
    internal static class Program
    {

        
        /// <summary>  
        ///  The main entry point for the application.  
        /// </summary>  
        [STAThread]
        static void Main(string[] arge)
        {
            // To customize application configuration such as set high DPI settings or default font,  
            // see https://aka.ms/applicationconfiguration.  
            // ApplicationConfiguration.Initialize();  
            //ComWrappers.RegisterForMarshalling(WinFormsComInterop.WinFormsComWrappers.Instance);
            var command = string.Join(" ", arge);
            AntdUI.Localization.DefaultLanguage = "zh-CN";
            var lang = AntdUI.Localization.CurrentLanguage;
            //if (lang.StartsWith("en")) AntdUI.Localization.Provider = new Localizer();
            AntdUI.Config.TextRenderingHighQuality = true;
            AntdUI.Config.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            //AntdUI.Config.SetEmptyImageSvg(Properties.Resources.icon_empty, Properties.Resources.icon_empty_dark);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            //if (command == "m")
                Application.Run(new Main());
            //else if (command == "color") Application.Run(new Colors());  
            //else Application.Run(new Overview(command == "t"));  
            //Application.Run(new Main());  

              
        }
    }
}