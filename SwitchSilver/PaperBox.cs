using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SwitchSilver
{
    class PaperBox
    {
        public ComboBox Paper { get; set; }
        public CheckBox Completed { get; set; }
        public RadioButton Pass { get; set; }
        public RadioButton Fail { get; set; }

        public PaperBox(ComboBox paper, CheckBox completed, RadioButton pass, RadioButton fail)
        {
            this.Paper = paper;
            this.Completed = completed;
            this.Pass = pass;
            this.Fail = fail;
        }
    }
}
