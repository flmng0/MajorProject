using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Galc {
    struct Sketch {
        public string sketchName;
        public string savePath;
    }

    public partial class ProjectSelectForm : Form {
        private Dictionary<string, List<Sketch>> _projects;

        public ProjectSelectForm() {
            InitializeComponent();

            _projects = new Dictionary<string, List<Sketch>>();

            LoadProjects();
        }

        private string GetProjectsDataPath() {
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var galcdata = appdata + @"\galc";

            return galcdata;
        }

        private string GetSketchSavePath() {
            var projectsRootPath = GetProjectsDataPath();
            var projectPath = projectsRootPath + @"\" + ProjectCombo.Text;

            var savePath = projectPath + @"\" + SketchCombo.Text + ".galc";

            return savePath;
        }

        // Load existing projects and sketches.
        private void LoadProjects() {
            var dirProjects = new DirectoryInfo(GetProjectsDataPath());

            try {
                if (!dirProjects.Exists) {
                    dirProjects.Create();
                }

                foreach (var project in dirProjects.EnumerateDirectories()) {
                    ProjectCombo.Items.Add(project.Name);
                    var sketches = new List<Sketch>();

                    foreach (var sketch in project.EnumerateFiles("*.galc")) {
                        sketches.Add(new Sketch {
                            sketchName = sketch.Name.Split('.').First(),
                            savePath = sketch.FullName,
                        });
                    }

                    _projects.Add(project.Name, sketches);
                }
            }
            catch (Exception e) {
                Console.WriteLine("HELLO!" + e.Message);
            }
                           
        }

        private void ProjectCombo_SelectedIndexChanged(object sender, EventArgs e) {
            SketchCombo.Enabled = true;
            SketchCombo.Items.Clear();

            foreach (var sketch in _projects[ProjectCombo.Text]) {
                SketchCombo.Items.Add(sketch.sketchName);
            }

            if (SketchCombo.Items.Count > 0) SketchCombo.SelectedIndex = 0;
        }

        private void ProjectCombo_TextUpdate(object sender, EventArgs e) {
            SketchCombo.Enabled = ProjectCombo.Text.Length > 0;

            if (_projects.ContainsKey(ProjectCombo.Text)) {
                foreach (var sketch in _projects[ProjectCombo.Text]) {
                    SketchCombo.Items.Add(sketch.sketchName);
                }
            }
            else {
                SketchCombo.Items.Clear();
                SketchCombo.Text = "";
            }
        }

        private void OKButton_Click(object sender, EventArgs e) {
            if (!ScratchCheck.Checked) {
                if (ProjectCombo.Text.Length == 0 || SketchCombo.Text.Length == 0) {
                    MessageBox.Show(
                        "Please fill out all form fields.\n\nAlternatively, enable the Scratch Pad option.",
                        "Invalid Project", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );

                    return;
                }

                if (_projects.ContainsKey(ProjectCombo.Text)) {
                    var project = _projects[ProjectCombo.Text];

                    if (SketchCombo.SelectedIndex >= 0) {
                        State.SavePath = project[SketchCombo.SelectedIndex].savePath;
                    }
                    else {
                        var savePath = GetSketchSavePath();
                        State.SavePath = savePath;
                    }
                }
                else {
                    var savePath = GetSketchSavePath();
                    State.SavePath = savePath;
                }
            }

            State.ShouldRun = true;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void ScratchCheck_CheckedChanged(object sender, EventArgs e) {
            if (ScratchCheck.Checked) {
                ProjectCombo.Enabled = false;
                SketchCombo.Enabled = false;
            }
            else {
                ProjectCombo.Enabled = true;
                SketchCombo.Enabled = _projects.Count > 0;
            }
        }
    }
}
