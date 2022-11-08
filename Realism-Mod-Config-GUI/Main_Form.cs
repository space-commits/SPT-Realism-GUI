using System.Windows.Forms;

namespace Realism_Mod_Config_GUI
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();

            for (int i = 0; i < botHealhCheckList.Items.Count; i++)
            {
                botHealhCheckList.SetItemChecked(i, true);
            }
            for (int i = 0; i < botDifficultyCheckList.Items.Count; i++)
            {
                botDifficultyCheckList.SetItemChecked(i, true);
            }
            for (int i = 0; i < pmcNamesCheckList.Items.Count; i++)
            {
                pmcNamesCheckList.SetItemChecked(i, true);
            }

            botTypeCombo.SelectedItem = "Default";

        }


    }
}