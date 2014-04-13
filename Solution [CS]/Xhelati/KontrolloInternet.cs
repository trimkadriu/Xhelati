using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Xhelati
{
    class KontrolloInternet
    {
        private const int JashtKohe = 60;
        private String berllog = "[012345678901234567890123456789]";
        byte[] Buffer;
        private string adresa = "www.google.com";
        private Ping pingi = new Ping();
        private PingReply pergjigja;
        private bool akaInternet;
        private string shkrusi = "http://jareck.byethost14.com/shkrusi.php";
        private string rezultati;

        public KontrolloInternet()
        {
            Buffer = Encoding.ASCII.GetBytes(berllog);
        }

        public void Kontrollo()
        {
            try
            {
                for (int i = 0; i <= 3; i++)
                {
                    pergjigja = pingi.Send(adresa, JashtKohe, Buffer);
                    if (pergjigja.Status == IPStatus.Success)
                    {
                        akaInternet = true;
                    }
                }
            }
            catch
            {
                akaInternet = false;
            }
        }

        public bool KtheAkainternet()
        {
            return akaInternet;
        }

        public string VendosPoenat(string emri, int piket)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = "C:\\Program Files\\Internet Explorer\\iexplore.exe";
                startInfo.Arguments = shkrusi + "?emri=" + emri + "&poenat=" + piket;
                Process processi = new Process();
                processi.StartInfo = startInfo;
                processi.Start();
                System.Threading.Thread.Sleep(5000);
                KillProcessAndChildren(processi.Id);
                rezultati = "SUKSES";
            }
            catch (Exception ex)
            {
                rezultati = ex.Message;
            }
            return rezultati;
        }

        private void KillProcessAndChildren(int pid)
        {
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }

    }
}
