using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MelrosePayrollSystem
{
    internal class FormManager
    {
            private List<Form> formList;

            public FormManager()
            {
                formList = new List<Form>();
            }

            public Form LastForm
            {
                // Manages the form list
                get => formList[formList.Count - 1];
                set => formList.Add(value);
            }

            public Form OpenForm(string formName, object arg1 = null)
            {
                Form f = null;

                switch (formName)
                {
                    case ("Menu"):
                        f = new Menu();
                        break;

                    case ("Employee"):
                        f = new Employee();
                        break;

                case ("HR"):
                        f = new HR();
                        break;


                    default:
                        throw new ArgumentException("Cannot create form: " + formName);
                }

                LastForm = f;

                f.FormClosed += FormClosed;

                return f;
            }

            private void FormClosed(object sender, FormClosedEventArgs e)
            {
                // the form is closing so remove from the list
                Form f = (Form)sender;               

                // unsubscribe from the event
                f.FormClosed -= FormClosed;

                formList.Remove(f);
            }
    }
}
