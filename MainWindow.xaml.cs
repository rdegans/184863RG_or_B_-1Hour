/*
 * Name: Riley de Gans
 * Date: May 27th, 2019
 * Description: A program that finds the total number of combinations of orientations of rectangles sizes 2, 3 and 4 in a rectangle 50 units long
 * Note: Does not work for certain lower numbers of tiles, because of seeded starting values
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _184863RG_or_B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ulong finalNum;
            finalNum = findRed(50) + findGreen(50) + findBlue(50);
            MessageBox.Show(finalNum.ToString());
        }
        public ulong findRed (int tiles)
        {
            ulong count1 = 1;
            ulong count2 = 0;
            ulong temp;
            for (int i = 2; i < tiles; i++)
            {
                temp = count1 + count2 + 1;
                count2 = count1;
                count1 = temp;
                //MessageBox.Show(count1 + "");
            }
            return count1;
        }
        public ulong findGreen(int tiles)
        {
            ulong count1 = 1;
            ulong count2 = 0;
            ulong count3 = 0;
            ulong count4 = 0;
            ulong temp;
            for (int i = 3; i < tiles; i++)
            {
                temp = count2 + count3 + count4 + 2;
                count4 = count3;
                count3 = count2;
                count2 = count1;
                count1 = temp;
                //MessageBox.Show(count1 + "");
            }
            return count1;
        }
        public ulong findBlue(int tiles)
        {
            ulong count1 = 3;
            ulong count2 = 2;
            ulong count3 = 1;
            ulong count4 = 0;
            ulong count5 = 0;
            ulong count6 = 0;
            ulong temp; 
            for (int i = 6; i < tiles; i++)
            {
                temp = count3 + count4 + count5 + count6 + 3;
                count6 = count5;
                count5 = count4;
                count4 = count3;
                count3 = count2;
                count2 = count1;
                count1 = temp;
                //MessageBox.Show(count1 + "");
            }
            return count1;
        }
    }
}
