using OpenQA.Selenium.Support.PageObjects;
using System;
using System.IO;
using BuyPlan.Automation.Framework.Config;

//namespace BuyPlan.Automation.Framework.Helpers
//{
//    class LogHelpers
//    {
//        //Global Decaration
//        private static string _logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
//        private static StreamWriter _streamw = null;

//        //Create a file which can store the
//        public static void CreateLogFile()
//        {
//            string dir = AppSettings.LogPath;
//            if (Directory.Exists(dir))
//            {
//                _streamw = File.AppendText(dir + _logFileName + ".log");
//            }
//            else
//            {
//                Directory.CreateDirectory(dir);
//                _streamw = File.AppendText(dir + _logFileName + ".log");
//            }
//        }


//        //Create a method which cna write the text in log file
//        public static void Write(string logMessage)
//        {
//            _streamw.Write("{0}  {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
//            _streamw.WriteLine("    {0}", logMessage);
//            _streamw.Flush();
//        }
//    }
//}
