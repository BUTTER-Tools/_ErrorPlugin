using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using PluginContracts;
using OutputHelperLib;


namespace ErrorPlugin
{
    public class ErrorPlugin : Plugin
    {


        public string[] InputType { get; } = { "Error-NoType" };
        public string OutputType { get; } = "Error-NoType";

        public Dictionary<int, string> OutputHeaderData { get; set; } = null;
        public bool InheritHeader { get; } = false;

        #region Plugin Details and Info

        public string PluginName { get; } = "Error";
        public string PluginType { get; } = "Error";
        public string PluginVersion { get; } = "X.X.X";
        public string PluginAuthor { get; } = "Ryan L. Boyd (ryan@ryanboyd.io)";
        public string PluginDescription { get; } = "If you see this plugin in your analysis pipeline, that means that something went horribly, horribly wrong. Probably while loading from a saved analysis pipeline. Please remain calm." + Environment.NewLine + Environment.NewLine +
                                                    "“The Answer to the Great Question... Of Life, the Universe and Everything... Is... Forty-two,' said Deep Thought, with infinite majesty and calm.”" + Environment.NewLine + 
                                                    "― Douglas Adams, The Hitchhiker's Guide to the Galaxy";
        public bool TopLevel { get; } = false;
        public string PluginTutorial { get; } = "None";


        public Icon GetPluginIcon
        {
            get
            {
                return Properties.Resources.icon;
            }
        }

        #endregion



        public void ChangeSettings()
        {

            MessageBox.Show("This plugin does not have any settings to change. This *is* an error, after all.",
                    "No Settings", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

        }





        public Payload RunPlugin(Payload Input)
        {



            Payload pData = new Payload();
            pData.FileID = Input.FileID;
            pData.SegmentID = Input.SegmentID;


            for (int i = 0; i < Input.StringList.Count; i++)
            {

            }

            return (pData);

        }



        public void Initialize() { }

        public bool InspectSettings()
        {
            return true;
        }

        public Payload FinishUp(Payload Input)
        {
            return (Input);
        }



        #region Import/Export Settings
        public void ImportSettings(Dictionary<string, string> SettingsDict)
        {

        }

        public Dictionary<string, string> ExportSettings(bool suppressWarnings)
        {
            Dictionary<string, string> SettingsDict = new Dictionary<string, string>();
            return (SettingsDict);
        }
        #endregion

    }
}
