using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


// Id, Name, AttacksLow, AttacksHigh, Power, Element, Class, Target, Effect, MP
namespace SMT4A
{
    public partial class Form1 : Form
    {
        private Random rand = new Random(
            BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0) -
            DateTime.Now.DayOfYear +
            DateTime.Now.Day +
            DateTime.Now.Hour +
            DateTime.Now.Minute +
            DateTime.Now.Second +
            DateTime.Now.Millisecond);


        public Form1()
        {
            InitializeComponent();
            
            SkillCollection.InitializeFromJson();

            lbx_skills.DataSource = SkillCollection.Skills;

            cbx_powerFilter.DataSource = new string[10]
            {
                "UNSPECIFIED_POWER",
                "NO_DAMAGE",
                "WEAK",
                "MEDIUM",
                "HEAVY",
                "SEVERE",
                "MEGA",
                "VARIES",
                "INSTAKILL",
                "UNKNOWN_POWER"
            };

            cbx_elementFilter.DataSource = new string[11]
            {
                "ANY_ELEMENT",
                "NO_ELEMENT",
                "PHYS",
                "GUN",
                "FIRE",
                "ICE",
                "ELEC",
                "FORCE",
                "LIGHT",
                "DARK",
                "ALMIGHTY",
            };

            cbx_classFilter.DataSource = new string[8]
            {
                "ANY_CLASS",
                "NO_CLASS",
                "ATTACK",
                "SUPPORT",
                "UTILITY",
                "STATUS",
                "AILMENT",
                "PASSIVE"
            };

            cbx_targetFilter.DataSource = new string[9]
            {
                "ANY_TARGET",
                "NO_TARGET",
                "SELF",
                "ALLY",
                "ALL_ALLIES",
                "ENEMY",
                "MULTI",
                "ALL_ENEMIES",
                "EVERYONE"
            };

            rb_sortNames.CheckedChanged += b_applyFilters_Click;

            rb_numAttacksExact.CheckedChanged += num_AttacksHigh_Enabled;
            rb_numAttacksRange.CheckedChanged += num_AttacksHigh_Enabled;
            rb_numAttacksMin.CheckedChanged += num_AttacksHigh_Enabled;
            rb_numAttacksMax.CheckedChanged += num_AttacksHigh_Enabled;

            num_attacksHigh.Maximum =
                SkillCollection.Skills.Max(s => s.AttacksHigh);

            rb_mpCostExact.CheckedChanged += num_mpCostHigh_Enabled;
            rb_mpCostRange.CheckedChanged += num_mpCostHigh_Enabled;
            rb_mpCostMax.CheckedChanged += num_mpCostHigh_Enabled;
            rb_mpCostIgnore.CheckedChanged += num_mpCostHigh_Enabled;

            num_mpCostLow.Maximum = num_mpCostHigh.Maximum =
                SkillCollection.Skills.Max(s => s.MP);

            lbx_skills.DisplayMember = "Name";
            lbx_skills.MouseDoubleClick += lbx_skills_DoubleClick;

            lbx_savedSkills.DisplayMember = "Name";
            lbx_savedSkills.MouseDoubleClick += lbx_savedSkills_DoubleClick;

            lb_selectedSkill.Font =
                new System.Drawing.Font("Consolas", 9f);
        }

