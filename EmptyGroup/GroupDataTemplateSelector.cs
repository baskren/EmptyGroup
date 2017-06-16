using System;
using Xamarin.Forms;
namespace EmptyGroup
{
    public class GroupDataTemplateSelector : DataTemplateSelector
    {
        DataTemplate _deluxHeaderTemplate = new DataTemplate(typeof(DeluxGroupHeaderCell));
        DataTemplate _headerTemplate = new DataTemplate(typeof(GroupHeaderCell));

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return item is DeluxStringGroup ? _deluxHeaderTemplate : _headerTemplate;
        }
    }
}
