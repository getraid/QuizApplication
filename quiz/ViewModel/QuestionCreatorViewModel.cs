using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz.ViewModel
{
    /// <summary>
    /// ViewModel-class for the QuestionCreator. It ties all QuestionCreator.xaml with the logic together. 
    /// </summary>
    public class QuestionCreatorViewModel : INotifyPropertyChanged
    {
        #region properties
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
        #region constructor

        //singleton pattern doesn't work && shouldn't be used at mvvm

        public QuestionCreatorViewModel()
        {

        }


        #endregion
        #region methods

        private void Init()
        {

        }


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion
    }
}
