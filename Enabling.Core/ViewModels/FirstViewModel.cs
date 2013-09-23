using Cirrious.MvvmCross.ViewModels;

namespace Enabling.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _hello = "Hello MvvmCross";
        public string Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}

        private bool _myBool;
        public bool MyBool 
        {   
            get { return _myBool; }
            set { _myBool = value; RaisePropertyChanged(() => MyBool); }
        }
    }
}
