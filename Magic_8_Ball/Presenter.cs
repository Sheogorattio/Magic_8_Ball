using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_8_Ball
{
    internal class Presenter
    {
        IModel _model;
        IView _view;

        public Presenter(IModel model, IView view)
        {
            _model = model;
            _view = view;
            _view.GotQuestion += new EventHandler<EventArgs>(GenerateAnswer);
        }

        private void GenerateAnswer(object sender, EventArgs e) 
        {
            _model.GenerateAnswer();
            UpdateView();
        }

        private void UpdateView()
        {
            _view.Answer = _model.Answer;
        }
        
    }
}
