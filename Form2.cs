using System;  
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
      
        private void btn_browse_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog op = new OpenFileDialog();
                op.ShowDialog();
                if (op.ShowDialog() == DialogResult.OK)
                {


                    textBox1.Text = op.FileName;
                }
            }
            catch { }
        }
        DataTable table = new DataTable();
        private void Form2_Load(object sender, EventArgs e)
        {
            table.Columns.Add("A", typeof(string));
            table.Columns.Add("B", typeof(String));
            table.Columns.Add("C", typeof(String));
            table.Columns.Add("D", typeof(String));
            table.Columns.Add("E", typeof(String));
            table.Columns.Add("F", typeof(String));
            table.Columns.Add("G", typeof(String));
            table.Columns.Add("H", typeof(String));
            table.Columns.Add("I", typeof(string));
            table.Columns.Add("J", typeof(String));
            table.Columns.Add("K", typeof(String));
            table.Columns.Add("L", typeof(String));
            table.Columns.Add("M", typeof(String));
            table.Columns.Add("N", typeof(String));
            table.Columns.Add("O", typeof(String));
            table.Columns.Add("P", typeof(String));

            dataGridView1.DataSource = table;
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int indexofarray = 0;
            string noteline;          
            string[] lines = new string[36];
            string[,] abc = new string[36, 16];
            string[] tab = new string[16];
            int i;
            int j;
            string[] values;
            string[] values1;
            string[] values2;
            System.IO.StreamReader file =new System.IO.StreamReader(textBox1.Text.Trim());
            while ((noteline = file.ReadLine()) != null)
            {
               
                if(noteline.StartsWith("R="))
                {
                    if (indexofarray < 36)
                    {

                        lines[indexofarray] = noteline;

                        
                    }
                    else
                    {
                        System.Console.WriteLine("hi this is second");

                        for (i = 0; i < lines.Length; i++)
                        {
                            values1 = lines[i].ToString().Split(' ');
                            values2 = values1.Take(17).ToArray();

                            values = values2.Skip(1).ToArray();

                            string[] row = new string[values.Length];

                            for (j = 0; j < values.Length; j++)
                            {

                                row[j] = values[j].Trim();
                                abc[i, j] = row[j];
                                Console.Write(abc[i, j] + "\t");

                            }
                            Console.WriteLine();

                           
                        }
                        


                        indexofarray = 0;
                        lines[indexofarray] = noteline;
                        for (i = 0; i < 36; i++)
                        {
                            for (j = 0; j < 16; j++)
                            {

                                tab[j] = abc[i, j];

                            }
                            table.Rows.Add(tab);

                        }


                    }
                }
                else
                {
                    continue; 
                }
                counter++;
                indexofarray++;
            }


            

            file.Close();
            System.Console.WriteLine("There were {0} lines.", counter);
            // Suspend the screen.  
            System.Console.ReadLine();
        }
    }
}
