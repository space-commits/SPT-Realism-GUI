namespace Realism_Mod_Config_GUI
{
    public class ControlRule
    {
        public List<Control> Targets { get; set; } = new List<Control>();
        public Func<bool> Condition { get; set; } = () => true;    

        public void Evaluate()
        {
            bool result = Condition();
            foreach (Control target in Targets)
            {
                target.Enabled = result;
                if (result == false && target is CheckBox checkBox) 
                {
                    checkBox.Checked = false;  
                }
            }
        }
    }
}
