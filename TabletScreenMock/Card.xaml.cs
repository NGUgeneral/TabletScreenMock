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
  /// Interaction logic for Card.xaml
  /// </summary>
  public partial class Card : UserControl
  {
		private static Random random = new Random();
		public string Id { get; }

    public Card()
    {
      InitializeComponent();
			Id = random.Next(100).ToString();
			LoadCustomContent();
    }

		private void LoadCustomContent()
		{
			Title.Text = $@"Card: {Id}";
		}

		private void Area_MouseMove(object sender, MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (e.LeftButton == MouseButtonState.Pressed)
			{
				// Package the data.
				var data = new DataObject(this);

				// Inititate the drag-and-drop operation.
				DragDrop.DoDragDrop(this, data, DragDropEffects.All);
			}
		}
	}
}
