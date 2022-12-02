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

namespace Bossfighter
{
    public partial class MainWindow : Window
    {
        Queue<Enemy> frontaNepratel = new Queue<Enemy>();
        Enemy aktualniNepritel;
        int hracHP = 100;
        int hracDMG = 25;

        public MainWindow()
        {
            InitializeComponent();
            Enemy nep1 = new Enemy();
            nep1.Jmeno = "Pindour";
            nep1.HP = 150;
            nep1.Utok = 20;
            nep1.Obrazek = "obrazky/enemy1.png";

            Enemy nep2 = new Enemy();
            nep1.Jmeno = "Cigos";
            nep2.HP = 250;
            nep2.Utok = 30;
            nep2.Obrazek = "obrazky/enemy2.png";

            Enemy nep3 = new Enemy();
            nep1.Jmeno = "Cigan";
            nep3.HP = 300;
            nep3.Utok = 35;
            nep3.Obrazek = "obrazky/enemy3.png";

            frontaNepratel.Enqueue(nep1);
            frontaNepratel.Enqueue(nep2);
            frontaNepratel.Enqueue(nep3);

            aktualniNepritel = frontaNepratel.Peek();
        }
        public void Aktualizovat()
        {
            lbEnemyAtt.Content = Convert.ToString(aktualniNepritel.Utok);
            pgEnemyZivoty.Value = aktualniNepritel.HP;
            pgZivoty.Value = hracHP;
            //aktualizace obrázku
        }
        //att
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            aktualniNepritel.HP -= hracDMG;
            Aktualizovat();
        }
        //def
        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            //blok - doděláme příště :)
        }
        //heal
        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            hracHP += 20;
            Aktualizovat();
        }

        private void btnDalsiKolo_Click(object sender, RoutedEventArgs e)
        {
            hracHP -= aktualniNepritel.Utok;
            if(hracHP < 0)
            {
                MessageBox.Show("Jsi mrtvý");
            }
            Aktualizovat();
        }
    }
}
