using System;
using Xamarin.Forms;
namespace EmptyGroup
{
    public class GroupHeaderCell : ViewCell
    {
        readonly Frame frame = new Frame
        {
            Padding = 5,
        };

        readonly Label label = new Label
        {
            TextColor = Color.Black,
        };

        public GroupHeaderCell()
        {
            frame.Content = label;
            View = frame;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            var stringGroup = BindingContext as StringGroup;
            label.Text = stringGroup.Title;
        }

    }
}
