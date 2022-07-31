using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FromEntry : ContentView
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(FromEntry), default(string), Xamarin.Forms.BindingMode.OneWay);
        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }

            set
            {
                SetValue(TitleProperty, value);
            }
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(FromEntry), default(string), BindingMode.TwoWay);
        public string Text
        {
            get
            {
                return (string)GetValue(TextProperty);
            }

            set
            {
                SetValue(TextProperty, value);
            }
        }

        public FromEntry()
        {
            InitializeComponent();

            title.Text = Title;
            entry.Text = Text;
            entry.TextChanged += OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Text = e.NewTextValue;
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == TitleProperty.PropertyName)
            {
                title.Text = Title;
            }
            else if (propertyName == TextProperty.PropertyName)
            {
                entry.Text = Text;
            }
        }
    }
}