using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;
using System.Diagnostics;

namespace lab4_game_of_life
{
    public partial class Form1 : Form
    {
        int[,] foreground = new int[80, 60]; // store foreground dots 
        int[,] background = new int[80, 60];//store backgournd dots for next cycle
        CDrawer mydrawer;
        int cycle = 0;
        SpeedModeless speedDiaplog;
        int speed = 200;
        int cellsNumber =100;
        Color cellColor = Color.Red;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mydrawer = new CDrawer();
            mydrawer.Scale = 10;
            mydrawer.ContinuousUpdate = false;
            
        }




        private void Draw(ref CDrawer drawer,  int[,] cellArray,ref Color cellcolor)  //draw the canvas 
        {
            drawer.BBColour = Color.Black;
           
            for (int i = 0; i < cellArray.GetLength(0); i++)
            {
                for (int j = 0; j < cellArray.GetLength(1); j++)
                {
                    if (cellArray[i, j] ==1)
                    {
                        drawer.SetBBScaledPixel(i, j, cellcolor);

                    }
                   
                }
            }
            drawer.Render();
            
        }
        //radnomize array with  live cells excluding borader
        private void RandomizeCellArray(ref int[,] cellArray,ref int cellnumbers)
        {
            cellArray = new int[80, 60];
            int counter = 0;
            Random rnd = new Random();
         
                    do
                    {
                        int randomX = rnd.Next(1, 79);
                        int randomY = rnd.Next(1, 59);
                        if (cellArray[randomX,randomY]!=1)
                        {
                            cellArray[randomX, randomY] = 1;
                            counter++;
                        }

                    } while (counter<cellnumbers);
                    

        }

        private void button1_Click(object sender, EventArgs e) //new pattern button
        {
            NewPattern_ModeDialog NewPatternDialog = new NewPattern_ModeDialog();
            if (NewPatternDialog.ShowDialog()==DialogResult.OK)
            {
                cellColor = NewPatternDialog._color;
                cellsNumber = NewPatternDialog._cellNumber;
            }
            RandomizeCellArray(ref foreground,ref cellsNumber);
            Draw(ref mydrawer, foreground,ref cellColor);
            cycle = 0;
        }
        private void LifeCycle(ref int[,]foreground,ref int[,]background,ref int countcycle)
        {
            lbl_Circle.Text = cycle.ToString();   //dispaly # of cycles on label 

            for (int i = 1; i < foreground.GetLength(0)-1; i++)
            {
                for (int j = 1; j < foreground.GetLength(1)-1; j++)
                {
                  
                        int counter = 0;//counter for live cells around live cell
                        if (foreground[i, j - 1] == 1) counter++; //up
                        if (foreground[i, j + 1] == 1) counter++; //down
                        if (foreground[i-1, j] == 1) counter++; //left
                        if (foreground[i+1, j ] == 1) counter++;//right
                        if (foreground[i-1, j-1] == 1) counter++;//upper left
                        if (foreground[i+1, j -1 ] == 1) counter++;//upper right
                        if (foreground[i-1, j +1] == 1) counter++;//lower left
                        if (foreground[i+1, j + 1] == 1) counter++;//lower right
                 
                    if (foreground[i, j] == 1)
                    {
                        if (counter < 2) background[i, j] = 0;
                        if (counter > 3) background[i, j] = 0;
                        if (counter == 2 || counter == 3) background[i, j] = 1;
                    }
                    if (foreground[i, j] == 0 && counter == 3) background[i, j] = 1;
                }
            }
            Draw(ref mydrawer, background,ref cellColor);
            foreground = background;
            background = new int[80, 60];
            cycle++;


        }

        private void button4_Click(object sender, EventArgs e )// cycle button 
        {
            LifeCycle(ref foreground, ref background,ref cycle);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LifeCycle(ref foreground, ref background,ref cycle);
            timer1.Interval = speed;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
        //start button
        private void button2_Click(object sender, EventArgs e)  
        {
            //open speed dialog
            if (null==speedDiaplog)
            {
                speedDiaplog = new SpeedModeless();
            }
            speedDiaplog._dGetSpeed = CallbackGetSpeed;
            speedDiaplog.Show();



            timer1.Enabled = true;
           
            btn_Stop.Enabled = true;
            btn_Cycle.Enabled = false;
            btn_Start.Enabled = false;
            btn_NewPattern.Enabled = true;

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            btn_Stop.Enabled = false;
            btn_Cycle.Enabled = true;
            btn_Start.Enabled = true;
            btn_NewPattern.Enabled = false;
            timer1.Enabled = false;
        }







        //Call back Method 
        private void CallbackGetSpeed(int i)
        {
            speed = i;
        }

    }
}
