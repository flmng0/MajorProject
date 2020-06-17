using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Galc {

    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new ProjectSelectForm());

            if (State.MainForm == null) {
                State.MainForm = new MainOutputForm();

                if (State.SavePath != null && File.Exists(State.SavePath)) {
                    State.MainForm.LoadFrom(State.SavePath);
                }
            }

            Application.Run(State.MainForm);
        }
    }

}
