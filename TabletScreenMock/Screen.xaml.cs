using System.Windows;
using System.Windows.Controls;

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

		private void ActionTitleParser(object sender)
		{
			ActionTitle.Text = $@"You have clicked: {((Button)sender).Name}";
		}

		private void DropParser(string senderName, DragEventArgs e)
		{
			var card = (Card)e.Data.GetData(e.Data.GetFormats()[0]);
			ActionTitle.Text = $@"You have dropped card {(card).Id} to {senderName}";
			CardZone.RemoveCard(card);
		}

		private void SwipeLeft_Click(object sender, RoutedEventArgs e)
		{
			ActionTitleParser(sender);
		}

		private void SwipeLeft_Drop(object sender, DragEventArgs e)
		{
			DropParser(((Button)sender).Name, e);
		}

		private void SwipeRight_Click(object sender, RoutedEventArgs e)
		{
			ActionTitleParser(sender);
		}

		private void SwipeRight_Drop(object sender, DragEventArgs e)
		{
			DropParser(((Button)sender).Name, e);
		}

		private void SwipeUp_Click(object sender, RoutedEventArgs e)
		{
			ActionTitleParser(sender);
		}

		private void SwipeUp_Drop(object sender, DragEventArgs e)
		{
			DropParser(((Button)sender).Name, e);
		}

		private void DragUp_Click(object sender, RoutedEventArgs e)
		{
			ActionTitleParser(sender);
		}

		private void DragUp_Drop(object sender, DragEventArgs e)
		{
			DropParser(((Button)sender).Name, e);
		}

		private void DragDown_Click(object sender, RoutedEventArgs e)
		{
			ActionTitleParser(sender);
		}

		private void DragDown_Drop(object sender, DragEventArgs e)
		{
			DropParser(((Button)sender).Name, e);
		}

		private void GameArea_Drop(object sender, DragEventArgs e)
		{
			DropParser(((Grid)sender).Name, e);
		}

		private void PickCard_Click(object sender, RoutedEventArgs e)
		{
			CardZone.AddCard(new Card());
			ActionTitleParser(sender);
		}
	}
}
