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

namespace WPFCardGameApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (CardGameClassLibrary.CardGameDBContext db = new CardGameClassLibrary.CardGameDBContext())
            {
                CardGameClassLibrary.Models.Cards.ArcherCard card = new CardGameClassLibrary.Models.Cards.ArcherCard
                {
                    IdFraction = 1,
                    Health = 1,
                    Attack = 1,
                    Cost = 1,
                    Description = "1",
                    Name = "1"
                };
                db.Cards.Add(card);
                db.SaveChanges();
            }
        }
    }
}
