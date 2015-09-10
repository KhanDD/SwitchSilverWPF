using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SwitchSilver
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        List<ComboBox> YearOneSemesterOne;
        List<ComboBox> YearOneSemesterTwo;
        List<ComboBox> YearTwoSemesterOne;
        List<ComboBox> YearTwoSemesterTwo;
        List<ComboBox> YearThreeSemesterOne;
        List<ComboBox> YearThreeSemesterTwo;

        List<CheckBox> YearOneSemesterOneCompleted;
        List<CheckBox> YearOneSemesterTwoCompleted;
        List<CheckBox> YearTwoSemesterOneCompleted;
        List<CheckBox> YearTwoSemesterTwoCompleted;
        List<CheckBox> YearThreeSemesterOneCompleted;
        List<CheckBox> YearThreeSemesterTwoCompleted;

        List<RadioButton> YearOneSemesterOnePassed;
        List<RadioButton> YearOneSemesterTwoPassed;
        List<RadioButton> YearTwoSemesterOnePassed;
        List<RadioButton> YearTwoSemesterTwoPassed;
        List<RadioButton> YearThreeSemesterOnePassed;
        List<RadioButton> YearThreeSemesterTwoPassed;
        public Page1()
        {


            //study4DataSet data = this.FindResource("study4DataSet") as study4DataSet;
            /*foreach (var x in this.Resources)
            {
                tbx.Text += x.ToString() + "\n";
            }*/

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var details = new Details((((Hyperlink)sender).DataContext) as SwitchSilver.study4DataSet.PapersRow);
            this.NavigationService.Navigate(details);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Papers
            YearOneSemesterOne = new List<ComboBox>();
            YearOneSemesterOne.Add(cbx1);
            YearOneSemesterOne.Add(cbx2);
            YearOneSemesterOne.Add(cbx3);
            YearOneSemesterOne.Add(cbx4);

            YearOneSemesterTwo = new List<ComboBox>();
            YearOneSemesterTwo.Add(cbx5);
            YearOneSemesterTwo.Add(cbx6);
            YearOneSemesterTwo.Add(cbx7);
            YearOneSemesterTwo.Add(cbx8);


            YearTwoSemesterOne = new List<ComboBox>();
            YearTwoSemesterOne.Add(cbx9);
            YearTwoSemesterOne.Add(cbx10);
            YearTwoSemesterOne.Add(cbx11);
            YearTwoSemesterOne.Add(cbx12);

            YearTwoSemesterTwo = new List<ComboBox>();
            YearTwoSemesterTwo.Add(cbx13);
            YearTwoSemesterTwo.Add(cbx14);
            YearTwoSemesterTwo.Add(cbx15);
            YearTwoSemesterTwo.Add(cbx16);


            YearThreeSemesterOne = new List<ComboBox>();
            YearThreeSemesterOne.Add(cbx17);
            YearThreeSemesterOne.Add(cbx18);
            YearThreeSemesterOne.Add(cbx19);
            YearThreeSemesterOne.Add(cbx20);

            YearThreeSemesterTwo = new List<ComboBox>();
            YearThreeSemesterTwo.Add(cbx21);
            YearThreeSemesterTwo.Add(cbx22);
            YearThreeSemesterTwo.Add(cbx23);
            YearThreeSemesterTwo.Add(cbx24);

            //Completed
            YearOneSemesterOneCompleted = new List<CheckBox>();
            YearOneSemesterOneCompleted.Add(checkBox1);
            YearOneSemesterOneCompleted.Add(checkBox2);
            YearOneSemesterOneCompleted.Add(checkBox3);
            YearOneSemesterOneCompleted.Add(checkBox4);

            YearOneSemesterTwoCompleted = new List<CheckBox>();
            YearOneSemesterTwoCompleted.Add(checkBox5);
            YearOneSemesterTwoCompleted.Add(checkBox6);
            YearOneSemesterTwoCompleted.Add(checkBox7);
            YearOneSemesterTwoCompleted.Add(checkBox8);

            YearTwoSemesterOneCompleted = new List<CheckBox>();
            YearTwoSemesterOneCompleted.Add(checkBox9);
            YearTwoSemesterOneCompleted.Add(checkBox10);
            YearTwoSemesterOneCompleted.Add(checkBox11);
            YearTwoSemesterOneCompleted.Add(checkBox12);

            YearTwoSemesterTwoCompleted = new List<CheckBox>();
            YearTwoSemesterTwoCompleted.Add(checkBox13);
            YearTwoSemesterTwoCompleted.Add(checkBox14);
            YearTwoSemesterTwoCompleted.Add(checkBox15);
            YearTwoSemesterTwoCompleted.Add(checkBox16);

            YearThreeSemesterOneCompleted = new List<CheckBox>();
            YearThreeSemesterOneCompleted.Add(checkBox17);
            YearThreeSemesterOneCompleted.Add(checkBox18);
            YearThreeSemesterOneCompleted.Add(checkBox19);
            YearThreeSemesterOneCompleted.Add(checkBox20);

            YearThreeSemesterTwoCompleted = new List<CheckBox>();
            YearThreeSemesterTwoCompleted.Add(checkBox21);
            YearThreeSemesterTwoCompleted.Add(checkBox22);
            YearThreeSemesterTwoCompleted.Add(checkBox23);
            YearThreeSemesterTwoCompleted.Add(checkBox24);


            //Pass
            YearOneSemesterOnePassed = new List<RadioButton>();
            YearOneSemesterOnePassed.Add(pass1);
            YearOneSemesterOnePassed.Add(pass2);
            YearOneSemesterOnePassed.Add(pass3);
            YearOneSemesterOnePassed.Add(pass4);

            YearOneSemesterTwoPassed = new List<RadioButton>();
            YearOneSemesterTwoPassed.Add(pass5);
            YearOneSemesterTwoPassed.Add(pass6);
            YearOneSemesterTwoPassed.Add(pass7);
            YearOneSemesterTwoPassed.Add(pass8);

            YearTwoSemesterOnePassed = new List<RadioButton>();
            YearTwoSemesterOnePassed.Add(pass9);
            YearTwoSemesterOnePassed.Add(pass10);
            YearTwoSemesterOnePassed.Add(pass11);
            YearTwoSemesterOnePassed.Add(pass12);

            YearTwoSemesterTwoPassed = new List<RadioButton>();
            YearTwoSemesterTwoPassed.Add(pass13);
            YearTwoSemesterTwoPassed.Add(pass14);
            YearTwoSemesterTwoPassed.Add(pass15);
            YearTwoSemesterTwoPassed.Add(pass16);

            YearThreeSemesterOnePassed = new List<RadioButton>();
            YearThreeSemesterOnePassed.Add(pass17);
            YearThreeSemesterOnePassed.Add(pass18);
            YearThreeSemesterOnePassed.Add(pass19);
            YearThreeSemesterOnePassed.Add(pass20);

            YearThreeSemesterTwoPassed = new List<RadioButton>();
            YearThreeSemesterTwoPassed.Add(pass21);
            YearThreeSemesterTwoPassed.Add(pass22);
            YearThreeSemesterTwoPassed.Add(pass23);
            YearThreeSemesterTwoPassed.Add(pass24);


            study4DataSet papersDataSet = (study4DataSet)(this.FindResource("study4DataSet"));
            //this.Resources
            study4DataSetTableAdapters.PapersTableAdapter paperTableAdapter = new study4DataSetTableAdapters.PapersTableAdapter();
            paperTableAdapter.Fill(papersDataSet.Papers);

            study4DataSetTableAdapters.Paper_SemesterTableAdapter paperSemesterTableAdapater = new study4DataSetTableAdapters.Paper_SemesterTableAdapter();
            paperSemesterTableAdapater.Fill(papersDataSet.Paper_Semester);
            //CollectionViewSource paperViewSource = new CollectionViewSource();//(CollectionViewSource)(this.FindResource("papersViewSource"));
            //paperViewSource.View.MoveCurrentToFirst();

            // Gets the ids of the papers available in semester one
            var Semester1 = from x in papersDataSet.Paper_Semester
                            where x.Semester == 1
                            select x.Paper_ID;


            // Gets the ids of the papers available in semester two
            var Semester2 = from x in papersDataSet.Paper_Semester
                            where x.Semester == 2
                            select x.Paper_ID;


            // Year One Semester One

            List<SwitchSilver.study4DataSet.PapersRow> y1s1 = new List<study4DataSet.PapersRow>();
            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year == 1 && Semester1.Contains(paper.Paper_ID))
                {
                    y1s1.Add(paper);
                }
            }
            foreach (var box in YearOneSemesterOne)
            {
                box.ItemsSource = y1s1;
            }




            // Year One Semester Two

            List<SwitchSilver.study4DataSet.PapersRow> y1s2 = new List<study4DataSet.PapersRow>();
            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year == 1 && Semester2.Contains(paper.Paper_ID))
                {
                    y1s2.Add(paper);
                }
            }
            foreach (var box in YearOneSemesterTwo)
            {
                box.ItemsSource = y1s2;
            }



            // Year Two Semester One
            List<string> papersfromyearone = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearOneSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterOneCompleted[i].IsChecked == false || YearOneSemesterOnePassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }

                if (YearOneSemesterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterTwoCompleted[i].IsChecked == false || YearOneSemesterTwoPassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemesterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            List<SwitchSilver.study4DataSet.PapersRow> y2s1 = new List<study4DataSet.PapersRow>();
            
            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 2 && Semester1.Contains(paper.Paper_ID) && !papersfromyearone.Contains(paper.Paper_ID) && (papersfromyearone.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y2s1.Add(paper);
                }
            }
            foreach (var box in YearTwoSemesterOne)
            {
                box.ItemsSource = y2s1;
            }

            // Year Two Semester Two
            List<string> paperssofar = new List<string>();
            paperssofar.AddRange(papersfromyearone);
            for (int i = 0; i < 4; i++)
            {
                if (YearTwoSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearTwoSemesterOneCompleted[i].IsChecked == false || YearTwoSemesterOnePassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearTwoSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            List<SwitchSilver.study4DataSet.PapersRow> y2s2 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 2 && Semester2.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y2s2.Add(paper);
                }
            }
            foreach (var box in YearTwoSemesterTwo)
            {
                box.ItemsSource = y2s2;
            }

            // Year Three Semester One
            //List<string> paperssofar = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearTwoSemesterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearTwoSemesterTwoCompleted[i].IsChecked == false || YearTwoSemesterTwoPassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearTwoSemesterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }
            //if(YearOneSemesterOne.Sum(x=>(x.SelectedItem as study4DataSet.PapersRow).))

            List<SwitchSilver.study4DataSet.PapersRow> y3s1 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 3 && Semester1.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y3s1.Add(paper);
                }
            }
            foreach (var box in YearThreeSemesterOne)
            {
                box.ItemsSource = y3s1;
            }

            // Year Three Semester Two
            //List<string> paperssofar = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearThreeSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearThreeSemesterOneCompleted[i].IsChecked == false || YearThreeSemesterOnePassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearThreeSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }
            //if(YearOneSemesterOne.Sum(x=>(x.SelectedItem as study4DataSet.PapersRow).))

            List<SwitchSilver.study4DataSet.PapersRow> y3s2 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 3 && Semester1.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y3s2.Add(paper);
                }
            }
            foreach (var box in YearThreeSemesterTwo)
            {
                box.ItemsSource = y3s2;
            }
        }

        /// <summary>
        /// Selection Change Event for Year One Semester One
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void y1s1SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Goes through each combobox for Year One Semester One
            foreach (var box in YearOneSemesterOne)
            {
                // Checks the combobox isn't the combobox that was just changed
                if (box != sender)
                {
                    // Creates a list for the papers to be stored for each combobox;
                    List<object> papers= new List<object>();


                    // Adds the just unselected paper to the list
                    foreach (var removed in e.RemovedItems)
                    {
                        papers.Add(removed);
                    }

                    //Adds the contents of the combobox to the list
                    foreach (var item in box.Items)
                    {
                        papers.Add(item);
                    }

                    // Removes the item that was just selected from the list
                    foreach (var added in e.AddedItems)
                    {
                        papers.Remove(added);
                    }


                    // Sets the combobox's item source to the list so that it displays the new list of papers
                    box.ItemsSource = papers;
                }

            }

            // TEST

            study4DataSet papersDataSet = new study4DataSet();
            //this.Resources
            study4DataSetTableAdapters.PapersTableAdapter paperTableAdapter = new study4DataSetTableAdapters.PapersTableAdapter();
            paperTableAdapter.Fill(papersDataSet.Papers);

            study4DataSetTableAdapters.Paper_SemesterTableAdapter paperSemesterTableAdapater = new study4DataSetTableAdapters.Paper_SemesterTableAdapter();
            paperSemesterTableAdapater.Fill(papersDataSet.Paper_Semester);
            //CollectionViewSource paperViewSource = new CollectionViewSource();//(CollectionViewSource)(this.FindResource("papersViewSource"));
            //paperViewSource.View.MoveCurrentToFirst();

            // Gets the ids of the papers available in semester one
            var Semester1 = from x in papersDataSet.Paper_Semester
                            where x.Semester == 1
                            select x.Paper_ID;


            // Gets the ids of the papers available in semester two
            var Semester2 = from x in papersDataSet.Paper_Semester
                            where x.Semester == 2
                            select x.Paper_ID;

            // Year Two Semester One
            List<string> papersfromyearone = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearOneSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterOneCompleted[i].IsChecked == false || YearOneSemesterOnePassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }

                if (YearOneSemesterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterTwoCompleted[i].IsChecked == false || YearOneSemesterTwoPassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemesterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            List<SwitchSilver.study4DataSet.PapersRow> y2s1 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 2 && Semester1.Contains(paper.Paper_ID) && !papersfromyearone.Contains(paper.Paper_ID) && (papersfromyearone.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y2s1.Add(paper);
                }
            }
            foreach (var box in YearTwoSemesterOne)
            {
                box.ItemsSource = y2s1;
            }
            // Year Two Semester Two
            List<string> paperssofar = new List<string>();
            paperssofar.AddRange(papersfromyearone);
            for (int i = 0; i < 4; i++)
            {
                if (YearTwoSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearTwoSemesterOneCompleted[i].IsChecked == false || YearTwoSemesterOnePassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearTwoSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            List<SwitchSilver.study4DataSet.PapersRow> y2s2 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 2 && Semester2.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y2s2.Add(paper);
                }
            }
            foreach (var box in YearTwoSemesterTwo)
            {
                box.ItemsSource = y2s2;
            }


            // Year Three Semester One
            //List<string> paperssofar = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearTwoSemesterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearTwoSemesterTwoCompleted[i].IsChecked == false || YearTwoSemesterTwoPassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearTwoSemesterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }
            if (YearOneSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearOneSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearTwoSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearTwoSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) >= 240)
            {
                paperssofar.Add("CR240");
            }

            List<SwitchSilver.study4DataSet.PapersRow> y3s1 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 3 && Semester1.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y3s1.Add(paper);
                }
            }
            foreach (var box in YearThreeSemesterOne)
            {
                box.ItemsSource = y3s1;
            }

            // Year Three Semester Two
            //List<string> paperssofar = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearThreeSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearThreeSemesterOneCompleted[i].IsChecked == false || YearThreeSemesterOnePassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearThreeSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            if (YearOneSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearOneSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearTwoSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearTwoSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearThreeSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) >= 285 && paperssofar.Contains("I301"))
            {
                paperssofar.Add("CR285");
            }

            List<SwitchSilver.study4DataSet.PapersRow> y3s2 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 3 && Semester1.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y3s2.Add(paper);
                }
            }
            foreach (var box in YearThreeSemesterTwo)
            {
                box.ItemsSource = y3s2;
            }

        }
        
        /// <summary>
        /// Selection Change Event for Year One Semester Two
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void y1s2SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Goes through each combobox for Year One Semester One
            foreach (var box in YearOneSemesterTwo)
            {
                // Checks the combobox isn't the combobox that was just changed
                if (box != sender)
                {
                    // Creates a list for the papers to be stored for each combobox;
                    List<object> papers = new List<object>();


                    // Adds the just unselected paper to the list
                    foreach (var removed in e.RemovedItems)
                    {
                        papers.Add(removed);
                    }

                    //Adds the contents of the combobox to the list
                    foreach (var item in box.Items)
                    {
                        papers.Add(item);
                    }

                    // Removes the item that was just selected from the list
                    foreach (var added in e.AddedItems)
                    {
                        papers.Remove(added);
                    }


                    // Sets the combobox's item source to the list so that it displays the new list of papers
                    box.ItemsSource = papers;
                }
            }


            // TEST

            study4DataSet papersDataSet = new study4DataSet();
            //this.Resources
            study4DataSetTableAdapters.PapersTableAdapter paperTableAdapter = new study4DataSetTableAdapters.PapersTableAdapter();
            paperTableAdapter.Fill(papersDataSet.Papers);

            study4DataSetTableAdapters.Paper_SemesterTableAdapter paperSemesterTableAdapater = new study4DataSetTableAdapters.Paper_SemesterTableAdapter();
            paperSemesterTableAdapater.Fill(papersDataSet.Paper_Semester);
            //CollectionViewSource paperViewSource = new CollectionViewSource();//(CollectionViewSource)(this.FindResource("papersViewSource"));
            //paperViewSource.View.MoveCurrentToFirst();

            // Gets the ids of the papers available in semester one
            var Semester1 = from x in papersDataSet.Paper_Semester
                            where x.Semester == 1
                            select x.Paper_ID;


            // Gets the ids of the papers available in semester two
            var Semester2 = from x in papersDataSet.Paper_Semester
                            where x.Semester == 2
                            select x.Paper_ID;

            // Year Two Semester One
            List<string> papersfromyearone = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearOneSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterOneCompleted[i].IsChecked == false || YearOneSemesterOnePassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }

                if (YearOneSemesterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterTwoCompleted[i].IsChecked == false || YearOneSemesterTwoPassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemesterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            List<SwitchSilver.study4DataSet.PapersRow> y2s1 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 2 && Semester1.Contains(paper.Paper_ID) && !papersfromyearone.Contains(paper.Paper_ID) && (papersfromyearone.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y2s1.Add(paper);
                }
            }
            foreach (var box in YearTwoSemesterOne)
            {
                box.ItemsSource = y2s1;
            }

            // Year Two Semester Two
            List<string> paperssofar = new List<string>();
            paperssofar.AddRange(papersfromyearone);
            for (int i = 0; i < 4; i++)
            {
                if (YearTwoSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearTwoSemesterOneCompleted[i].IsChecked == false || YearTwoSemesterOnePassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearTwoSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            List<SwitchSilver.study4DataSet.PapersRow> y2s2 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 2 && Semester2.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y2s2.Add(paper);
                }
            }
            foreach (var box in YearTwoSemesterTwo)
            {
                box.ItemsSource = y2s2;
            }

            // Year Three Semester One
            //List<string> paperssofar = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearTwoSemesterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearTwoSemesterTwoCompleted[i].IsChecked == false || YearTwoSemesterTwoPassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearTwoSemesterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }
            if (YearOneSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearOneSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearTwoSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearTwoSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) >= 240)
            {
                paperssofar.Add("CR240");
            }

            List<SwitchSilver.study4DataSet.PapersRow> y3s1 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 3 && Semester1.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y3s1.Add(paper);
                }
            }
            foreach (var box in YearThreeSemesterOne)
            {
                box.ItemsSource = y3s1;
            }

            // Year Three Semester Two
            //List<string> paperssofar = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearThreeSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearThreeSemesterOneCompleted[i].IsChecked == false || YearThreeSemesterOnePassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearThreeSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            if (YearOneSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearOneSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearTwoSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearTwoSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearThreeSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) >= 285 && paperssofar.Contains("I301"))
            {
                paperssofar.Add("CR285");
            }

            List<SwitchSilver.study4DataSet.PapersRow> y3s2 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 3 && Semester2.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y3s2.Add(paper);
                }
            }
            foreach (var box in YearThreeSemesterTwo)
            {
                box.ItemsSource = y3s2;
            }

        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void y2s1SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            // TEST

            study4DataSet papersDataSet = new study4DataSet();
            //this.Resources
            study4DataSetTableAdapters.PapersTableAdapter paperTableAdapter = new study4DataSetTableAdapters.PapersTableAdapter();
            paperTableAdapter.Fill(papersDataSet.Papers);

            study4DataSetTableAdapters.Paper_SemesterTableAdapter paperSemesterTableAdapater = new study4DataSetTableAdapters.Paper_SemesterTableAdapter();
            paperSemesterTableAdapater.Fill(papersDataSet.Paper_Semester);
            //CollectionViewSource paperViewSource = new CollectionViewSource();//(CollectionViewSource)(this.FindResource("papersViewSource"));
            //paperViewSource.View.MoveCurrentToFirst();

            // Gets the ids of the papers available in semester one
            var Semester1 = from x in papersDataSet.Paper_Semester
                            where x.Semester == 1
                            select x.Paper_ID;


            // Gets the ids of the papers available in semester two
            var Semester2 = from x in papersDataSet.Paper_Semester
                            where x.Semester == 2
                            select x.Paper_ID;

            // Year Two Semester One
            List<string> papersfromyearone = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearOneSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterOneCompleted[i].IsChecked == false || YearOneSemesterOnePassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }

                if (YearOneSemesterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterTwoCompleted[i].IsChecked == false || YearOneSemesterTwoPassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemesterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            // Year Two Semester Two
            List<string> paperssofar = new List<string>();
            paperssofar.AddRange(papersfromyearone);
            for (int i = 0; i < 4; i++)
            {
                if (YearTwoSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearTwoSemesterOneCompleted[i].IsChecked == false || YearTwoSemesterOnePassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearTwoSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            List<SwitchSilver.study4DataSet.PapersRow> y2s2 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 2 && Semester2.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y2s2.Add(paper);
                }
            }
            foreach (var box in YearTwoSemesterTwo)
            {
                box.ItemsSource = y2s2;
            }


            // Year Three Semester One
            //List<string> paperssofar = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearTwoSemesterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearTwoSemesterTwoCompleted[i].IsChecked == false || YearTwoSemesterTwoPassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearTwoSemesterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }
            if (YearOneSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearOneSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearTwoSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearTwoSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) >= 240)
            {
                paperssofar.Add("CR240");
            }

            List<SwitchSilver.study4DataSet.PapersRow> y3s1 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 3 && Semester1.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y3s1.Add(paper);
                }
            }
            foreach (var box in YearThreeSemesterOne)
            {
                box.ItemsSource = y3s1;
            }

            // Year Three Semester Two
            //List<string> paperssofar = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearThreeSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearThreeSemesterOneCompleted[i].IsChecked == false || YearThreeSemesterOnePassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearThreeSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            if (YearOneSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearOneSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearTwoSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearTwoSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) + YearThreeSemesterOne.Sum(x => (x.SelectedItem is study4DataSet)?(x.SelectedItem as study4DataSet.PapersRow).Credits:0) >= 285 && paperssofar.Contains("I301"))
            {
                paperssofar.Add("CR285");
            }

            List<SwitchSilver.study4DataSet.PapersRow> y3s2 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 3 && Semester2.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y3s2.Add(paper);
                }
            }
            foreach (var box in YearThreeSemesterTwo)
            {
                box.ItemsSource = y3s2;
            }


            //The rest

            // Goes through each combobox for Year One Semester One
            foreach (var box in YearTwoSemesterOne)
            {
                // Checks the combobox isn't the combobox that was just changed
                if (box != sender)
                {
                    // Creates a list for the papers to be stored for each combobox;
                    List<object> papers = new List<object>();


                    // Adds the just unselected paper to the list
                    foreach (var removed in e.RemovedItems)
                    {
                        papers.Add(removed);
                    }

                    //Adds the contents of the combobox to the list
                    foreach (var item in box.Items)
                    {
                        papers.Add(item);
                    }

                    // Removes the item that was just selected from the list
                    foreach (var added in e.AddedItems)
                    {
                        papers.Remove(added);
                    }


                    // Sets the combobox's item source to the list so that it displays the new list of papers
                    box.ItemsSource = papers;
                }
            }
        }

        private void y2s2SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            // TEST

            study4DataSet papersDataSet = new study4DataSet();
            //this.Resources
            study4DataSetTableAdapters.PapersTableAdapter paperTableAdapter = new study4DataSetTableAdapters.PapersTableAdapter();
            paperTableAdapter.Fill(papersDataSet.Papers);

            study4DataSetTableAdapters.Paper_SemesterTableAdapter paperSemesterTableAdapater = new study4DataSetTableAdapters.Paper_SemesterTableAdapter();
            paperSemesterTableAdapater.Fill(papersDataSet.Paper_Semester);
            //CollectionViewSource paperViewSource = new CollectionViewSource();//(CollectionViewSource)(this.FindResource("papersViewSource"));
            //paperViewSource.View.MoveCurrentToFirst();

            // Gets the ids of the papers available in semester one
            var Semester1 = from x in papersDataSet.Paper_Semester
                            where x.Semester == 1
                            select x.Paper_ID;


            // Gets the ids of the papers available in semester two
            var Semester2 = from x in papersDataSet.Paper_Semester
                            where x.Semester == 2
                            select x.Paper_ID;

            // Year Two Semester One
            List<string> papersfromyearone = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearOneSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterOneCompleted[i].IsChecked == false || YearOneSemesterOnePassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }

                if (YearOneSemesterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterTwoCompleted[i].IsChecked == false || YearOneSemesterTwoPassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemesterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            // Year Two Semester Two
            List<string> paperssofar = new List<string>();
            paperssofar.AddRange(papersfromyearone);
            for (int i = 0; i < 4; i++)
            {
                if (YearTwoSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearTwoSemesterOneCompleted[i].IsChecked == false || YearTwoSemesterOnePassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearTwoSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }


            // Year Three Semester One
            //List<string> paperssofar = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearTwoSemesterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearTwoSemesterTwoCompleted[i].IsChecked == false || YearTwoSemesterTwoPassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearTwoSemesterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }
            if (YearOneSemesterOne.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearOneSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearTwoSemesterOne.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearTwoSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) >= 240)
            {
                paperssofar.Add("CR240");
            }

            List<SwitchSilver.study4DataSet.PapersRow> y3s1 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 3 && Semester1.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y3s1.Add(paper);
                }
            }
            foreach (var box in YearThreeSemesterOne)
            {
                box.ItemsSource = y3s1;
            }

            // Year Three Semester Two
            //List<string> paperssofar = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearThreeSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearThreeSemesterOneCompleted[i].IsChecked == false || YearThreeSemesterOnePassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearThreeSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            if (YearOneSemesterOne.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearOneSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearTwoSemesterOne.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearTwoSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearThreeSemesterOne.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) >= 285 && paperssofar.Contains("I301"))
            {
                paperssofar.Add("CR285");
            }

            List<SwitchSilver.study4DataSet.PapersRow> y3s2 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 3 && Semester2.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y3s2.Add(paper);
                }
            }
            foreach (var box in YearThreeSemesterTwo)
            {
                box.ItemsSource = y3s2;
            }


            //The rest

            // Goes through each combobox for Year One Semester One
            foreach (var box in YearTwoSemesterTwo)
            {
                // Checks the combobox isn't the combobox that was just changed
                if (box != sender)
                {
                    // Creates a list for the papers to be stored for each combobox;
                    List<object> papers = new List<object>();


                    // Adds the just unselected paper to the list
                    foreach (var removed in e.RemovedItems)
                    {
                        papers.Add(removed);
                    }

                    //Adds the contents of the combobox to the list
                    foreach (var item in box.Items)
                    {
                        papers.Add(item);
                    }

                    // Removes the item that was just selected from the list
                    foreach (var added in e.AddedItems)
                    {
                        papers.Remove(added);
                    }


                    // Sets the combobox's item source to the list so that it displays the new list of papers
                    box.ItemsSource = papers;
                }
            }
        }

        private void y3s1SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            // TEST

            study4DataSet papersDataSet = new study4DataSet();
            //this.Resources
            study4DataSetTableAdapters.PapersTableAdapter paperTableAdapter = new study4DataSetTableAdapters.PapersTableAdapter();
            paperTableAdapter.Fill(papersDataSet.Papers);

            study4DataSetTableAdapters.Paper_SemesterTableAdapter paperSemesterTableAdapater = new study4DataSetTableAdapters.Paper_SemesterTableAdapter();
            paperSemesterTableAdapater.Fill(papersDataSet.Paper_Semester);
            //CollectionViewSource paperViewSource = new CollectionViewSource();//(CollectionViewSource)(this.FindResource("papersViewSource"));
            //paperViewSource.View.MoveCurrentToFirst();

            // Gets the ids of the papers available in semester one
            var Semester1 = from x in papersDataSet.Paper_Semester
                            where x.Semester == 1
                            select x.Paper_ID;


            // Gets the ids of the papers available in semester two
            var Semester2 = from x in papersDataSet.Paper_Semester
                            where x.Semester == 2
                            select x.Paper_ID;

            // Year Two Semester One
            List<string> papersfromyearone = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearOneSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterOneCompleted[i].IsChecked == false || YearOneSemesterOnePassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }

                if (YearOneSemesterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterTwoCompleted[i].IsChecked == false || YearOneSemesterTwoPassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemesterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            // Year Two Semester Two
            List<string> paperssofar = new List<string>();
            paperssofar.AddRange(papersfromyearone);
            for (int i = 0; i < 4; i++)
            {
                if (YearTwoSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearTwoSemesterOneCompleted[i].IsChecked == false || YearTwoSemesterOnePassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearTwoSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }


            // Year Three Semester One
            //List<string> paperssofar = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearTwoSemesterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearTwoSemesterTwoCompleted[i].IsChecked == false || YearTwoSemesterTwoPassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearTwoSemesterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }
            if (YearOneSemesterOne.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearOneSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearTwoSemesterOne.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearTwoSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) >= 240)
            {
                paperssofar.Add("CR240");
            }

            // Year Three Semester Two
            //List<string> paperssofar = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearThreeSemesterOne[i].SelectedItem is study4DataSet.PapersRow && (YearThreeSemesterOneCompleted[i].IsChecked == false || YearThreeSemesterOnePassed[i].IsChecked == true))
                {
                    paperssofar.Add((YearThreeSemesterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }
            }

            if (YearOneSemesterOne.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearOneSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearTwoSemesterOne.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearTwoSemesterTwo.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) + YearThreeSemesterOne.Sum(x => (x.SelectedItem is study4DataSet.PapersRow) ? (x.SelectedItem as study4DataSet.PapersRow).Credits : 0) >= 285 && paperssofar.Contains("I301"))
            {
                paperssofar.Add("CR285");
            }

            List<SwitchSilver.study4DataSet.PapersRow> y3s2 = new List<study4DataSet.PapersRow>();

            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year <= 3 && Semester2.Contains(paper.Paper_ID) && !paperssofar.Contains(paper.Paper_ID) && (paperssofar.Contains(paper.Prerequisite) || paper.Prerequisite == "N/A"))
                {
                    y3s2.Add(paper);
                }
            }
            foreach (var box in YearThreeSemesterTwo)
            {
                box.ItemsSource = y3s2;
            }


            //The rest

            // Goes through each combobox for Year One Semester One
            foreach (var box in YearThreeSemesterOne)
            {
                // Checks the combobox isn't the combobox that was just changed
                if (box != sender)
                {
                    // Creates a list for the papers to be stored for each combobox;
                    List<object> papers = new List<object>();


                    // Adds the just unselected paper to the list
                    foreach (var removed in e.RemovedItems)
                    {
                        papers.Add(removed);
                    }

                    //Adds the contents of the combobox to the list
                    foreach (var item in box.Items)
                    {
                        papers.Add(item);
                    }

                    // Removes the item that was just selected from the list
                    foreach (var added in e.AddedItems)
                    {
                        papers.Remove(added);
                    }


                    // Sets the combobox's item source to the list so that it displays the new list of papers
                    box.ItemsSource = papers;
                }
            }
        }

        private void y3y2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var box in YearThreeSemesterTwo)
            {
                // Checks the combobox isn't the combobox that was just changed
                if (box != sender)
                {
                    // Creates a list for the papers to be stored for each combobox;
                    List<object> papers = new List<object>();


                    // Adds the just unselected paper to the list
                    foreach (var removed in e.RemovedItems)
                    {
                        papers.Add(removed);
                    }

                    //Adds the contents of the combobox to the list
                    foreach (var item in box.Items)
                    {
                        papers.Add(item);
                    }

                    // Removes the item that was just selected from the list
                    foreach (var added in e.AddedItems)
                    {
                        papers.Remove(added);
                    }


                    // Sets the combobox's item source to the list so that it displays the new list of papers
                    box.ItemsSource = papers;
                }
            }
        }

    }
}
