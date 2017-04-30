using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; 

namespace WindowsProcessControlTest
{
    class WindowsProcessControl
    {   
        //開啟應用程式
        public void StartProcess(string ProcessName)
        {
            try
            {
                Process.Start(ProcessName);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }        

        //關閉應用程式
        public void CloseProcess(string ProcessName)
        {
            try
            {
                Process[] ps = Process.GetProcesses();
                foreach(Process p in ps)
                {
                    if(p.ProcessName == ProcessName)
                    {
                        p.CloseMainWindow();
                        p.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //強制關閉應用程式
        public void KillProcess(string ProcessName, int ProcessID)
        {
            try
            {
                Process[] ps = Process.GetProcesses();
                foreach(Process p in ps)
                {
                    if(p.ProcessName == ProcessName && p.Id == ProcessID)
                    {
                        p.Kill();
                    }                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //判斷應用程式是否執行中
        public bool IsProcessExist(string ProcessName)
        {
            try
            {
                Process[] ps = Process.GetProcesses();
                foreach(Process p in ps)
                {
                    if(p.ProcessName == ProcessName)
                    {
                        return true;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }         
            return false;
        }

        /*
         * Source
         * http://einboch.pixnet.net/blog/post/244599530-%E5%88%A9%E7%94%A8c%23%E7%A8%8B%E5%BC%8F%E4%BE%86%E6%8E%A7%E5%88%B6windows%E4%B8%AD%E7%9A%84%E8%99%95%E7%90%86%E7%A8%8B%E5%BA%8F
         * 
         * */
        
        public string[] getAllProcess()
        {
            Process[] ps = Process.GetProcesses();
            string[] s = new String[ps.Length];
            int i = 0;
            foreach (Process p in ps)
            {
                s[i] = p.ProcessName + "@" + p.Id;                
                i++;
            }

            /*
             * Example String
             * calc (ID:1234)
             * */

            return s;
        }

        public int getIdByName(string processName)
        {
            Process[] ps = Process.GetProcesses();
            foreach (Process p in ps)
            {
                if (p.ProcessName == processName)
                {
                    return p.Id;                    
                }
            }
            return -1;
        }
    }    
}
