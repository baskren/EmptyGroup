using System;
using Xamarin.Forms;

namespace EmptyGroup
{
    public class StringCell : ViewCell
    {
        readonly Frame frame = new Frame
        {
            Padding = 5,
        };

        readonly Label label = new Label
        {
            TextColor = Color.Black,
        };

        public StringCell()
        {
            frame.Content = label;
            View = frame;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            var text = BindingContext as string;
            label.Text = text;
        }
    }
}