        private void lbx_skills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_skills.Items.Count == 0) return;
            ShowSelectedSkill((Skill)lbx_skills.SelectedItem);
        }

        private void lbx_savedSkills_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (lbx_savedSkills.Items.Count == 0) return;

            if (lbx_savedSkills.SelectedIndex == -1)
            {
                if (lbx_savedSkills.Items.Count > 0)
                {
                    lbx_savedSkills.SelectedIndex++;
                }
            }

            ShowSelectedSkill((Skill)lbx_savedSkills.SelectedItem);
        }

        private void ShowSelectedSkill(Skill s)
        {
            string eff = s.Effect;
            if (eff.Length > 50)
            {
                for (int i = 40; i < 51; i++)
                {
                    if (char.IsWhiteSpace(eff[i]))
                    {
                        eff = eff.Insert(i, "\n");
                        break;
                    }
                }
            }

            eff = string.IsNullOrEmpty(eff) ? "-" : eff;

            byte[] id_bytes = BitConverter.GetBytes(s.Id).Reverse().ToArray();
            string id = BitConverter.ToString(id_bytes).Replace('-', ' ');

            lb_selectedSkill.Text =
                "Id:           " + id + "\n" +
                "Name:         " + s.Name + "\n" +
                "# of attacks: " + s.AttacksLow + (s.AttacksHigh > 0 ? "-" + s.AttacksHigh : "") + "\n" +
                "Power:        " + s.Power + "\n" +
                "Element:      " + s.Element + "\n" +
                "Class:        " + s.Class + "\n" +
                "Targets:      " + s.Target + "\n" +
                "MP cost:      " + s.MP + "\n\n" +
                eff;
        }

        private void lbx_skills_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbx_skills.IndexFromPoint(
                e.X, e.Y);

            if (index == -1) return;

            lbx_savedSkills.Items.Add(
                (Skill)lbx_skills.Items[index]);
        }

        private void lbx_savedSkills_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbx_savedSkills.IndexFromPoint(
                e.X, e.Y);

            if (index == -1) return;
            
            lbx_savedSkills.Items.RemoveAt(index);
        }

        private void b_applyFilters_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbx_nameFilter.Text))
            {
                lbx_skills.DataSource =
                    SkillCollection.Skills.Where(s => s.Name.Contains(
                        tbx_nameFilter.Text)).ToArray();
                return;
            }

            Skill[] skills = SkillCollection.Skills.ToArray();

            skills = skills.Where(s =>
                rb_numAttacksExact.Checked ? s.AttacksLow == (int)num_attacksLow.Value :
                rb_numAttacksRange.Checked ? s.AttacksLow >= (int)num_attacksLow.Value && 
                    s.AttacksHigh > 0 && 
                    s.AttacksHigh <= (int)num_attacksHigh.Value :
                rb_numAttacksMin.Checked ? s.AttacksLow >= (int)num_attacksLow.Value :
                s.AttacksHigh == (int)num_attacksHigh.Value).ToArray();

            if (cbx_powerFilter.SelectedIndex > 0)
            {
                skills = skills.Where(s =>
                    (int)s.Power == cbx_powerFilter.SelectedIndex).ToArray();
            }

            if (cbx_elementFilter.SelectedIndex > 0)
            {
                skills = skills.Where(s =>
                    (int)s.Element == cbx_elementFilter.SelectedIndex).ToArray();
            }

            if (cbx_classFilter.SelectedIndex > 0)
            {
                skills = skills.Where(s =>
                    (int)s.Class == cbx_classFilter.SelectedIndex).ToArray();
            }

            if (cbx_targetFilter.SelectedIndex > 0)
            {
                skills = skills.Where(s =>
                    (int)s.Target == cbx_targetFilter.SelectedIndex).ToArray();
            }

            if (!rb_mpCostIgnore.Checked)
            {
                skills = skills.Where(s =>
                    rb_mpCostExact.Checked ? s.MP == (int)num_mpCostLow.Value :
                    rb_mpCostRange.Checked ? s.MP >= (int)num_mpCostLow.Value && 
                        s.MP <= (int)num_mpCostHigh.Value :
                    s.MP <= (int)num_mpCostHigh.Value).ToArray();
            }

            if (rb_sortNames.Checked)
            {
                skills = skills.OrderBy(s => s.Name).ToArray();
            }
            else
            {
                skills = skills.OrderBy(s => s.Id).ToArray();
            }

            lbx_skills.DataSource = skills;
        }

        private void b_random_Click(object sender, EventArgs e)
        {
            int id = rand.Next(0, 500) + 1;

            Skill[] arr = new Skill[1] { SkillCollection.Skills[id] };
            lbx_skills.DataSource = arr;
        }

        private void num_AttacksHigh_Enabled(object sender, EventArgs e)
        {
            num_attacksHigh.Enabled = 
                !(rb_numAttacksExact.Checked | 
                rb_numAttacksMin.Checked);

            num_attacksLow.Enabled =
                !rb_numAttacksMax.Checked;
        }

        private void num_mpCostHigh_Enabled(object sender, EventArgs e)
        {
            num_mpCostHigh.Enabled =
                !(rb_mpCostExact.Checked | rb_mpCostIgnore.Checked);

            num_mpCostLow.Enabled =
                !(rb_mpCostMax.Checked | rb_mpCostIgnore.Checked);
        }
    }
}
