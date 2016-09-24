namespace SMT4A
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbx_skills = new System.Windows.Forms.ListBox();
            this.lbx_savedSkills = new System.Windows.Forms.ListBox();
            this.lb_savedSkills = new System.Windows.Forms.Label();
            this.gbx_skillFiltering = new System.Windows.Forms.GroupBox();
            this.b_random = new System.Windows.Forms.Button();
            this.b_applyFilters = new System.Windows.Forms.Button();
            this.gbx_mpCost = new System.Windows.Forms.GroupBox();
            this.rb_mpCostIgnore = new System.Windows.Forms.RadioButton();
            this.num_mpCostHigh = new System.Windows.Forms.NumericUpDown();
            this.lb_mpCostTo = new System.Windows.Forms.Label();
            this.num_mpCostLow = new System.Windows.Forms.NumericUpDown();
            this.rb_mpCostMax = new System.Windows.Forms.RadioButton();
            this.rb_mpCostRange = new System.Windows.Forms.RadioButton();
            this.rb_mpCostExact = new System.Windows.Forms.RadioButton();
            this.Lb_mpCost = new System.Windows.Forms.Label();
            this.cbx_targetFilter = new System.Windows.Forms.ComboBox();
            this.lb_targets = new System.Windows.Forms.Label();
            this.cbx_classFilter = new System.Windows.Forms.ComboBox();
            this.lb_class = new System.Windows.Forms.Label();
            this.cbx_elementFilter = new System.Windows.Forms.ComboBox();
            this.lb_element = new System.Windows.Forms.Label();
            this.lb_power = new System.Windows.Forms.Label();
            this.cbx_powerFilter = new System.Windows.Forms.ComboBox();
            this.gbx_numAttacks = new System.Windows.Forms.GroupBox();
            this.lb_numAttacksTo = new System.Windows.Forms.Label();
            this.num_attacksHigh = new System.Windows.Forms.NumericUpDown();
            this.rb_numAttacksMax = new System.Windows.Forms.RadioButton();
            this.rb_numAttacksMin = new System.Windows.Forms.RadioButton();
            this.num_attacksLow = new System.Windows.Forms.NumericUpDown();
            this.rb_numAttacksRange = new System.Windows.Forms.RadioButton();
            this.rb_numAttacksExact = new System.Windows.Forms.RadioButton();
            this.lb_numAttacks = new System.Windows.Forms.Label();
            this.tbx_nameFilter = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.gbx_selectedSkill = new System.Windows.Forms.GroupBox();
            this.lb_selectedSkill = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_sortNames = new System.Windows.Forms.RadioButton();
            this.rb_sortIds = new System.Windows.Forms.RadioButton();
            this.gbx_skillFiltering.SuspendLayout();
            this.gbx_mpCost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_mpCostHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_mpCostLow)).BeginInit();
            this.gbx_numAttacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_attacksHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_attacksLow)).BeginInit();
            this.gbx_selectedSkill.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbx_skills
            // 
            this.lbx_skills.FormattingEnabled = true;
            this.lbx_skills.Location = new System.Drawing.Point(12, 65);
            this.lbx_skills.Name = "lbx_skills";
            this.lbx_skills.Size = new System.Drawing.Size(122, 342);
            this.lbx_skills.TabIndex = 0;
            this.lbx_skills.SelectedIndexChanged += new System.EventHandler(this.lbx_skills_SelectedIndexChanged);
            // 
            // lbx_savedSkills
            // 
            this.lbx_savedSkills.FormattingEnabled = true;
            this.lbx_savedSkills.Location = new System.Drawing.Point(13, 440);
            this.lbx_savedSkills.Name = "lbx_savedSkills";
            this.lbx_savedSkills.Size = new System.Drawing.Size(121, 147);
            this.lbx_savedSkills.TabIndex = 1;
            this.lbx_savedSkills.SelectedIndexChanged += new System.EventHandler(this.lbx_savedSkills_SelectedIndexChanged);
            // 
            // lb_savedSkills
            // 
            this.lb_savedSkills.AutoSize = true;
            this.lb_savedSkills.Location = new System.Drawing.Point(12, 424);
            this.lb_savedSkills.Name = "lb_savedSkills";
            this.lb_savedSkills.Size = new System.Drawing.Size(65, 13);
            this.lb_savedSkills.TabIndex = 2;
            this.lb_savedSkills.Text = "Saved Skills";
            // 
            // gbx_skillFiltering
            // 
            this.gbx_skillFiltering.Controls.Add(this.b_random);
            this.gbx_skillFiltering.Controls.Add(this.b_applyFilters);
            this.gbx_skillFiltering.Controls.Add(this.gbx_mpCost);
            this.gbx_skillFiltering.Controls.Add(this.Lb_mpCost);
            this.gbx_skillFiltering.Controls.Add(this.cbx_targetFilter);
            this.gbx_skillFiltering.Controls.Add(this.lb_targets);
            this.gbx_skillFiltering.Controls.Add(this.cbx_classFilter);
            this.gbx_skillFiltering.Controls.Add(this.lb_class);
            this.gbx_skillFiltering.Controls.Add(this.cbx_elementFilter);
            this.gbx_skillFiltering.Controls.Add(this.lb_element);
            this.gbx_skillFiltering.Controls.Add(this.lb_power);
            this.gbx_skillFiltering.Controls.Add(this.cbx_powerFilter);
            this.gbx_skillFiltering.Controls.Add(this.gbx_numAttacks);
            this.gbx_skillFiltering.Controls.Add(this.lb_numAttacks);
            this.gbx_skillFiltering.Controls.Add(this.tbx_nameFilter);
            this.gbx_skillFiltering.Controls.Add(this.lb_name);
            this.gbx_skillFiltering.Location = new System.Drawing.Point(140, 13);
            this.gbx_skillFiltering.Name = "gbx_skillFiltering";
            this.gbx_skillFiltering.Size = new System.Drawing.Size(472, 342);
            this.gbx_skillFiltering.TabIndex = 3;
            this.gbx_skillFiltering.TabStop = false;
            this.gbx_skillFiltering.Text = "Skill List Filtering";
            // 
            // b_random
            // 
            this.b_random.Location = new System.Drawing.Point(122, 313);
            this.b_random.Name = "b_random";
            this.b_random.Size = new System.Drawing.Size(109, 23);
            this.b_random.TabIndex = 17;
            this.b_random.Text = "Random";
            this.b_random.UseVisualStyleBackColor = true;
            this.b_random.Click += new System.EventHandler(this.b_random_Click);
            // 
            // b_applyFilters
            // 
            this.b_applyFilters.Location = new System.Drawing.Point(6, 313);
            this.b_applyFilters.Name = "b_applyFilters";
            this.b_applyFilters.Size = new System.Drawing.Size(109, 23);
            this.b_applyFilters.TabIndex = 16;
            this.b_applyFilters.Text = "Apply Filters";
            this.b_applyFilters.UseVisualStyleBackColor = true;
            this.b_applyFilters.Click += new System.EventHandler(this.b_applyFilters_Click);
            // 
            // gbx_mpCost
            // 
            this.gbx_mpCost.Controls.Add(this.rb_mpCostIgnore);
            this.gbx_mpCost.Controls.Add(this.num_mpCostHigh);
            this.gbx_mpCost.Controls.Add(this.lb_mpCostTo);
            this.gbx_mpCost.Controls.Add(this.num_mpCostLow);
            this.gbx_mpCost.Controls.Add(this.rb_mpCostMax);
            this.gbx_mpCost.Controls.Add(this.rb_mpCostRange);
            this.gbx_mpCost.Controls.Add(this.rb_mpCostExact);
            this.gbx_mpCost.Location = new System.Drawing.Point(100, 230);
            this.gbx_mpCost.Name = "gbx_mpCost";
            this.gbx_mpCost.Size = new System.Drawing.Size(314, 60);
            this.gbx_mpCost.TabIndex = 15;
            this.gbx_mpCost.TabStop = false;
            this.gbx_mpCost.Text = "rules";
            // 
            // rb_mpCostIgnore
            // 
            this.rb_mpCostIgnore.AutoSize = true;
            this.rb_mpCostIgnore.Checked = true;
            this.rb_mpCostIgnore.Location = new System.Drawing.Point(92, 37);
            this.rb_mpCostIgnore.Name = "rb_mpCostIgnore";
            this.rb_mpCostIgnore.Size = new System.Drawing.Size(77, 17);
            this.rb_mpCostIgnore.TabIndex = 6;
            this.rb_mpCostIgnore.TabStop = true;
            this.rb_mpCostIgnore.Text = "ignore cost";
            this.rb_mpCostIgnore.UseVisualStyleBackColor = true;
            // 
            // num_mpCostHigh
            // 
            this.num_mpCostHigh.Enabled = false;
            this.num_mpCostHigh.Location = new System.Drawing.Point(257, 19);
            this.num_mpCostHigh.Name = "num_mpCostHigh";
            this.num_mpCostHigh.Size = new System.Drawing.Size(48, 20);
            this.num_mpCostHigh.TabIndex = 5;
            // 
            // lb_mpCostTo
            // 
            this.lb_mpCostTo.AutoSize = true;
            this.lb_mpCostTo.Location = new System.Drawing.Point(235, 21);
            this.lb_mpCostTo.Name = "lb_mpCostTo";
            this.lb_mpCostTo.Size = new System.Drawing.Size(16, 13);
            this.lb_mpCostTo.TabIndex = 4;
            this.lb_mpCostTo.Text = "to";
            // 
            // num_mpCostLow
            // 
            this.num_mpCostLow.Location = new System.Drawing.Point(181, 19);
            this.num_mpCostLow.Name = "num_mpCostLow";
            this.num_mpCostLow.Size = new System.Drawing.Size(48, 20);
            this.num_mpCostLow.TabIndex = 3;
            // 
            // rb_mpCostMax
            // 
            this.rb_mpCostMax.AutoSize = true;
            this.rb_mpCostMax.Location = new System.Drawing.Point(92, 19);
            this.rb_mpCostMax.Name = "rb_mpCostMax";
            this.rb_mpCostMax.Size = new System.Drawing.Size(84, 17);
            this.rb_mpCostMax.TabIndex = 2;
            this.rb_mpCostMax.Text = "less or equal";
            this.rb_mpCostMax.UseVisualStyleBackColor = true;
            // 
            // rb_mpCostRange
            // 
            this.rb_mpCostRange.AutoSize = true;
            this.rb_mpCostRange.Location = new System.Drawing.Point(6, 38);
            this.rb_mpCostRange.Name = "rb_mpCostRange";
            this.rb_mpCostRange.Size = new System.Drawing.Size(52, 17);
            this.rb_mpCostRange.TabIndex = 1;
            this.rb_mpCostRange.Text = "range";
            this.rb_mpCostRange.UseVisualStyleBackColor = true;
            // 
            // rb_mpCostExact
            // 
            this.rb_mpCostExact.AutoSize = true;
            this.rb_mpCostExact.Location = new System.Drawing.Point(6, 19);
            this.rb_mpCostExact.Name = "rb_mpCostExact";
            this.rb_mpCostExact.Size = new System.Drawing.Size(58, 17);
            this.rb_mpCostExact.TabIndex = 0;
            this.rb_mpCostExact.Text = "exactly";
            this.rb_mpCostExact.UseVisualStyleBackColor = true;
            // 
            // Lb_mpCost
            // 
            this.Lb_mpCost.AutoSize = true;
            this.Lb_mpCost.Location = new System.Drawing.Point(6, 230);
            this.Lb_mpCost.Name = "Lb_mpCost";
            this.Lb_mpCost.Size = new System.Drawing.Size(46, 13);
            this.Lb_mpCost.TabIndex = 14;
            this.Lb_mpCost.Text = "MP cost";
            // 
            // cbx_targetFilter
            // 
            this.cbx_targetFilter.FormattingEnabled = true;
            this.cbx_targetFilter.Location = new System.Drawing.Point(100, 202);
            this.cbx_targetFilter.Name = "cbx_targetFilter";
            this.cbx_targetFilter.Size = new System.Drawing.Size(120, 21);
            this.cbx_targetFilter.TabIndex = 13;
            // 
            // lb_targets
            // 
            this.lb_targets.AutoSize = true;
            this.lb_targets.Location = new System.Drawing.Point(6, 205);
            this.lb_targets.Name = "lb_targets";
            this.lb_targets.Size = new System.Drawing.Size(43, 13);
            this.lb_targets.TabIndex = 12;
            this.lb_targets.Text = "Targets";
            // 
            // cbx_classFilter
            // 
            this.cbx_classFilter.FormattingEnabled = true;
            this.cbx_classFilter.Location = new System.Drawing.Point(100, 174);
            this.cbx_classFilter.Name = "cbx_classFilter";
            this.cbx_classFilter.Size = new System.Drawing.Size(120, 21);
            this.cbx_classFilter.TabIndex = 11;
            // 
            // lb_class
            // 
            this.lb_class.AutoSize = true;
            this.lb_class.Location = new System.Drawing.Point(6, 177);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(32, 13);
            this.lb_class.TabIndex = 10;
            this.lb_class.Text = "Class";
            // 
            // cbx_elementFilter
            // 
            this.cbx_elementFilter.FormattingEnabled = true;
            this.cbx_elementFilter.Location = new System.Drawing.Point(100, 147);
            this.cbx_elementFilter.Name = "cbx_elementFilter";
            this.cbx_elementFilter.Size = new System.Drawing.Size(120, 21);
            this.cbx_elementFilter.TabIndex = 9;
            // 
            // lb_element
            // 
            this.lb_element.AutoSize = true;
            this.lb_element.Location = new System.Drawing.Point(6, 150);
            this.lb_element.Name = "lb_element";
            this.lb_element.Size = new System.Drawing.Size(45, 13);
            this.lb_element.TabIndex = 8;
            this.lb_element.Text = "Element";
            // 
            // lb_power
            // 
            this.lb_power.AutoSize = true;
            this.lb_power.Location = new System.Drawing.Point(6, 123);
            this.lb_power.Name = "lb_power";
            this.lb_power.Size = new System.Drawing.Size(37, 13);
            this.lb_power.TabIndex = 7;
            this.lb_power.Text = "Power";
            // 
            // cbx_powerFilter
            // 
            this.cbx_powerFilter.FormattingEnabled = true;
            this.cbx_powerFilter.Location = new System.Drawing.Point(100, 120);
            this.cbx_powerFilter.Name = "cbx_powerFilter";
            this.cbx_powerFilter.Size = new System.Drawing.Size(120, 21);
            this.cbx_powerFilter.TabIndex = 6;
            // 
            // gbx_numAttacks
            // 
            this.gbx_numAttacks.Controls.Add(this.lb_numAttacksTo);
            this.gbx_numAttacks.Controls.Add(this.num_attacksHigh);
            this.gbx_numAttacks.Controls.Add(this.rb_numAttacksMax);
            this.gbx_numAttacks.Controls.Add(this.rb_numAttacksMin);
            this.gbx_numAttacks.Controls.Add(this.num_attacksLow);
            this.gbx_numAttacks.Controls.Add(this.rb_numAttacksRange);
            this.gbx_numAttacks.Controls.Add(this.rb_numAttacksExact);
            this.gbx_numAttacks.Location = new System.Drawing.Point(100, 54);
            this.gbx_numAttacks.Name = "gbx_numAttacks";
            this.gbx_numAttacks.Size = new System.Drawing.Size(314, 60);
            this.gbx_numAttacks.TabIndex = 5;
            this.gbx_numAttacks.TabStop = false;
            this.gbx_numAttacks.Text = "rules";
            // 
            // lb_numAttacksTo
            // 
            this.lb_numAttacksTo.AutoSize = true;
            this.lb_numAttacksTo.Location = new System.Drawing.Point(235, 21);
            this.lb_numAttacksTo.Name = "lb_numAttacksTo";
            this.lb_numAttacksTo.Size = new System.Drawing.Size(16, 13);
            this.lb_numAttacksTo.TabIndex = 7;
            this.lb_numAttacksTo.Text = "to";
            // 
            // num_attacksHigh
            // 
            this.num_attacksHigh.Enabled = false;
            this.num_attacksHigh.Location = new System.Drawing.Point(257, 19);
            this.num_attacksHigh.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_attacksHigh.Name = "num_attacksHigh";
            this.num_attacksHigh.Size = new System.Drawing.Size(48, 20);
            this.num_attacksHigh.TabIndex = 8;
            this.num_attacksHigh.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // rb_numAttacksMax
            // 
            this.rb_numAttacksMax.AutoSize = true;
            this.rb_numAttacksMax.Location = new System.Drawing.Point(92, 38);
            this.rb_numAttacksMax.Name = "rb_numAttacksMax";
            this.rb_numAttacksMax.Size = new System.Drawing.Size(49, 17);
            this.rb_numAttacksMax.TabIndex = 3;
            this.rb_numAttacksMax.Text = "up to";
            this.rb_numAttacksMax.UseVisualStyleBackColor = true;
            // 
            // rb_numAttacksMin
            // 
            this.rb_numAttacksMin.AutoSize = true;
            this.rb_numAttacksMin.Location = new System.Drawing.Point(92, 19);
            this.rb_numAttacksMin.Name = "rb_numAttacksMin";
            this.rb_numAttacksMin.Size = new System.Drawing.Size(59, 17);
            this.rb_numAttacksMin.TabIndex = 2;
            this.rb_numAttacksMin.Text = "at least";
            this.rb_numAttacksMin.UseVisualStyleBackColor = true;
            // 
            // num_attacksLow
            // 
            this.num_attacksLow.Location = new System.Drawing.Point(181, 19);
            this.num_attacksLow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_attacksLow.Name = "num_attacksLow";
            this.num_attacksLow.Size = new System.Drawing.Size(48, 20);
            this.num_attacksLow.TabIndex = 6;
            this.num_attacksLow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rb_numAttacksRange
            // 
            this.rb_numAttacksRange.AutoSize = true;
            this.rb_numAttacksRange.Location = new System.Drawing.Point(6, 38);
            this.rb_numAttacksRange.Name = "rb_numAttacksRange";
            this.rb_numAttacksRange.Size = new System.Drawing.Size(52, 17);
            this.rb_numAttacksRange.TabIndex = 1;
            this.rb_numAttacksRange.Text = "range";
            this.rb_numAttacksRange.UseVisualStyleBackColor = true;
            // 
            // rb_numAttacksExact
            // 
            this.rb_numAttacksExact.AutoSize = true;
            this.rb_numAttacksExact.Checked = true;
            this.rb_numAttacksExact.Location = new System.Drawing.Point(6, 19);
            this.rb_numAttacksExact.Name = "rb_numAttacksExact";
            this.rb_numAttacksExact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_numAttacksExact.Size = new System.Drawing.Size(58, 17);
            this.rb_numAttacksExact.TabIndex = 0;
            this.rb_numAttacksExact.TabStop = true;
            this.rb_numAttacksExact.Text = "exactly";
            this.rb_numAttacksExact.UseVisualStyleBackColor = true;
            // 
            // lb_numAttacks
            // 
            this.lb_numAttacks.AutoSize = true;
            this.lb_numAttacks.Location = new System.Drawing.Point(6, 54);
            this.lb_numAttacks.Name = "lb_numAttacks";
            this.lb_numAttacks.Size = new System.Drawing.Size(64, 13);
            this.lb_numAttacks.TabIndex = 4;
            this.lb_numAttacks.Text = "# of attacks";
            // 
            // tbx_nameFilter
            // 
            this.tbx_nameFilter.Location = new System.Drawing.Point(100, 28);
            this.tbx_nameFilter.Name = "tbx_nameFilter";
            this.tbx_nameFilter.Size = new System.Drawing.Size(120, 20);
            this.tbx_nameFilter.TabIndex = 3;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(6, 31);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(35, 13);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Name";
            // 
            // gbx_selectedSkill
            // 
            this.gbx_selectedSkill.Controls.Add(this.lb_selectedSkill);
            this.gbx_selectedSkill.Location = new System.Drawing.Point(140, 369);
            this.gbx_selectedSkill.Name = "gbx_selectedSkill";
            this.gbx_selectedSkill.Size = new System.Drawing.Size(472, 221);
            this.gbx_selectedSkill.TabIndex = 4;
            this.gbx_selectedSkill.TabStop = false;
            this.gbx_selectedSkill.Text = "Selected Skill - Properties";
            // 
            // lb_selectedSkill
            // 
            this.lb_selectedSkill.AutoSize = true;
            this.lb_selectedSkill.Location = new System.Drawing.Point(21, 39);
            this.lb_selectedSkill.Name = "lb_selectedSkill";
            this.lb_selectedSkill.Size = new System.Drawing.Size(67, 13);
            this.lb_selectedSkill.TabIndex = 0;
            this.lb_selectedSkill.Text = "selected skill";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_sortIds);
            this.groupBox1.Controls.Add(this.rb_sortNames);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 46);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "sort by";
            // 
            // rb_sortNames
            // 
            this.rb_sortNames.AutoSize = true;
            this.rb_sortNames.Checked = true;
            this.rb_sortNames.Location = new System.Drawing.Point(6, 19);
            this.rb_sortNames.Name = "rb_sortNames";
            this.rb_sortNames.Size = new System.Drawing.Size(51, 17);
            this.rb_sortNames.TabIndex = 0;
            this.rb_sortNames.TabStop = true;
            this.rb_sortNames.Text = "name";
            this.rb_sortNames.UseVisualStyleBackColor = true;
            // 
            // rb_sortIds
            // 
            this.rb_sortIds.AutoSize = true;
            this.rb_sortIds.Location = new System.Drawing.Point(63, 19);
            this.rb_sortIds.Name = "rb_sortIds";
            this.rb_sortIds.Size = new System.Drawing.Size(33, 17);
            this.rb_sortIds.TabIndex = 1;
            this.rb_sortIds.TabStop = true;
            this.rb_sortIds.Text = "id";
            this.rb_sortIds.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_selectedSkill);
            this.Controls.Add(this.gbx_skillFiltering);
            this.Controls.Add(this.lb_savedSkills);
            this.Controls.Add(this.lbx_savedSkills);
            this.Controls.Add(this.lbx_skills);
            this.Name = "Form1";
            this.Text = "SMT4A Skill Search";
            this.gbx_skillFiltering.ResumeLayout(false);
            this.gbx_skillFiltering.PerformLayout();
            this.gbx_mpCost.ResumeLayout(false);
            this.gbx_mpCost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_mpCostHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_mpCostLow)).EndInit();
            this.gbx_numAttacks.ResumeLayout(false);
            this.gbx_numAttacks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_attacksHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_attacksLow)).EndInit();
            this.gbx_selectedSkill.ResumeLayout(false);
            this.gbx_selectedSkill.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_skills;
        private System.Windows.Forms.ListBox lbx_savedSkills;
        private System.Windows.Forms.Label lb_savedSkills;
        private System.Windows.Forms.GroupBox gbx_skillFiltering;
        private System.Windows.Forms.GroupBox gbx_selectedSkill;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tbx_nameFilter;
        private System.Windows.Forms.GroupBox gbx_numAttacks;
        private System.Windows.Forms.Label lb_numAttacks;
        private System.Windows.Forms.RadioButton rb_numAttacksMax;
        private System.Windows.Forms.RadioButton rb_numAttacksMin;
        private System.Windows.Forms.RadioButton rb_numAttacksRange;
        private System.Windows.Forms.RadioButton rb_numAttacksExact;
        private System.Windows.Forms.NumericUpDown num_attacksHigh;
        private System.Windows.Forms.Label lb_numAttacksTo;
        private System.Windows.Forms.NumericUpDown num_attacksLow;
        private System.Windows.Forms.Label lb_power;
        private System.Windows.Forms.ComboBox cbx_powerFilter;
        private System.Windows.Forms.ComboBox cbx_elementFilter;
        private System.Windows.Forms.Label lb_element;
        private System.Windows.Forms.ComboBox cbx_classFilter;
        private System.Windows.Forms.Label lb_class;
        private System.Windows.Forms.ComboBox cbx_targetFilter;
        private System.Windows.Forms.Label lb_targets;
        private System.Windows.Forms.Label Lb_mpCost;
        private System.Windows.Forms.GroupBox gbx_mpCost;
        private System.Windows.Forms.NumericUpDown num_mpCostLow;
        private System.Windows.Forms.RadioButton rb_mpCostMax;
        private System.Windows.Forms.RadioButton rb_mpCostRange;
        private System.Windows.Forms.RadioButton rb_mpCostExact;
        private System.Windows.Forms.Label lb_mpCostTo;
        private System.Windows.Forms.NumericUpDown num_mpCostHigh;
        private System.Windows.Forms.Button b_applyFilters;
        private System.Windows.Forms.Button b_random;
        private System.Windows.Forms.Label lb_selectedSkill;
        private System.Windows.Forms.RadioButton rb_mpCostIgnore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_sortIds;
        private System.Windows.Forms.RadioButton rb_sortNames;
    }
}

