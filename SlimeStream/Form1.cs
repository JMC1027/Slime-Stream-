using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlimeStream
{
    public partial class SlimeStream : Form
    {
        public SlimeStream()
        {
            InitializeComponent();
        }
        string[] paths, files; //Global variables of string array to save titles of music 

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true; //Selects multiple songs from files
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames; //Saves name of track in file array
                paths = ofd.FileNames; //saves path of track in path array 
                for(int x = 0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]); //Show songs in listbox
                }
            }
        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code to play selected song
            axWindowsMediaPlayer1.URL = paths[track_list.SelectedIndex];
        }

        private void track_volume_Load(object sender, EventArgs e)
        {

        }

        private void lbl_track_start_Click(object sender, EventArgs e)
        {

        }
    }
}
