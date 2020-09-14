using movie.BLL;
using movie.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movie.PL
{
    public partial class frmActor : Form
    {
        actorDAL oActor;
        public frmActor()
        {
            oActor = new actorDAL();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.png;)|*.jpg; *.jpeg; *.gif; *.png;";
            if(open.ShowDialog()==DialogResult.OK)
            {
                imgBox.Image = new Bitmap(open.FileName);
            }
        }



        private actorBLL Info()
        {
            actorBLL oActorBLL = new actorBLL();

            //oActorBLL.ID = 0; int.TryParse(txtID.text, out ID);
            

            oActorBLL.Name = textName.Text;
             //oActorBLL.Img = imgBox.Image;
            //oActor.Date = textDate.text;
            // oActor.Gender = textGender.text;

            return oActorBLL;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            oActor.ADD(Info());
        }
    }
}
