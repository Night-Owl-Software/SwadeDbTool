using SWADELib;

namespace SwadeXmlTool
{
    public partial class MainForm : Form
    {
        private bool attributeEditModeEnabled = false;
        private bool skillEditModeEnabled = false;

        DbController dbController = new DbController();
        private List<SWADEAttribute> allAttributes;
        private List<SWADESkill> allSkills;

        public MainForm()
        {
            InitializeComponent();

            ResetForm();
        }

        private void ResetForm()
        {
            List<SWADEAttribute> unsortedAttributes = new List<SWADEAttribute>(dbController.GetAllAttributes());
            allAttributes = unsortedAttributes.OrderBy(o => o.Name).ToList();

            List<SWADESkill> unsortedSkills = new List<SWADESkill>(dbController.GetAllSkills(allAttributes));
            allSkills = unsortedSkills.OrderBy(o => o.Name).ToList();

            ResetAttributeGroup();
            ResetSkillGroup();
        }

        private void ResetAttributeGroup()
        {
            // Disable Events
            btnAttributeSave.Click -= OnSaveAttributeClick;
            btnEditAttribute.Click -= OnEditAttributeClick;
            txtAttributeName.TextChanged -= OnAttributeTextChanged;

            // Set Default Values
            txtAttributeName.Text = "";
            txtAttributeDesc.Text = "";

            if(listAttributes.DataSource != null)
            {
                listAttributes.DataSource = null;
            }
            if(cboxSkillAttributes.DataSource != null)
            {
                cboxSkillAttributes.DataSource = null;
            }

            listAttributes.DataSource = allAttributes;
            cboxSkillAttributes.DataSource = allAttributes;

            // Enable Events
            btnAttributeSave.Click += OnSaveAttributeClick;
            btnEditAttribute.Click += OnEditAttributeClick;
            txtAttributeName.TextChanged += OnAttributeTextChanged;
        }

        private void ResetSkillGroup()
        {
            //Disable Events
            btnSkillSave.Click -= OnSaveSkillClick;
            btnEditSkill.Click -= OnEditSkillClick;
            txtSkillName.TextChanged -= OnSkillTextChanged;

            // Set Default Values
            if (listSkills.DataSource != null)
            {
                listSkills.DataSource = null;
            }

            listSkills.DataSource = allSkills;

            txtSkillName.Text = "";
            txtSkillDesc.Text = "";
            cboxSkillAttributes.SelectedIndex = 0;
            checkCoreSkill.Checked = false;

            // Enable Events
            btnSkillSave.Click += OnSaveSkillClick;
            btnEditSkill.Click += OnEditSkillClick;
            txtSkillName.TextChanged += OnSkillTextChanged;
        }


        private void OnSaveAttributeClick(object sender, EventArgs e)
        {
            Guid newId = Guid.NewGuid();
            SWADEAttribute attribute = new SWADEAttribute(newId, txtAttributeName.Text.Trim(), txtAttributeDesc.Text.Trim());

            if (attributeEditModeEnabled)
            {
                // Update Existing Attribute

            }
            else
            {
                // Save NEW Attribute
                string attrIdName = attribute.Name.Trim().ToLower();

                dbController.WriteNewAttribute($"{newId}", attribute);
            }

            ResetForm();
        }

        private void OnEditAttributeClick(object sender, EventArgs e)
        {
            if(listAttributes.SelectedItem == null)
            {
                return;
            }

            SWADEAttribute selectedAttribute = listAttributes.SelectedItem as SWADEAttribute;
            txtAttributeName.Text = selectedAttribute.Name;
            txtAttributeDesc.Text = selectedAttribute.Description;
            attributeEditModeEnabled = true;
        }

        private void OnSaveSkillClick(object sender, EventArgs e)
        {

        }

        private void OnEditSkillClick(object sender, EventArgs e)
        {

        }

        private void OnAttributeTextChanged(object sender, EventArgs e)
        {

        }

        private void OnSkillTextChanged(object sender, EventArgs e)
        {

        }
    }
}