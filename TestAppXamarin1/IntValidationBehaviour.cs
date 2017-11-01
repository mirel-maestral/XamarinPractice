using System;
using Xamarin.Forms;

namespace TestAppXamarin1
{
    public class IntValidationBehaviour: Behavior<Entry>
    {
        public IntValidationBehaviour()
        {
        }

        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            bool isValid = int.TryParse(e.NewTextValue, out int result);
            Entry entry = sender as Entry;
            entry.TextColor = isValid ? Color.Default : Color.Red;
        }
    }
}
