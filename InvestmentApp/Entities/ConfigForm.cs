using InvestmentApp.Entities.Enums;
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
        public static BGYForm _currentForm { get; set; }
        public static BGYForm CurrentForm
        {
            get
            {
                return _currentForm;
            }
            set
            {
                if (!OpenedForms.Any(x => x.PageType == value.PageType))
                {
                    if (value.PageType == Pages.UserOperations)
                    {
                        for (int i = OpenedForms.Count - 1; i > 0; i--)
                        {
                            var xxx = OpenedForms[i];
                            if (!(OpenedForms[i]?.PageType == Pages.UserOperations || OpenedForms[i]?.PageType == Pages.Home))
                            {
                                RemoveSpecificForm(OpenedForms[i]);
                            }
                        }
                    }
                    if (value.PageType == Pages.Invest)
                    {
                        for (int i = OpenedForms.Count - 1; i > 0 ; i--)
                        {
                            var xxx = OpenedForms[i];
                            if (OpenedForms[i]?.PageType != Pages.Invest || OpenedForms[i]?.PageType != Pages.Home)
                            {
                                RemoveSpecificForm(OpenedForms[i]);
                            }
                        }
                    }
                    OpenedForms.Add(value);
                }
                PageIds.Add(value.PageType);
                _currentForm = value;
            }
        }
        private static List<Pages> PageIds = new List<Pages>();
        public static List<BGYForm> OpenedForms = new List<BGYForm>();
        public static void RemoveSpecificForm(BGYForm form)
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
            for (int i = 0; i < OpenedForms.Count; i++)
            {
                OpenedForms[i].Close();
                OpenedForms.Remove(OpenedForms[i]);
            }
        }
        public static void GoBackPreviousForm()
        {
            if (CurrentForm == null || CurrentForm.PageType == Pages.Login)
                return;

            int index = -1;
            for (int i = 0; i < OpenedForms.Count; i++)
            {
                if (OpenedForms[i].Text == CurrentForm.Text)
                {
                    index = i - 1;
                }
            }
            if (index != -1)
            {
                CurrentForm = OpenedForms[index];
                CurrentForm.BringToFront();
            }
        }
        public static void GoToNextForm()
        {
            if (CurrentForm == null || CurrentForm.PageType == Pages.Login)
                return;

            int index = -1;
            for (int i = 0; i < OpenedForms.Count; i++)
            {
                if (OpenedForms[i].Text == CurrentForm.Text)
                {
                    index = i + 1;
                }
            }
            if (index <= OpenedForms.Count - 1)
            {
                CurrentForm = OpenedForms[index];
                CurrentForm.BringToFront();
            }
        }
    }
}