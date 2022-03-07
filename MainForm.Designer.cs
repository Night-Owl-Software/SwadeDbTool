namespace SwadeXmlTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listAttributes = new System.Windows.Forms.ListBox();
            this.listSkills = new System.Windows.Forms.ListBox();
            this.grpAttribute = new System.Windows.Forms.GroupBox();
            this.txtAttributeDesc = new System.Windows.Forms.RichTextBox();
            this.btnAttributeSave = new System.Windows.Forms.Button();
            this.txtAttributeName = new System.Windows.Forms.TextBox();
            this.lblAttributeDesc = new System.Windows.Forms.Label();
            this.lblAttributeName = new System.Windows.Forms.Label();
            this.grpSkill = new System.Windows.Forms.GroupBox();
            this.txtSkillDesc = new System.Windows.Forms.RichTextBox();
            this.checkCoreSkill = new System.Windows.Forms.CheckBox();
            this.cboxSkillAttributes = new System.Windows.Forms.ComboBox();
            this.lblSkillAttribute = new System.Windows.Forms.Label();
            this.btnSkillSave = new System.Windows.Forms.Button();
            this.txtSkillName = new System.Windows.Forms.TextBox();
            this.lblSkillDesc = new System.Windows.Forms.Label();
            this.lblSkillName = new System.Windows.Forms.Label();
            this.grpXml = new System.Windows.Forms.GroupBox();
            this.lblLoadedXML = new System.Windows.Forms.Label();
            this.btnNewXml = new System.Windows.Forms.Button();
            this.btnLoadFromXML = new System.Windows.Forms.Button();
            this.btnSaveToXML = new System.Windows.Forms.Button();
            this.lblAllAttributes = new System.Windows.Forms.Label();
            this.lblAllSkills = new System.Windows.Forms.Label();
            this.btnEditSkill = new System.Windows.Forms.Button();
            this.btnEditAttribute = new System.Windows.Forms.Button();
            this.grpAttribute.SuspendLayout();
            this.grpSkill.SuspendLayout();
            this.grpXml.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAttributes
            // 
            this.listAttributes.FormattingEnabled = true;
            this.listAttributes.ItemHeight = 15;
            this.listAttributes.Location = new System.Drawing.Point(294, 38);
            this.listAttributes.Name = "listAttributes";
            this.listAttributes.Size = new System.Drawing.Size(172, 94);
            this.listAttributes.TabIndex = 0;
            // 
            // listSkills
            // 
            this.listSkills.FormattingEnabled = true;
            this.listSkills.ItemHeight = 15;
            this.listSkills.Location = new System.Drawing.Point(294, 221);
            this.listSkills.Name = "listSkills";
            this.listSkills.Size = new System.Drawing.Size(172, 184);
            this.listSkills.TabIndex = 1;
            // 
            // grpAttribute
            // 
            this.grpAttribute.Controls.Add(this.txtAttributeDesc);
            this.grpAttribute.Controls.Add(this.btnAttributeSave);
            this.grpAttribute.Controls.Add(this.txtAttributeName);
            this.grpAttribute.Controls.Add(this.lblAttributeDesc);
            this.grpAttribute.Controls.Add(this.lblAttributeName);
            this.grpAttribute.Location = new System.Drawing.Point(12, 12);
            this.grpAttribute.Name = "grpAttribute";
            this.grpAttribute.Size = new System.Drawing.Size(249, 178);
            this.grpAttribute.TabIndex = 2;
            this.grpAttribute.TabStop = false;
            this.grpAttribute.Text = "Attribute";
            // 
            // txtAttributeDesc
            // 
            this.txtAttributeDesc.Location = new System.Drawing.Point(82, 55);
            this.txtAttributeDesc.Name = "txtAttributeDesc";
            this.txtAttributeDesc.Size = new System.Drawing.Size(148, 79);
            this.txtAttributeDesc.TabIndex = 1;
            this.txtAttributeDesc.Text = "";
            // 
            // btnAttributeSave
            // 
            this.btnAttributeSave.Location = new System.Drawing.Point(155, 140);
            this.btnAttributeSave.Name = "btnAttributeSave";
            this.btnAttributeSave.Size = new System.Drawing.Size(75, 23);
            this.btnAttributeSave.TabIndex = 2;
            this.btnAttributeSave.Text = "Save";
            this.btnAttributeSave.UseVisualStyleBackColor = true;
            // 
            // txtAttributeName
            // 
            this.txtAttributeName.Location = new System.Drawing.Point(54, 26);
            this.txtAttributeName.Name = "txtAttributeName";
            this.txtAttributeName.Size = new System.Drawing.Size(176, 23);
            this.txtAttributeName.TabIndex = 0;
            // 
            // lblAttributeDesc
            // 
            this.lblAttributeDesc.AutoSize = true;
            this.lblAttributeDesc.Location = new System.Drawing.Point(6, 58);
            this.lblAttributeDesc.Name = "lblAttributeDesc";
            this.lblAttributeDesc.Size = new System.Drawing.Size(70, 15);
            this.lblAttributeDesc.TabIndex = 1;
            this.lblAttributeDesc.Text = "Description:";
            // 
            // lblAttributeName
            // 
            this.lblAttributeName.AutoSize = true;
            this.lblAttributeName.Location = new System.Drawing.Point(6, 29);
            this.lblAttributeName.Name = "lblAttributeName";
            this.lblAttributeName.Size = new System.Drawing.Size(42, 15);
            this.lblAttributeName.TabIndex = 0;
            this.lblAttributeName.Text = "Name:";
            // 
            // grpSkill
            // 
            this.grpSkill.Controls.Add(this.txtSkillDesc);
            this.grpSkill.Controls.Add(this.checkCoreSkill);
            this.grpSkill.Controls.Add(this.cboxSkillAttributes);
            this.grpSkill.Controls.Add(this.lblSkillAttribute);
            this.grpSkill.Controls.Add(this.btnSkillSave);
            this.grpSkill.Controls.Add(this.txtSkillName);
            this.grpSkill.Controls.Add(this.lblSkillDesc);
            this.grpSkill.Controls.Add(this.lblSkillName);
            this.grpSkill.Location = new System.Drawing.Point(12, 196);
            this.grpSkill.Name = "grpSkill";
            this.grpSkill.Size = new System.Drawing.Size(249, 238);
            this.grpSkill.TabIndex = 3;
            this.grpSkill.TabStop = false;
            this.grpSkill.Text = "Skill";
            // 
            // txtSkillDesc
            // 
            this.txtSkillDesc.Location = new System.Drawing.Point(82, 84);
            this.txtSkillDesc.Name = "txtSkillDesc";
            this.txtSkillDesc.Size = new System.Drawing.Size(148, 115);
            this.txtSkillDesc.TabIndex = 6;
            this.txtSkillDesc.Text = "";
            // 
            // checkCoreSkill
            // 
            this.checkCoreSkill.AutoSize = true;
            this.checkCoreSkill.Location = new System.Drawing.Point(168, 24);
            this.checkCoreSkill.Name = "checkCoreSkill";
            this.checkCoreSkill.Size = new System.Drawing.Size(75, 19);
            this.checkCoreSkill.TabIndex = 4;
            this.checkCoreSkill.Text = "Core Skill";
            this.checkCoreSkill.UseVisualStyleBackColor = true;
            // 
            // cboxSkillAttributes
            // 
            this.cboxSkillAttributes.FormattingEnabled = true;
            this.cboxSkillAttributes.Location = new System.Drawing.Point(69, 51);
            this.cboxSkillAttributes.Name = "cboxSkillAttributes";
            this.cboxSkillAttributes.Size = new System.Drawing.Size(161, 23);
            this.cboxSkillAttributes.TabIndex = 5;
            // 
            // lblSkillAttribute
            // 
            this.lblSkillAttribute.AutoSize = true;
            this.lblSkillAttribute.Location = new System.Drawing.Point(6, 54);
            this.lblSkillAttribute.Name = "lblSkillAttribute";
            this.lblSkillAttribute.Size = new System.Drawing.Size(57, 15);
            this.lblSkillAttribute.TabIndex = 9;
            this.lblSkillAttribute.Text = "Attribute:";
            // 
            // btnSkillSave
            // 
            this.btnSkillSave.Location = new System.Drawing.Point(155, 205);
            this.btnSkillSave.Name = "btnSkillSave";
            this.btnSkillSave.Size = new System.Drawing.Size(75, 23);
            this.btnSkillSave.TabIndex = 7;
            this.btnSkillSave.Text = "Save";
            this.btnSkillSave.UseVisualStyleBackColor = true;
            // 
            // txtSkillName
            // 
            this.txtSkillName.Location = new System.Drawing.Point(54, 22);
            this.txtSkillName.Name = "txtSkillName";
            this.txtSkillName.Size = new System.Drawing.Size(108, 23);
            this.txtSkillName.TabIndex = 3;
            // 
            // lblSkillDesc
            // 
            this.lblSkillDesc.AutoSize = true;
            this.lblSkillDesc.Location = new System.Drawing.Point(6, 87);
            this.lblSkillDesc.Name = "lblSkillDesc";
            this.lblSkillDesc.Size = new System.Drawing.Size(70, 15);
            this.lblSkillDesc.TabIndex = 5;
            this.lblSkillDesc.Text = "Description:";
            // 
            // lblSkillName
            // 
            this.lblSkillName.AutoSize = true;
            this.lblSkillName.Location = new System.Drawing.Point(6, 25);
            this.lblSkillName.Name = "lblSkillName";
            this.lblSkillName.Size = new System.Drawing.Size(42, 15);
            this.lblSkillName.TabIndex = 4;
            this.lblSkillName.Text = "Name:";
            // 
            // grpXml
            // 
            this.grpXml.Controls.Add(this.lblLoadedXML);
            this.grpXml.Controls.Add(this.btnNewXml);
            this.grpXml.Controls.Add(this.btnLoadFromXML);
            this.grpXml.Controls.Add(this.btnSaveToXML);
            this.grpXml.Location = new System.Drawing.Point(12, 459);
            this.grpXml.Name = "grpXml";
            this.grpXml.Size = new System.Drawing.Size(456, 100);
            this.grpXml.TabIndex = 4;
            this.grpXml.TabStop = false;
            this.grpXml.Text = "XML";
            // 
            // lblLoadedXML
            // 
            this.lblLoadedXML.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoadedXML.Location = new System.Drawing.Point(6, 19);
            this.lblLoadedXML.Name = "lblLoadedXML";
            this.lblLoadedXML.Size = new System.Drawing.Size(450, 22);
            this.lblLoadedXML.TabIndex = 3;
            this.lblLoadedXML.Text = "Active XML File:";
            this.lblLoadedXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNewXml
            // 
            this.btnNewXml.Location = new System.Drawing.Point(43, 53);
            this.btnNewXml.Name = "btnNewXml";
            this.btnNewXml.Size = new System.Drawing.Size(85, 23);
            this.btnNewXml.TabIndex = 2;
            this.btnNewXml.Text = "New XML";
            this.btnNewXml.UseVisualStyleBackColor = true;
            // 
            // btnLoadFromXML
            // 
            this.btnLoadFromXML.Location = new System.Drawing.Point(330, 53);
            this.btnLoadFromXML.Name = "btnLoadFromXML";
            this.btnLoadFromXML.Size = new System.Drawing.Size(85, 23);
            this.btnLoadFromXML.TabIndex = 1;
            this.btnLoadFromXML.Text = "Load XML";
            this.btnLoadFromXML.UseVisualStyleBackColor = true;
            // 
            // btnSaveToXML
            // 
            this.btnSaveToXML.Location = new System.Drawing.Point(183, 53);
            this.btnSaveToXML.Name = "btnSaveToXML";
            this.btnSaveToXML.Size = new System.Drawing.Size(85, 23);
            this.btnSaveToXML.TabIndex = 0;
            this.btnSaveToXML.Text = "Save XML";
            this.btnSaveToXML.UseVisualStyleBackColor = true;
            // 
            // lblAllAttributes
            // 
            this.lblAllAttributes.AutoSize = true;
            this.lblAllAttributes.Location = new System.Drawing.Point(294, 20);
            this.lblAllAttributes.Name = "lblAllAttributes";
            this.lblAllAttributes.Size = new System.Drawing.Size(62, 15);
            this.lblAllAttributes.TabIndex = 5;
            this.lblAllAttributes.Text = "Attributes:";
            // 
            // lblAllSkills
            // 
            this.lblAllSkills.AutoSize = true;
            this.lblAllSkills.Location = new System.Drawing.Point(294, 203);
            this.lblAllSkills.Name = "lblAllSkills";
            this.lblAllSkills.Size = new System.Drawing.Size(36, 15);
            this.lblAllSkills.TabIndex = 6;
            this.lblAllSkills.Text = "Skills:";
            // 
            // btnEditSkill
            // 
            this.btnEditSkill.Location = new System.Drawing.Point(391, 411);
            this.btnEditSkill.Name = "btnEditSkill";
            this.btnEditSkill.Size = new System.Drawing.Size(75, 23);
            this.btnEditSkill.TabIndex = 7;
            this.btnEditSkill.Text = "Edit";
            this.btnEditSkill.UseVisualStyleBackColor = true;
            // 
            // btnEditAttribute
            // 
            this.btnEditAttribute.Location = new System.Drawing.Point(391, 138);
            this.btnEditAttribute.Name = "btnEditAttribute";
            this.btnEditAttribute.Size = new System.Drawing.Size(75, 23);
            this.btnEditAttribute.TabIndex = 8;
            this.btnEditAttribute.Text = "Edit";
            this.btnEditAttribute.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 571);
            this.Controls.Add(this.btnEditAttribute);
            this.Controls.Add(this.btnEditSkill);
            this.Controls.Add(this.lblAllSkills);
            this.Controls.Add(this.lblAllAttributes);
            this.Controls.Add(this.grpXml);
            this.Controls.Add(this.grpSkill);
            this.Controls.Add(this.grpAttribute);
            this.Controls.Add(this.listSkills);
            this.Controls.Add(this.listAttributes);
            this.Name = "MainForm";
            this.Text = "SWADE XML Tool";
            this.grpAttribute.ResumeLayout(false);
            this.grpAttribute.PerformLayout();
            this.grpSkill.ResumeLayout(false);
            this.grpSkill.PerformLayout();
            this.grpXml.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listAttributes;
        private ListBox listSkills;
        private GroupBox grpAttribute;
        private GroupBox grpSkill;
        private GroupBox grpXml;
        private Label lblLoadedXML;
        private Button btnNewXml;
        private Button btnLoadFromXML;
        private Button btnSaveToXML;
        private Label lblAttributeName;
        private Button btnAttributeSave;
        private TextBox txtAttributeName;
        private Label lblAttributeDesc;
        private RichTextBox txtSkillDesc;
        private CheckBox checkCoreSkill;
        private ComboBox cboxSkillAttributes;
        private Label lblSkillAttribute;
        private Button btnSkillSave;
        private TextBox txtSkillName;
        private Label lblSkillDesc;
        private Label lblSkillName;
        private RichTextBox txtAttributeDesc;
        private Label lblAllAttributes;
        private Label lblAllSkills;
        private Button btnEditSkill;
        private Button btnEditAttribute;
    }
}