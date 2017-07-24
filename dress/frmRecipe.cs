using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace dress
{
    public partial class frmRecipe : Form
    {
        PictureBox[] img = new PictureBox[50];
        //Image[] imgMari = new Image[50];
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        string[] fisiere = new string[100];
        bool posibil = true;

        int nrListe = 1, nrImg = 0,scor=0;
        public frmRecipe()
        {
            InitializeComponent();
        }
        //------------------------------------------<imagini>
        private void imgCreate()
        {
            int x = 0, y = 0, lat = 70, dist = 5, i, j;
            fisiere = Directory.GetFiles(this.cale + "\\retete");
            nrImg =fisiere.Count();
            for (i = 0; i <nrImg; i++)
            {
                img[i] = new PictureBox();
                img[i].Size = new Size(lat, lat);
                img[i].Location = new Point(x, y);
                img[i].BorderStyle = BorderStyle.FixedSingle;
                img[i].SizeMode = PictureBoxSizeMode.Zoom;
                img[i].Image = new Bitmap(fisiere[i]);
                img[i].Tag = i;
                img[i].Click += new System.EventHandler(img_Click);
                panImg.Controls.Add(img[i]);

                x += lat + dist;
                if(i%6==5)
                {
                    y += lat ;
                    x = 0;
                }
                 
            }
        }


        private void img_Click(object sender, EventArgs e)
        {
            if (!posibil)
                return;
            int i = Convert.ToInt16((sender as PictureBox).Tag),k;


            if (img[i].BorderStyle==BorderStyle.FixedSingle)
            {
                lstAlese.Items.Add(i);
                img[i].BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {

                for (k = 0; k < lstAlese.Items.Count; k++)
                {
                    int idi = int.Parse(lstAlese.Items[k].ToString());
                    if (idi==i)
                    {
                        lstAlese.Items.RemoveAt(k);
                        img[i].BorderStyle = BorderStyle.FixedSingle;
                        break;
                    }
                }
                
            }

            

        }

        //----------------------------------------</imagini>     



        private void cboRetete_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            chkIngrediente.Items.Clear();
            lstAlese.Items.Clear();
           // lstImg.Items.Clear();
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select * from retete where reteta = @reteta";
            OleDbCommand com = new OleDbCommand(text, con);
            com.Parameters.AddWithValue("reteta", cboRetete.Text);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                chkIngrediente.Items.Add(r["ingredient"].ToString());
               // lstImg.Items.Add(r["tag"].ToString());
            }
            con.Close();
            //resetare imagini
            for (int i = 0; i < nrImg; i++)
            {
                img[i].BorderStyle = BorderStyle.FixedSingle;
            }
            posibil = true;
            pbFinal.Image = null; 
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            int i, j,nr=0;
            bool ok = true;
            if (chkIngrediente.Items.Count != lstAlese.Items.Count)
                ok=false;
            for(i=0;i<lstAlese.Items.Count ; i++)
            {
                nr = 0;
                int idi = int.Parse(lstAlese.Items[i].ToString());
                for (j=0;j<chkIngrediente.Items.Count ; j++)
                {
                    if(chkIngrediente.Items[j].ToString()==Path.GetFileNameWithoutExtension(fisiere[idi]))
                    {
                        nr++;
                        chkIngrediente.SetItemChecked(j,true);
                        break;
                    }

                }
                ok &= (nr == 1);    
            }
            if (ok)
            {
                scor++;
                pbFinal.BringToFront();
                pbFinal.Image = new Bitmap(cale + "\\reteteFinal\\" + cboRetete.Text + ".jpg");//------jpg sau png
            }
            else
            {
                scor--;
            }
            lblScor.Text = scor.ToString();
            //btnNew.PerformClick();
            posibil = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select distinct reteta from retete";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                cboRetete.Items.Add(r["reteta"].ToString());
            }
            con.Close();
          
            imgCreate();
            if(cboRetete.Items.Count>0)
                cboRetete.SelectedIndex = 0;
        }




    }
}
