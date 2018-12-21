using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Replacer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxDrop_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effect = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var parent = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                FileInfo inf = new FileInfo(parent);
                if (Directory.Exists(parent))
                    effect = DragDropEffects.Copy;
            }

            e.Effect = effect;
        }

        private void textBoxDrop_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var counter = 0;
                var parent = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                var files = Directory.GetFiles(parent);
                textBoxDrop.Text = "";
                progressBar.Value = 0;
                progressBar.Minimum = 0;
                progressBar.Maximum = files.Length - 1;
                for (var i = 0; i < files.Length; i++)
                {
                    counter++;
                    progressBar.PerformStep();
                    labelProgressBar.Text = "Processing " + (i + 1) + " of " + (files.Length) + " files";
                    labelProgressBar.Refresh();
                    string path = files[i];
                    FileInfo inf = new FileInfo(path);
                    var filename = inf.Name;
                    string ext = inf.Extension.ToLower();
                    if (ext == ".vb")
                    {
                        textBoxDrop.AppendText("Processing " + filename + Environment.NewLine);
                        textBoxDrop.Refresh();
                        processFile(path);
                    }
                    if (i == files.Length - 1)
                    {
                        textBoxDrop.AppendText(counter + " files modified" + Environment.NewLine);
                        textBoxDrop.AppendText("Process done!" + Environment.NewLine);
                        textBoxDrop.Refresh();
                        Console.WriteLine("Process done!");
                    }
                }
            }
        }

        private void processFile(string path)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool changed = false;

            if (textBoxOutputDir.Text == "")
            {
                textBoxOutputDir.Text = Directory.GetParent(path).ToString();
                textBoxOutputDir.Refresh();
            }
            if (textBoxOldText.Text == "")
            {
                textBoxOldText.Text = "init.AppendFormat(\"Me.{0}.Size = New System.Drawing.Size({1}, {2})\", name, settings.Width / 2, settings.LabelHeight)";
                textBoxOldText.Refresh();
            }
            if (textBoxNewText.Text == "")
            {
                textBoxNewText.Text = "init.AppendFormat(\"Me.{0}.Size = New System.Drawing.Size({1}, {2})\", name, 100, settings.LabelHeight)";
                textBoxNewText.Refresh();
            }

            //use StreamReader to read line by line
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)//while not eof
                {
                    //checks if line reached the Subs because not all files have Declarations or Components #Region
                    if (line.Contains(textBoxOldText.Text))
                    {
                        if (changed == false)
                            changed = true;
                        textBoxDrop.AppendText(line + " replaced " + Environment.NewLine);
                        textBoxDrop.Refresh();

                        line = line.Replace(textBoxOldText.Text, textBoxNewText.Text);
                        stringBuilder.AppendLine(line);
                    }
                    else
                        stringBuilder.AppendLine(line);
                }
            }

            if(changed == true)
                File.WriteAllText(path, stringBuilder.ToString());

        }
    }
}
