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

namespace TabletScreenMock
{
  /// <summary>
  /// Interaction logic for Screen.xaml
  /// </summary>
  public partial class Screen : UserControl
  {
    public Screen()
    {
        InitializeComponent();
    }

		private void ActionTitleParser(string text)
		{
			ActionTitle.Text = $@"You have clicked: {text}";
		}

		private void SwipeLeft_Click(object sender, RoutedEventArgs e)
		{
			ActionTitleParser(((Button)sender).Name);
		}

		private void SwipeRight_Click(object sender, RoutedEventArgs e)
		{
			ActionTitleParser(((Button)sender).Name);
		}

		private void SwipeUp_Click(object sender, RoutedEventArgs e)
		{
			ActionTitleParser(((Button)sender).Name);
		}

		private void DragUp_Click(object sender, RoutedEventArgs e)
		{
			ActionTitleParser(((Button)sender).Name);
		}

		private void DragDown_Click(object sender, RoutedEventArgs e)
		{
			ActionTitleParser(((Button)sender).Name);
		}

		private void PickCard_Click(object sender, RoutedEventArgs e)
		{
			CardZone.AddCard(new Card());
			ActionTitleParser(((Button)sender).Name);
		}

		private void RemoveCard_Click(object sender, RoutedEventArgs e)
		{
			CardZone.RemoveCard();
			ActionTitleParser(((Button)sender).Name);
		}
	}
}
