using System;
using Xamarin.Forms;

namespace EmptyGroup
{
    public class DeluxGroupHeaderCell : ViewCell
    {
        readonly Frame frame = new Frame
        {
            OutlineColor = Color.Black,
            BackgroundColor = Color.Red,
            Padding = 5,
        };

        readonly Label label = new Label
        {
            TextColor = Color.White,
            BackgroundColor = Color.Blue
        };

        public DeluxGroupHeaderCell()
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
