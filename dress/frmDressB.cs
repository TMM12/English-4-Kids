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
    public partial class frmDressG : Form
    {
        PictureBox[] img = new PictureBox[50];
        //Image[] imgMari = new Image[50];
        string cale = Path.GetDirectoryName(Application.ExecutablePath);
        string[] fisiere = new string[100];
        bool posibil = true;

        int nrListe = 1, nrImg = 0,scor=0;
        public frmDressG()
        {
            InitializeComponent();
        }
        //------------------------------------------<imagini>
        private void imgCreate()
        {
            int x = 0, y = 0, lat = 50, dist = 5, i, j;
            fisiere = Directory.GetFiles(this.cale + "\\haineF_mic");
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
                //imgMari[i] = new Bitmap(imgMare(i));

                x += lat + dist;
                if(i%4==3)
                {
                    y += lat ;
                    x = 0;
                }
                 
            }
        }
        private string imgMare(int i)
        {
            string fis= cale + "\\haineF\\" + Path.GetFileName(fisiere[i]);
            return fis;
        }

        private void img_Click(object sender, EventArgs e)
        {
            if (!posibil)
                return;
            int i = Convert.ToInt16((sender as PictureBox).Tag),k,sters=-1;
            Image baza, ad;
            Graphics g;

            if (img[i].BorderStyle==BorderStyle.FixedSingle)
            {
                baza = new Bitmap(pb.Image, 291, 355);
                ad = new Bitmap(imgMare(i));//-------
                g = Graphics.FromImage(baza);
                g.DrawImage(ad, 0, 0,291,355);
                pb.Image = baza;
                lstAlese.Items.Add(i);
                img[i].BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                baza = new Bitmap(pb.BackgroundImage, 291, 355);
                for (k = 0; k < lstAlese.Items.Count; k++)
                {
                    int idi = int.Parse(lstAlese.Items[k].ToString());
                    if (idi!=i)
                    {
                        ad = new Bitmap(imgMare(idi));//---------------
                        g = Graphics.FromImage(baza);
                        g.DrawImage(ad, 0, 0,291,355);
                    }
                    else
                    { sters = k; }
                }
                pb.Image = baza;
                lstAlese.Items.RemoveAt(sters);
                img[i].BorderStyle = BorderStyle.FixedSingle;
                

            }

            

        }

        //----------------------------------------</imagini>     


        private void btnNew_Click(object sender, EventArgs e)
        {
            int nrl = new Random().Next(1, nrListe + 1);
            chkSarcini.Items.Clear();
            lstAlese.Items.Clear();
            lstImg.Items.Clear();
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data source=" + cale + "\\Soft.accdb");
            con.Open();
            string text = "select * from haineF where lista = @lista";
            OleDbCommand com = new OleDbCommand(text, con);
            com.Parameters.AddWithValue("lista", nrl);
            com.Parameters["lista"].DbType = DbType.Int16;
            OleDbDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                chkSarcini.Items.Add(r["denumire"].ToString());
                lstImg.Items.Add(r["tag"].ToString());
            }
            con.Close();
            //resetare imagini
            btnEmpty.PerformClick();
            posibil = true;
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            pb.Image = new Bitmap(pb.BackgroundImage);
            lstAlese.Items.Clear();
            for (int i = 0; i < nrImg; i++)
            {
                img[i].BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            int i, j,nr=0;
            bool ok = true;
            if (lstImg.Items.Count != lstAlese.Items.Count)
                ok=false;
            for(i=0;i<lstAlese.Items.Count ; i++)
            {
                nr = 0;
                int idi = int.Parse(lstAlese.Items[i].ToString());
                for (j=0;j<lstImg.Items.Count ; j++)
                {
                    if(lstImg.Items[j].ToString()==Path.GetFileNameWithoutExtension(fisiere[idi]))
                    {
                        nr++;
                        chkSarcini.SetItemChecked(j,true);
                        break;
                    }

                }
                ok &= (nr == 1);    
            }
            if (ok)
            {
                scor++;
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
            string text = "select max(lista) as maxim from haineF ";
            OleDbCommand com = new OleDbCommand(text, con);
            OleDbDataReader r = com.ExecuteReader();
            if (r.Read())
            {
                nrListe = int.Parse(r["maxim"].ToString());
            }
            con.Close();
            btnNew.PerformClick();
            imgCreate();
        }




    }
}
