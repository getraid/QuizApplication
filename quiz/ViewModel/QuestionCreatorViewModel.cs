using quiz.Command;
using quiz.Model;
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
        private QuizViewModel QVW { get; set; }
        private List<Frage> FragenList { get; set; }
        private QuizManager QuizManager { get; set; }

        #endregion
        #region constructor

       

        public QuestionCreatorViewModel()
        {
            //all the other classes register
            CommandNewQuestionWindow.NotifyVMReady += new CommandNewQuestionWindow.TransferViewModel(Init);
        }


        #endregion
        #region methods

        private void Init(QuizViewModel sender)
        {
            if (QVW == null)
            {
                QVW = sender;
            }
            QuizManager = QVW.QuizManager;
            FragenList = QVW.FragenList;

            QuizManager.AddFragen(QVW.FragenList, "", "Wie Mongo", "", "", "", "", 1);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion
    }
}
