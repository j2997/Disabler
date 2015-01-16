//Created by Jeffrey Pearson
//Copyright 2015
//Last modified on January 7, 2015
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Disabler.Properties;

namespace Disabler
{
    public partial class Form1 : Form
    {
        readonly FolderBrowserDialog folderFinderOne = new FolderBrowserDialog();

        //Declare variables
        bool fileSelected = false;
        string[] fileNames;
        string[] disableNames;

        private readonly string dirPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                          "\\Mod Manager";
        readonly string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Mod Manager\\settings.txt";
        string fPathHold = "C:\\";
        bool firstRun = true;

        public Form1()
        {
            InitializeComponent();
            if (File.Exists(filePath))
            {
                try
                {
                    using (FileStream reader = File.OpenRead(filePath))
                    {
                        Byte[] get = new byte[1024];
                        UTF8Encoding encode = new UTF8Encoding(true);
                        reader.Read(get, 0, get.Length);
                            fPathHold = encode.GetString(get);
                            fPathHold = (encode.GetString(get));
                        reader.Close();
                        
                        fileSelected = true;
                    }
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("Error reading file on initialization");
                }
                fPathHold = fPathHold.Trim('\0');
                filePathTxtBox.Text = fPathHold;
                //Console.WriteLine("[ERROR] TextBox Contains: " + filePathTxtBox.Text);
                filePathTxtBox.DeselectAll();
                //this.AcceptButton = browseButton;
                filePathTxtBox.Select();
                if(Directory.Exists(filePathTxtBox.Text))
                GetPaths();
                    
            }
            else
            {
                if(!Directory.Exists(dirPath))
                    Directory.CreateDirectory(dirPath);
                if (!File.Exists(filePath))
                    File.Create(filePath);
            }
        }

        private void disableButton_Click(object sender, EventArgs e)
        {
            //Check if there are selected indices in the enabled list
            if (enableList.SelectedIndices.Count > 0)
            {
                //If there are:
                //For each Selected File:
                lastDisabledList.Items.Clear();
                for (int i = 0; i < enableList.SelectedIndices.Count; i++)
                {
                    //Move the file
                    File.Move(filePathTxtBox.Text + "\\" + enableList.Items[enableList.SelectedIndices[i]], filePathTxtBox.Text + "\\" + enableList.Items[enableList.SelectedIndices[i]] + ".d");
                    //Add the filename to the Last Disabled List
                    lastDisabledList.Items.Add(enableList.Items[enableList.SelectedIndices[i]]);
                    //Check if the filename is in the Last Enabled List
                    //If so, remove it
                    lastEnabledList.Items.Remove(enableList.Items[enableList.SelectedIndices[i]]);
                }
            }
            //If not, check in the lastEnabled List
            else if (lastEnabledList.SelectedIndices.Count > 0)
            {
                //If there are:
                //For each selected file:
                lastDisabledList.Items.Clear();
                int store = lastEnabledList.SelectedIndices.Count;
                string[,] files = new string[2,store];
                for (int j = 0; j < lastEnabledList.SelectedIndices.Count; j++)
                {
                    //Move the file
                    //File.Move(filePathTxtBox.Text + "\\" + lastEnabledList.Items[lastEnabledList.SelectedIndices[j]], filePathTxtBox.Text + "\\" + lastEnabledList.Items[lastEnabledList.SelectedIndices[j]] + ".d");
                    files[0, j] = filePathTxtBox.Text + "\\" + lastEnabledList.Items[lastEnabledList.SelectedIndices[j]];
                    files[1, j] = filePathTxtBox.Text + "\\" + lastEnabledList.Items[lastEnabledList.SelectedIndices[j]] +
                                  ".d";
                    //Add the filename to the Last Disabled List
                    lastDisabledList.Items.Add(lastEnabledList.Items[lastEnabledList.SelectedIndices[j]]);
                    //Check if the filename is in the Last Enabled List
                    //If so, remove it
                }
                int count = 0;
                while (lastEnabledList.SelectedIndices.Count > 0)
                {
                    count = lastEnabledList.SelectedIndices.Count - 1;
                    File.Move(files[0, count], files[1, count]);
                    lastEnabledList.Items.Remove(lastEnabledList.Items[lastEnabledList.SelectedIndices[count]]);
                }
            }
            //Else do nothing

            //Refresh Enabled and Disabled Boxes
            GetPaths();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (folderFinderOne.ShowDialog() == DialogResult.OK)
            {
                filePathTxtBox.Text = folderFinderOne.SelectedPath;
                GetPaths();
                save();
            }
        }

        private void enableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastEnabledList.ClearSelected();
            lastDisabledList.ClearSelected();
            disableList.ClearSelected();
        }

