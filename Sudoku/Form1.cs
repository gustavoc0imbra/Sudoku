using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SudokuMainForm : Form
    {
        
        /*
            TODO:
           - Condição
           - Aleatoriedade campo texto
           - escalar
         
         
         */

        public List<int> random = new List<int>();

        public SudokuMainForm()
        {
            InitializeComponent();
        }

        public int generateNumbers(int limit)
        {
            Random random = new Random();

            return random.Next(1, limit);
        }

        private void SudokuMainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                int number = this.generateNumbers(9);

                if (!random.Contains(number))
                {
                    random.Add(number);
                }
                else
                {
                    i--;
                }
            }

            for(int i = 0; i < 3; i++)
            {
                int number = this.generateNumbers(9);

                switch (number) 
                {
                    case 1:
                        if(txtBx1.Text == "")
                        {
                            txtBx1.Text = number.ToString();
                            txtBx1.Enabled = false;
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 2:
                        if (txtBx2.Text == "")
                        {
                            txtBx2.Text = number.ToString();
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 3:
                        if (txtBx3.Text == "")
                        {
                            txtBx3.Text = number.ToString();
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 4:
                        if (txtBx4.Text == "")
                        {
                            txtBx4.Text = number.ToString();
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 5:
                        if (txtBx5.Text == "")
                        {
                            txtBx5.Text = number.ToString();
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 6:
                        if (txtBx6.Text == "")
                        {
                            txtBx6.Text = number.ToString();
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 7:
                        if (txtBx7.Text == "")
                        {
                            txtBx7.Text = number.ToString();
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 8:
                        if (txtBx8.Text == "")
                        {
                            txtBx8.Text = number.ToString();
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 9:
                        if (txtBx9.Text == "")
                        {
                            txtBx9.Text = number.ToString();
                        }
                        else
                        {
                            i--;
                        }
                        break;
                }

            }


        }
    }
}
