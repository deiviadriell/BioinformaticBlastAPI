using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.IO;
using System.Diagnostics;


namespace BlastAPI
{
    public partial class frm_BlastAPI : Form
    {
        // Create a request using a URL BLAST  
        HttpWebRequest request = WebRequest.Create("https://blast.ncbi.nlm.nih.gov/blast/Blast.cgi") as HttpWebRequest;        
        
        public frm_BlastAPI()
        {
            InitializeComponent();
            // Set the Method property of the request to POST.              
            request.Method = "POST";
            request.AllowAutoRedirect = false;
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            request.ContentType = "application/x-www-form-urlencoded";
          
        }

        private void frm_BlastAPI_Load(object sender, EventArgs e)
        {
            

        }
        private string Blast()
        {
            try
            {

                string parameters = "CMD=Put&PROGRAM=blastn&MEGABLAST=on&DATABASE=nr&QUERY=" + HttpUtility.UrlEncode(txt_Secuencia.Text);
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] byte1 = encoding.GetBytes(parameters);
                request.ContentLength = byte1.Length;
                Stream postStream = request.GetRequestStream();
                postStream.Write(byte1, 0, byte1.Length);
                postStream.Close();
                HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse();
                Stream responseStream = webResponse.GetResponseStream();
                StreamReader responseStreamReader = new StreamReader(responseStream);
                string result = responseStreamReader.ReadToEnd();
                string aux = (result.Substring(result.IndexOf("RID = "), 30)).TrimEnd().TrimStart();
                string rid = aux.Substring(aux.IndexOf("= ") + 2, (aux.Length - aux.IndexOf("\n"))).TrimEnd();
                responseStream.Close();
                return rid;
            }
            catch (Exception ex)
            {
                return "Error en:" + ex.Message;
            }

        }

        private void btnBlast_Click(object sender, EventArgs e)
        {
            if (txt_Secuencia.Text != null && txt_Secuencia.Text != "")
            {
                string rid=Blast();
                if (!rid.Contains("Error en:"))
                {
                    Process.Start("https://blast.ncbi.nlm.nih.gov/Blast.cgi?CMD=Get&RID=" + rid);
                }
                else
                    MessageBox.Show("Error con la secuencia! / Error with the sequence!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else            
                MessageBox.Show("Ingrese la secuencia / Enter the sequence", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);            
        }
    }
}
