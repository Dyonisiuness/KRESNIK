using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UFA
{
    public partial class Form1 : Form
    {
        bool T = true;
        int NT = 0;
        int VX = 0;
        int VO = 0;
        public Form1()
        {
            InitializeComponent();
            Giz.Rows.Add(); Giz.Rows.Add(); Giz.Rows.Add();
            Giz.Rows[0].Height = 50; Giz.Rows[1].Height = 50; Giz.Rows[2].Height = 50;
            for (int i = 0; i < 3; i++) { for (int j = 0; j < 3; j++) { Giz.Rows[i].Cells[j].Value = "-"; } }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
   
        private void Giz_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Giz.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "-" && T==true) {
                Giz.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "X";
                T = false;
                NT += 1;
                A.Text = "Ход тебе, нолик.";

            }
            else if (Giz.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "-" && T == false)
            {
                Giz.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "O";
                T = true; NT += 1; A.Text = "Ход тебе, крестик.";
            }
            else { A.Text = "Выбери иную клетку, эта занята."; }
            //--------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------
            if (Giz.Rows[1].Cells[1].Value.ToString() == "X" && Giz.Rows[0].Cells[0].Value.ToString() == "X" &&
                Giz.Rows[2].Cells[2].Value.ToString() == "X")
            {
                A.Text = "X выйграл, давай по новой!";
                VX += 1;
                Score.Text = String.Format("{0}:{1}", VX, VO);
                for (int i = 0; i < 3; i++) { for (int j = 0; j < 3; j++) { Giz.Rows[i].Cells[j].Value = "-"; } }
                NT = 0;
                T = true;
            }
            if (Giz.Rows[1].Cells[1].Value.ToString() == "X" && Giz.Rows[0].Cells[2].Value.ToString() == "X" &&
                Giz.Rows[2].Cells[0].Value.ToString() == "X")
            {
                A.Text = "X выйграл, давай по новой!";
                VX += 1;
                Score.Text = String.Format("{0}:{1}", VX, VO);
                for (int i = 0; i < 3; i++) { for (int j = 0; j < 3; j++) { Giz.Rows[i].Cells[j].Value = "-"; } }
                NT = 0;
                T = true;
            }
            for (int s = 0; s < 3; s++)
            {
                if (Giz.Rows[s].Cells[1].Value.ToString() == "O" && Giz.Rows[s].Cells[0].Value.ToString() == "O" &&
   Giz.Rows[s].Cells[2].Value.ToString() == "O")
                {
                    A.Text = "O выйграл, давай по новой!";
                    VO += 1;
                    Score.Text = String.Format("{0}:{1}", VX, VO);
                    for (int i = 0; i < 3; i++) { for (int j = 0; j < 3; j++) { Giz.Rows[i].Cells[j].Value = "-"; } }
                    NT = 0; T = true;
                }

            }
            for (int s = 0; s < 3; s++)
            {
                if (Giz.Rows[1].Cells[s].Value.ToString() == "O" && Giz.Rows[0].Cells[s].Value.ToString() == "O" &&
   Giz.Rows[2].Cells[s].Value.ToString() == "O")
                {
                    A.Text = "O выйграл, давай по новой!";
                    VO += 1;
                    Score.Text = String.Format("{0}:{1}", VX, VO);
                    for (int i = 0; i < 3; i++) { for (int j = 0; j < 3; j++) { Giz.Rows[i].Cells[j].Value = "-"; } }
                    NT = 0; T = true;
                }

            }
            for (int s = 0; s < 3; s++)
            {
                if (Giz.Rows[s].Cells[1].Value.ToString() == "X" && Giz.Rows[s].Cells[0].Value.ToString() == "X" &&
   Giz.Rows[s].Cells[2].Value.ToString() == "X")
                {
                    A.Text = "X выйграл, давай по новой!";
                    VX += 1;
                    Score.Text = String.Format("{0}:{1}", VX, VO);
                    for (int i = 0; i < 3; i++) { for (int j = 0; j < 3; j++) { Giz.Rows[i].Cells[j].Value = "-"; } }
                    NT = 0; T = true;
                }

            }
            for (int s = 0; s < 3; s++)
            {
                if (Giz.Rows[1].Cells[s].Value.ToString() == "X" && Giz.Rows[0].Cells[s].Value.ToString() == "X" &&
   Giz.Rows[2].Cells[s].Value.ToString() == "X")
                {
                    A.Text = "X выйграл, давай по новой!";
                    VX += 1;
                    Score.Text = String.Format("{0}:{1}", VX, VO);
                    for (int i = 0; i < 3; i++) { for (int j = 0; j < 3; j++) { Giz.Rows[i].Cells[j].Value = "-"; } }
                    NT = 0; T = true;
                }

            }

            if (Giz.Rows[1].Cells[1].Value.ToString() == "O" && Giz.Rows[0].Cells[0].Value.ToString() == "O" &&
   Giz.Rows[2].Cells[2].Value.ToString() == "O")
            {
                A.Text = "O выйграл, давай по новой!";
                VO += 1;
                Score.Text = String.Format("{0}:{1}", VX, VO);
                for (int i = 0; i < 3; i++) { for (int j = 0; j < 3; j++) { Giz.Rows[i].Cells[j].Value = "-"; } }
                NT = 0; T = true;
            }
            if (Giz.Rows[1].Cells[1].Value.ToString() == "O" && Giz.Rows[0].Cells[2].Value.ToString() == "O" &&
                Giz.Rows[2].Cells[0].Value.ToString() == "O")
            {
                A.Text = "O выйграл, давай по новой!";
                VO += 1;
                Score.Text = String.Format("{0}:{1}", VX, VO);
                for (int i = 0; i < 3; i++) { for (int j = 0; j < 3; j++) { Giz.Rows[i].Cells[j].Value = "-"; } }
                NT = 0; T = true;
            }
            if (NT == 9)
            {
                A.Text = "Клево, у вас ничья. Давай по новой.";
                for (int i = 0; i < 3; i++) { for (int j = 0; j < 3; j++) { Giz.Rows[i].Cells[j].Value = "-"; } }
                T = true;

            }
        }   
    }
}
