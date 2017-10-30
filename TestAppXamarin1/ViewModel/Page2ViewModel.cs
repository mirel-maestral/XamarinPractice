using System;
namespace TestAppXamarin1.ViewModel
{
    public class Page2ViewModel
    {
        public string Name
        {
            get;
            set;
        }

        public string Prompt
        {
            get;
            set;
        }

        public Page2ViewModel()
        {
            this.Name = "Mirel Spahic";
            this.Prompt = "Full Name";
        }
    }
}
