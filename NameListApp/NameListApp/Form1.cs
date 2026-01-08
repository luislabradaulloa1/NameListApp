namespace NameListApp
{
    public partial class Form1 : Form
    {
        List<string> listNames = new List<string>();

        string[] gender = { "male", "female" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboGender.Items.AddRange(gender);
            comboGender.SelectedIndex = 0;

            lbxNames.DataSource = listNames;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            string genderInput = comboGender.SelectedItem.ToString();

            if (!string.IsNullOrEmpty(name))
            {
                listNames.Add($"{name}:{genderInput}");
                UpdateGUI();
            }
        }

        void UpdateGUI()
        {
            lbxNames.DataSource = null;
            lbxNames.DataSource = listNames;
        }

        private void RadioGenders_CheckedChanged(object sender, EventArgs e)
        {
            List<string> tempNames = new List<string>();

            if (radioMale.Checked)
            {
                GetGender("male", tempNames);
            }
            else if (radioFemale.Checked)
            {
                GetGender("female", tempNames);
            }
            else
            {
                UpdateGUI();
            }
        }

        void GetGender(string gender, List<string> list)
        {
            if (listNames.Count > 0)
            {
                for (int i = 0; i < listNames.Count; i++)
                {
                    string[] splitName = listNames[i].Split(':');
                    if (splitName[1] == $"{gender}")
                    {
                        list.Add(listNames[i]);
                    }
                }
            }

            lbxNames.DataSource = null;
            lbxNames.DataSource = list;
        }
    }
}
