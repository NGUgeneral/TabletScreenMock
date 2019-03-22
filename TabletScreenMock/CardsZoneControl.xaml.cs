using System;
using System.Windows.Controls;

namespace TabletScreenMock
{
  /// <summary>
  /// Interaction logic for CardsZoneControl.xaml
  /// </summary>
  public partial class CardsZoneControl : UserControl
  {
		UIElementCollection Cards;
		Random Random = new Random();

    public CardsZoneControl()
    {
      InitializeComponent();
			InitCustomComponents();
    }

		private void InitCustomComponents()
		{
			Cards = Area.Children;
		}

		public void AddCard(Card card)
		{
			if(Cards.Count > GameConsts.MaxCards)
				return;

			Area.Children.Add(card);
		}

		public void RemoveCard(Card card)
		{
			Area.Children.Remove(card);
		}

		public void RemoveCard()
		{
			if(Cards.Count < 1)
				return;

			var card = Area.Children[Random.Next(Area.Children.Count)];
			Area.Children.Remove(card);
		}
  }
}
