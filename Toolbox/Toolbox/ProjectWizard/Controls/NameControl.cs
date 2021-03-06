﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Xml;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetOffice.DeveloperToolbox
{
    public partial class NameControl : UserControl, IWizardControl
    {
        XmlDocument _settings;

        public NameControl()
        {
            InitializeComponent();
            CreateSettingsDocument();
            Translate();

            if (ProjectWizardControl.CurrentLanguageID == 1033)
                SetEnglishDefaultName();
            else
                SetGermanDefaultName();

            ChangeSettings();
        }

        private void SetEnglishDefaultName()
        {
          if (!ProjectWizardControl.Singleton.FolderExists("MyAssembly"))
            {
                textBoxClassName.Text = "MyAssembly";
                textBoxDescription.Text = "Assembly Description";
            }
            else
            {
                for (int i = 2; i < 999; i++)
                {
                    string name = "MyAssembly" + i.ToString();
                    if (!ProjectWizardControl.Singleton.FolderExists(name))
                    {
                        textBoxClassName.Text = name;
                        textBoxDescription.Text = "Assembly Description";
                        return;
                    }
                }
            }
        }

        private void SetGermanDefaultName()
        {
            if (!ProjectWizardControl.Singleton.FolderExists("MeinAssembly"))
            {
                textBoxClassName.Text = "MeinAssembly";
                textBoxDescription.Text = "Assembly Beschreibung";
            }
            else
            {
                for (int i = 2; i < 999; i++)
                {
                    string name = "MeinAssembly" + i.ToString();
                    if (!ProjectWizardControl.Singleton.FolderExists(name))
                    {
                        textBoxClassName.Text = name;
                        textBoxDescription.Text = "Assembly Beschreibung";
                        return;
                    }
                }
            }
        }

        public string AssemblyName
        {
            get { return textBoxClassName.Text.Trim(); }
        }

        public string AssemblyDescription
        {
            get { return textBoxDescription.Text; }
        }


        #region IWizardControl Member

        public new void KeyDown(KeyEventArgs e)
        {

        }

        public event ReadyStateChangedHandler ReadyStateChanged;

        public bool IsReadyForNextStep
        {
            get
            {
                try
                {
                    return (("" != textBoxClassName.Text.Trim()) && (!ProjectWizardControl.Singleton.FolderExists(textBoxClassName.Text.Trim())));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("RaiseChangeEvent " + ex.Message);
                    throw (ex);
                }
            }
        }

        public string Caption
        {
            get
            {

                if (ProjectWizardControl.CurrentLanguageID == 1031)
                    return "Tragen Sie Informationen zu Ihrem Assembly ein.";
                else
                    return "Informations about your assembly.";
            }
        }

        public string Description
        {
            get
            {
                if (ProjectWizardControl.CurrentLanguageID == 1031)
                    return "Diese Informationen sind für Anwender sichtbar.";
                else
                    return "These informations are visible for your customers.";
            }
        }

        public ImageType Image
        {
            get
            {
                return ImageType.Question;
            }
        }

        public XmlDocument SettingsDocument
        {
            get
            {
                return _settings;
            }
        }

        public void Translate()
        {
            Translator.TranslateControls(this, "ProjectWizard.Controls.NameControl.txt", ProjectWizardControl.CurrentLanguageID);
        }

        bool FirstActivateFlag = false;

        public void Activate()
        {
            textBoxClassName.Focus();
            if (FirstActivateFlag == false)
            {
                if (ProjectWizardControl.CurrentLanguageID == 1033)
                    SetEnglishDefaultName();
                else
                    SetGermanDefaultName();

                FirstActivateFlag = true;
            }
        }

        public string[] GetSettingsSummary()
        {
            string[] result = new string[2];
            result[0] = "";
            result[1] = "";

            string name = _settings.FirstChild.ChildNodes[0].InnerText;
            string description = _settings.FirstChild.ChildNodes[1].InnerText;

            if (ProjectWizardControl.CurrentLanguageID == 1031)
                result[0] += "Assembly Name:" + Environment.NewLine + "Assembly Beschreibung:";
            else
                result[0] += "Assembly Name:" + Environment.NewLine + "Assembly Description:";

            result[1] += name + Environment.NewLine + description;

            return result;
        }

        #endregion

        #region Methods

        private void RaiseChangeEvent()
        {
            try
            {
                if (null != ReadyStateChanged)
                    ReadyStateChanged(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("RaiseChangeEvent " + ex.Message);
            }
        }

        #endregion

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            ChangeSettings();
            RaiseChangeEvent();
            if (ProjectWizardControl.Singleton.FolderExists(textBoxClassName.Text.Trim()))
                labelHint.Visible = true;
            else
                labelHint.Visible = false;
        }

        private void ChangeSettings()
        {
            foreach (Control item in this.Controls)
            {
                TextBox box = item as TextBox;
                if (null != box)
                {
                    string name = box.Name.Substring("textBox".Length);
                    XmlNode node = _settings.FirstChild.SelectSingleNode(name);
                    if (box.Name == "textBoxClassName")
                        node.InnerText = box.Text.Trim().Replace(" ", "");
                    else
                        node.InnerText = box.Text.Trim();
                }
            }
        }

        private void CreateSettingsDocument()
        {
            _settings = new XmlDocument();
            _settings.AppendChild(_settings.CreateElement("Step2Control"));
            _settings.FirstChild.AppendChild(_settings.CreateElement("ClassName"));
            _settings.FirstChild.AppendChild(_settings.CreateElement("Description"));
        }
    }
}
