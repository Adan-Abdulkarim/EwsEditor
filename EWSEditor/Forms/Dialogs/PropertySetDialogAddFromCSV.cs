﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using EWSEditor.Common.Exports;
using Microsoft.Exchange.WebServices.Data;

namespace EWSEditor.Forms
{
    public partial class PropertySetDialogAddFromCSV : Form
    {
        public bool ClickedOK = false;
        public List<ExtendedPropertyDefinition> EPD = null;
        public List<AdditionalPropertyDefinition> APD = null;
 

        public PropertySetDialogAddFromCSV()
        {
            InitializeComponent();
        }

        private void PropertySetDialogAddFromCSV_Load(object sender, EventArgs e)
        {
            string StartFolder = Application.StartupPath + "";
            this.txtIncludeUsersAdditionalPropertiesFile.Text = StartFolder + "\\AdditionalPropertiesExamples\\";
        }

        private void LoadLvHeaders(ref ListView oListView)
        {
            oListView.Clear();
            oListView.View = View.Details;
            oListView.GridLines = true;
            //oListView.Dock = DockStyle.Fill;
            ColumnHeader c = null;

            oListView.Columns.Add("DescPropertyName", 200, HorizontalAlignment.Left);
            oListView.Columns.Add("ProbablePropertyName", 200, HorizontalAlignment.Left);
            oListView.Columns.Add("PropertySetId", 200, HorizontalAlignment.Left);
            c = oListView.Columns.Add("PropertyId", 70, HorizontalAlignment.Left);
            c.TextAlign = HorizontalAlignment.Right;
            c = null;
            oListView.Columns.Add("PropertyType", 70, HorizontalAlignment.Left);

            oListView.Tag = -1;

        }

        private void LoadPropeties(string sCsv, ref ListView lvCsvParsed)
        {
            List<AdditionalPropertyDefinition> oAPD = null;
            List<ExtendedPropertyDefinition> oEPD = null;

            APD = null;
            EPD = null;
          
            //lvCsvParsed.Items.Clear();
          
            LoadLvHeaders(ref lvCsvParsed);

            string sChosenFile = string.Empty;
            ListViewItem oListViewItem = null;

            sChosenFile = txtIncludeUsersAdditionalPropertiesFile.Text;
            int iCount = 0;
            if (AdditionalProperties.GetAdditionalPropertiesDefinitionsFromString(this.txtCsv.Text, ref oAPD))
            {  
                foreach (AdditionalPropertyDefinition o in oAPD)
                {
                    oListViewItem = new ListViewItem();
                    oListViewItem.Text = o.DescPropertyName;
                    oListViewItem.SubItems.Add(o.PropertyName);
                    oListViewItem.SubItems.Add(o.PropertySetId);  // GUID
               
                    string sVal = "0x" + o.PropertyId.ToString("X");

                    oListViewItem.SubItems.Add(sVal);

                    oListViewItem.SubItems.Add(o.PropertyType);

                    lvCsvParsed.Items.Add(oListViewItem);
                    iCount++;
                }

                APD = oAPD;
                EPD = oEPD;
            }
        }

 

        private string ChooseFilePath(string sFullPath)
        {
            //string sFolderPath = string.Empty;
            string sNewFullPath = string.Empty;

            System.Windows.Forms.OpenFileDialog oFD = new System.Windows.Forms.OpenFileDialog();

            sNewFullPath = sFullPath;

            oFD.InitialDirectory = Path.GetDirectoryName(sFullPath);
            oFD.FileName = sFullPath;

            oFD.CheckPathExists = true;
            oFD.DefaultExt = "csv";
            oFD.Filter = "CSV files (*.csv)|*.csv";
            oFD.FilterIndex = 1;
            oFD.Title = "Open item as csv";

            if (oFD.ShowDialog() == DialogResult.OK)
            {
                sNewFullPath = oFD.FileName;

            }
            return sNewFullPath;
        }

        private void btnPickFolderIncludeUsersAdditionalProperties_Click(object sender, EventArgs e)
        {
             this.txtIncludeUsersAdditionalPropertiesFile.Text = ChooseFilePath(this.txtIncludeUsersAdditionalPropertiesFile.Text);
             string sFile =  this.txtIncludeUsersAdditionalPropertiesFile.Text.Trim();
         
             if (System.IO.File.Exists(sFile))
             {
                txtCsv.Text =  File.ReadAllText(sFile);
             }
             else
             {
                 MessageBox.Show("File does not exist.", "File selection Error");
             }
        }

        private void btnLoadFromCsv_Click(object sender, EventArgs e)
        {
            LoadPropeties(txtCsv.Text, ref lvCsv);
             

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (APD != null)
            { 
                ClickedOK = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to import CSV based Property Definitions in order to use them.");

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClickedOK = false;
            this.Close();
        }
    }
}
