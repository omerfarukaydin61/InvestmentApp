using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestmentApp.Entities
{
    public static class ConfigForm 
    {
        private static Form _currentForm;
        private static Form _previousForm;
        private static Form _nextForm;
        public static Form CurrentForm
        {
            get
            {
                return _currentForm;
            }
            set
            {
                if (!OpenedForms.Any(x => x.Text == value.Text))
                    OpenedForms.Add(value);
                PreviousForm = _currentForm;
                _currentForm = value;
            }
        }
        public static Form PreviousForm
        {
            get
            {
                return _previousForm;
            }
            set
            {
                _nextForm = _currentForm;
                _currentForm = _previousForm;
                _previousForm = value;
            }
        }
        public static List<Form> OpenedForms = new List<Form>();
        public static int MaxIdOfOpenedForm()
        {
            int max = -1;
            foreach (Form f in OpenedForms)
            {
                if (Convert.ToInt32(f.Tag) > max)
                    max = Convert.ToInt32(f.Tag);
            }
            return max;
        }
        public static void RemoveSpecificForm(Form form)
        {
            for (int i = 0; i < OpenedForms.Count; i++)
            {
                if ((OpenedForms[i] as Form).Tag == form.Tag)
                {
                    OpenedForms.Remove(form);
                    return;
                }
            }
        }
        public static void CloseAllOpenedForms()
        {
            _currentForm?.Close();
            _currentForm = null;

            _previousForm?.Close();
            _previousForm = null;

            _nextForm?.Close();
            _nextForm = null;

            for (int i = 0; i < OpenedForms.Count; i++)
            {
                OpenedForms.Remove(OpenedForms[i]);
            }
        }
        public static void GoBackPreviousForm()
        {
            PreviousForm?.BringToFront();
            for (int i = 0; i < OpenedForms.Count; i++)
            {
                var form = OpenedForms[i];
                if (form.Text == PreviousForm?.Text)
                {
                    if (i - 1 >= 0)
                        PreviousForm = OpenedForms[i - 1];
                    return;
                }
            }
        }
        public static void GoToNextForm()
        {
            _nextForm?.BringToFront();
            for (int i = 0; i < OpenedForms.Count; i++)
            {
                var form = OpenedForms[i];
                if (form.Text == _nextForm?.Text)
                {
                    if (i < OpenedForms.Count - 1)
                        _nextForm = OpenedForms[i + 1];
                    return;
                }
            }
        }
    }
}