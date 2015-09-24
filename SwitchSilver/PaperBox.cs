using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SwitchSilver
{
    /// <summary>
    /// Holds the Combo Box for paper selection, Check Box for completed status
    /// and Radio Buttons for pass and fail
    /// </summary>
    class PaperBox
    {
        /// <summary>
        /// The Combo Box in which the paper is selected
        /// </summary>
        public ComboBox Paper { get; set; }

        /// <summary>
        /// The Check Box for whether the paper has been completed
        /// </summary>
        public CheckBox Completed { get; set; }

        /// <summary>
        /// The Radio Button for whether the paper has been passed
        /// </summary>
        public RadioButton Pass { get; set; }

        /// <summary>
        /// The Radio Button for whether the paper has been failed
        /// </summary>
        public RadioButton Fail { get; set; }

        /// <summary>
        /// Creates a new Paper Box Item from the given combo box, checkbox and radio buttons
        /// </summary>
        /// <param name="paper"></param>
        /// <param name="completed"></param>
        /// <param name="pass"></param>
        /// <param name="fail"></param>
        public PaperBox(ComboBox paper, CheckBox completed, RadioButton pass, RadioButton fail)
        {
            this.Paper = paper;
            this.Completed = completed;
            this.Pass = pass;
            this.Fail = fail;
        }
    }
}