        private void GetPaths()
        {
                enableList.Items.Clear();
                disableList.Items.Clear();
            try
            {
                fileSelected = true;
                fileNames = Directory.GetFiles(filePathTxtBox.Text, "*.jar");
                disableNames = Directory.GetFiles(filePathTxtBox.Text, "*.d");


                int count = 0;
                foreach (string path in fileNames)
                {
                    fileNames[count] = Path.GetFileName(fileNames[count]);
                    enableList.Items.Add(fileNames[count]);
                    count++;
                }
                count = 0;
                foreach (string path in disableNames)
                {
                    disableNames[count] = Path.GetFileNameWithoutExtension(disableNames[count]);
                    disableList.Items.Add(disableNames[count]);
                    count++;
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show(Resources.FileError);
                filePathTxtBox.Text = "";
            }
            refreshTracking();

        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            //Check if there are selected indices in the disabled list
            if (disableList.SelectedIndices.Count > 0)
            {
                //If there are:
                //For each selected file:
                lastEnabledList.Items.Clear();
                for (int i = 0; i < disableList.SelectedIndices.Count; i++)
                {
                    //Move the File
                    File.Move(filePathTxtBox.Text + "\\" + disableList.Items[disableList.SelectedIndices[i]] + ".d", filePathTxtBox.Text + "\\" + Path.GetFileName(disableList.Items[disableList.SelectedIndices[i]].ToString()));
                    //Add the filename to the last enabled list
                    lastEnabledList.Items.Add(disableList.Items[disableList.SelectedIndices[i]]);
                    //Check if the filename is in the last disabled list
                    //If so, Remove it
                    lastDisabledList.Items.Remove(disableList.Items[disableList.SelectedIndices[i]]);
                }
            }

            //If there are no selected indices in the disabled list
            //Check if there are selected indices in the lastDisabledList
            else if (lastDisabledList.SelectedIndices.Count > 0)
            {
                //If there are:
                //For each selected file:
                lastEnabledList.Items.Clear();
                int store = lastDisabledList.SelectedIndices.Count;
                string[,] files = new string[2, store];
                for (int j = 0; j < store; j++)
                {
                    //Move the File
                    //File.Move(filePathTxtBox.Text + "\\" + lastDisabledList.Items[lastDisabledList.SelectedIndices[j]] + ".d", filePathTxtBox.Text + "\\" + Path.GetFileName(lastDisabledList.Items[lastDisabledList.SelectedIndices[j]].ToString()));
                    //Create a string for the from file path
                    files[0, j] = filePathTxtBox.Text + "\\" + lastDisabledList.Items[lastDisabledList.SelectedIndices[j]] + ".d";
                    //Create a string for the to file path
                    files[1, j] = filePathTxtBox.Text + "\\" +
                                  Path.GetFileName(
                                      lastDisabledList.Items[lastDisabledList.SelectedIndices[j]].ToString());
                    //Add the filename to the last enabled list
                    lastEnabledList.Items.Add(lastDisabledList.Items[lastDisabledList.SelectedIndices[j]]);
                    //Check if the filename is in the last disabled list
                    //If so, Remove it
                    
                }
                int count = 0;
                while (lastDisabledList.SelectedIndices.Count > 0)
                {
                    count = lastDisabledList.SelectedIndices.Count - 1;
                    File.Move(files[0, count], files[1, count]);
                    lastDisabledList.Items.Remove(lastDisabledList.Items[lastDisabledList.SelectedIndices[count]]);
                }
                
            }

            //Else do nothing

            //Refresh the Enabled and Disabled Boxes
            GetPaths();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Enable All
        private void enAll_Click(object sender, EventArgs e)
        {
            if (fileSelected)
            {
                foreach (string path in disableNames)
                {
                    File.Move(filePathTxtBox.Text + "\\" + path, filePathTxtBox.Text + "\\" + Path.GetFileNameWithoutExtension(path) + ".jar");
                }
                GetPaths();
            }
        }

        //Disable All
        private void disAll_Click(object sender, EventArgs e)
        {
            if (fileSelected)
            {
                foreach (string path in fileNames)
                {
                    File.Move(filePathTxtBox.Text + "\\" + path, filePathTxtBox.Text + "\\" + Path.GetFileNameWithoutExtension(path) + ".d");
                }
                GetPaths();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //The Refresh Button
            GetPaths();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void disableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastDisabledList.ClearSelected();
            lastEnabledList.ClearSelected();
            enableList.ClearSelected();
        }

        private void lastEnabledList_Click(object sender, EventArgs e)
        {

        }

        private void lastDisabledLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void lastDisabledList_SelectedIndexChanged(object sender, EventArgs e)
        {
            disableList.ClearSelected();
            enableList.ClearSelected();
            lastEnabledList.ClearSelected();
        }

        private void lastEnabledList_SelectedIndexChanged(object sender, EventArgs e)
        {
            enableList.ClearSelected();
            disableList.ClearSelected();
            lastDisabledList.ClearSelected();
        }

        private void enSelectAll_Click(object sender, EventArgs e)
        {
            int size = enableList.Items.Count;
            for (int i = 0; i < size; i++)
            {
                enableList.SetSelected(i, true);
            }
        }

        private void enDeselectAll_Click(object sender, EventArgs e)
        {
            int size = enableList.Items.Count;
            for (int i = 0; i < size; i++)
            {
                enableList.SetSelected(i, false);
            }
        }

        private void diSelectAll_Click(object sender, EventArgs e)
        {
            int size = disableList.Items.Count;
            for (int i = 0; i < size; i++)
            {
                disableList.SetSelected(i, true);
            }
        }

        private void diDeselectAll_Click(object sender, EventArgs e)
        {
            int size = disableList.Items.Count;
            for (int i = 0; i < size; i++)
            {
                disableList.SetSelected(i, false);
            }
        }

        private void clearEDListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastEnabledList.Items.Clear();
            lastDisabledList.Items.Clear();
            GetPaths();
        }

        private void refreshViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetPaths();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disabler\nVersion 2.1\n© 2015 Jeffrey Pearson");
        }

        private void filePathTxtBox_Enter(object sender, EventArgs e)
        {

        }

        private void filePathTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                GetPaths();
                lastEnabledList.Items.Clear();
                lastDisabledList.Items.Clear();
                if (enableList.Items.Count > 0)
                {
                    enableList.Select();
                }
                save();
            }
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            save();
        }

        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GetPaths();
        }

        private void save()
        {
            Byte[] toWrite = new UTF8Encoding(true).GetBytes(filePathTxtBox.Text);
            using (StreamWriter file = new StreamWriter(filePath, false))
            {
                file.Write(filePathTxtBox.Text);
                file.Close();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetPaths();
            lastEnabledList.Items.Clear();
            lastDisabledList.Items.Clear();
        }

        private void delete(ListBox data, bool disabled)
        {
            int count = data.SelectedIndices.Count;
            if(count > 0)
            {
                string pathStore = null;
                for(int i = 0; i < count; i++)
                {
                    if (disabled == true)
                        pathStore = filePathTxtBox.Text + '\\' + data.SelectedItems[i] + ".d";
                    else
                        pathStore = filePathTxtBox.Text + '\\' + data.SelectedItems[i];

                    //Console.WriteLine("Deleting file in" + pathStore);
                    try
                    {
                        File.Delete(pathStore);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.ToString());
                    }
                }
                GetPaths();
            }
        }

        //If the delete key is pressed
        private void enableList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult confirm = MessageBox.Show("Confirm delete of file?", "Delete", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    delete(enableList, false);
                    GetPaths();
                }
            }
        }

        private void disableList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult confirm = MessageBox.Show("Confirm delete of file?", "Delete", MessageBoxButtons.OKCancel);
                if (confirm == DialogResult.OK)
                {
                    delete(disableList, true);
                    GetPaths();
                }
            }
        }

        private void refreshTracking()
        {

            for (int i = lastDisabledList.Items.Count - 1; 0 < i; i--)
            {
                if (!(File.Exists(filePathTxtBox.Text + '\\' + lastDisabledList.Items[i] + ".d"))) //|| (File.Exists(filePathTxtBox.Text + '\\' + lastDisabledList.Items[i] + ".d"))))
                {
                    lastDisabledList.Items.RemoveAt(i);
                }
            }
            for (int i = lastEnabledList.Items.Count - 1; 0 < i; i--)
            {
                if (!(File.Exists(filePathTxtBox.Text + '\\' + lastEnabledList.Items[i]))) //|| (File.Exists(filePathTxtBox.Text + '\\' + lastEnabledList.Items[i] + ".d"))))
                {
                    lastEnabledList.Items.RemoveAt(i);
                }
            }
        }

        //Clean this function up, get rid of repeated code, and make it work at all
        //Get a keypress when things are seleced using the select all buttons
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /*
            if(e.KeyCode == Keys.Delete)
                if (lastEnabledList.SelectedIndices.Count > 0)
                {
                    DialogResult confirm = MessageBox.Show("Confirm delete of file?", "Delete", MessageBoxButtons.OKCancel);
                    if (confirm == DialogResult.OK)
                    {
                        delete(enableList, false);
                        GetPaths();
                    }
                }
                else if (lastDisabledList.SelectedIndices.Count < 0)
                {
                    DialogResult confirm = MessageBox.Show("Confirm delete of file?", "Delete", MessageBoxButtons.OKCancel);
                    if (confirm == DialogResult.OK)
                    {
                        delete(disableList, false);
                        GetPaths();
                    }
                }*/
        }
    }
}
