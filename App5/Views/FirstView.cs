using ClassLibrary.ViewModels;
using CrossUI.iOS.Dialog.Elements;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Dialog.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace App5.Views
{
    public class FirstView: MvxDialogViewController
    {
        private EntryElement input;
        private StringElement output;

        public FirstView(): base(pushing: false)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Root = new RootElement("Test")
            {
                new Section()
                {
                    (input = new EntryElement("Input")),
                    (output = new StringElement())
                }
            };

            var btn = new UIBarButtonItem(UIBarButtonSystemItem.Edit);
            NavigationItem.RightBarButtonItem = btn;

            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(input).To(vm => vm.Hello);
            set.Bind(output).To(vm => vm.Hello);
            set.Apply();

            btn.Clicked += Btn_Clicked;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            input.Value = "Click";
        }
    }
}
