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

using CardGameClassLibrary;
using CardGameClassLibrary.Models;

namespace WPFCardGameAdminApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            comboBoxFraction.DisplayMemberPath = "Name";
            comboBoxFraction.SelectedValuePath = "Id";
            using (CardGameDBContext db = new CardGameDBContext())
            {
                comboBoxFraction.ItemsSource = db.Fractions.ToList();
                dataGrid.ItemsSource = db.Cards.ToList();
            }
            comboBoxFraction.SelectedIndex = 0;
        }

        private void buttonAddFraction_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxFraction.Text == "")
            {
                MessageBox.Show("Field fraction is empty");
                return;
            }

            using (CardGameDBContext db = new CardGameDBContext())
            {
                Fraction fr = db.Fractions.FirstOrDefault(f => f.Name == textBoxFraction.Text);
                if (fr != null)
                {
                    MessageBox.Show("This fraction already exist");
                    return;
                }

                Fraction fraction = new Fraction
                {
                    Name = textBoxFraction.Text
                };
                db.Fractions.Add(fraction);
                db.SaveChanges();
                comboBoxFraction.ItemsSource = db.Fractions.ToList();
            }

        }

        private void buttonAddCard_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxHealth.Text == "" || textBoxAttack.Text == "" || textBoxName.Text == "" || textBoxDescription.Text == "" || textBoxCost.Text == "")
            {
                MessageBox.Show("Some field is empty");
                return;
            }

            CardGameClassLibrary.Models.Cards.Card card;
            int fraction = (int)comboBoxFraction.SelectedValue;

            switch (comboBoxType.SelectedItem.ToString())
            {
                case "Sworderman":
                    card = new CardGameClassLibrary.Models.Cards.SworderCard();
                    break;
                case "Archer":
                    card = new CardGameClassLibrary.Models.Cards.ArcherCard();
                    break;
                case "Siege":
                    card = new CardGameClassLibrary.Models.Cards.SiegeCard();
                    break;
                default:
                    card = null;
                    break;
            }

            card.Health = Convert.ToInt32(textBoxHealth.Text);
            card.Attack = Convert.ToInt32(textBoxAttack.Text);
            card.Name = textBoxName.Text;
            card.Description = textBoxDescription.Text;
            card.Cost = Convert.ToInt32(textBoxCost.Text);
            card.IdFraction = fraction;

            using (CardGameDBContext db = new CardGameDBContext())
            {
                db.Cards.Add(card);
                db.SaveChanges();
                dataGrid.ItemsSource = db.Cards.ToList();
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            char ch = (char)KeyInterop.VirtualKeyFromKey(e.Key);
            if ((ch < '0' || ch > '9') || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
                e.Handled = true;
        }
    }
}
