using System;
using System.Net;
using System.IO;
using Mozilla.NUniversalCharDet;
using System.Windows.Forms;

namespace NUCD_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            CharSetBox.Text = "";
            PageBox.Text = "";

            HttpWebRequest hwr = (HttpWebRequest)HttpWebRequest.Create(UrlBox.Text);
            HttpWebResponse res;
            try
            {
                res = (HttpWebResponse)hwr.GetResponse();
            }
            catch
            {
                CharSetBox.Text = "网页获取错误！";
                return;
            }

            if (res.StatusCode == HttpStatusCode.OK)
            {
                Stream mystream = res.GetResponseStream();
                MemoryStream msTemp = new MemoryStream();
                int len = 0;
                byte[] buff = new byte[512];
                StreamReader ReadPage = new StreamReader(mystream);
      

                while ((len = mystream.Read(buff, 0, 512)) > 0)
                {
                    msTemp.Write(buff, 0, len);

                }
                res.Close();

                if (msTemp.Length > 0)
                {
                    msTemp.Seek(0, SeekOrigin.Begin);
                    byte[] PageBytes = new byte[msTemp.Length];
                    msTemp.Read(PageBytes, 0, PageBytes.Length);

                    msTemp.Seek(0, SeekOrigin.Begin);
                    int DetLen = 0;
                    byte[] DetectBuff = new byte[4096];

                    //CharsetListener listener = new CharsetListener();

                    UniversalDetector Det = new UniversalDetector(null);
                    //while ((DetLen = msTemp.Read(DetectBuff, 0, DetectBuff.Length)) > 0 && !Det.IsDone())
                    //{
                    //    Det.HandleData(DetectBuff, 0, DetectBuff.Length);
                    //}
                    Det.HandleData(PageBytes, 0, PageBytes.Length);
                    Det.DataEnd();
                    if (Det.GetDetectedCharset()!=null)
                    {
                        CharSetBox.Text = "OK! CharSet=" + Det.GetDetectedCharset();
                        PageBox.Text = System.Text.Encoding.GetEncoding(Det.GetDetectedCharset()).GetString(PageBytes);
                    }
                    Det.Reset();
                }


            }
        }
    }
    //Report作为ICharsetListener唯一的方法，在UniversalDetector.DataEnd时，如果找到了编码会调用
    public class CharsetListener : ICharsetListener
    {
        public string Charset;
        public void Report(string charset)
        {
            this.Charset = charset;
        }
    }
}
