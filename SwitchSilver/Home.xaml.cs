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
        List<ComboBox> YearOneSemsterOne;
        List<ComboBox> YearOneSemsterTwo;
        List<ComboBox> YearTwoSemsterOne;
        List<ComboBox> YearTwoSemsterTwo;
        List<ComboBox> YearThreeSemsterOne;
        List<ComboBox> YearThreeSemsterTwo;

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

            YearOneSemsterOne = new List<ComboBox>();
            YearOneSemsterOne.Add(cbx1);
            YearOneSemsterOne.Add(cbx2);
            YearOneSemsterOne.Add(cbx3);
            YearOneSemsterOne.Add(cbx4);

            


            YearOneSemsterTwo = new List<ComboBox>();
            YearOneSemsterTwo.Add(cbx5);
            YearOneSemsterTwo.Add(cbx6);
            YearOneSemsterTwo.Add(cbx7);
            YearOneSemsterTwo.Add(cbx8);


            YearTwoSemsterOne = new List<ComboBox>();
            YearTwoSemsterOne.Add(cbx9);
            YearTwoSemsterOne.Add(cbx10);
            YearTwoSemsterOne.Add(cbx11);
            YearTwoSemsterOne.Add(cbx12);


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
            foreach (var box in YearOneSemsterOne)
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
            foreach (var box in YearOneSemsterTwo)
            {
                box.ItemsSource = y1s2;
            }



            // Year Two Semester One
            List<string> papersfromyearone = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                if (YearOneSemsterOne[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterOneCompleted[i].IsChecked == false || YearOneSemesterOnePassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemsterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }

                if (YearOneSemsterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterTwoCompleted[i].IsChecked == false || YearOneSemesterTwoPassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemsterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
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
            foreach (var box in YearTwoSemsterOne)
            {
                box.ItemsSource = y2s1;
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
            foreach (var box in YearOneSemsterOne)
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
                if (YearOneSemsterOne[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterOneCompleted[i].IsChecked == false || YearOneSemesterOnePassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemsterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }

                if (YearOneSemsterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterTwoCompleted[i].IsChecked == false || YearOneSemesterTwoPassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemsterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
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
            foreach (var box in YearTwoSemsterOne)
            {
                box.ItemsSource = y2s1;
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
            foreach (var box in YearOneSemsterTwo)
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
                if (YearOneSemsterOne[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterOneCompleted[i].IsChecked == false || YearOneSemesterOnePassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemsterOne[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
                }

                if (YearOneSemsterTwo[i].SelectedItem is study4DataSet.PapersRow && (YearOneSemesterTwoCompleted[i].IsChecked == false || YearOneSemesterTwoPassed[i].IsChecked == true))
                {
                    papersfromyearone.Add((YearOneSemsterTwo[i].SelectedItem as study4DataSet.PapersRow).Paper_ID);
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
            foreach (var box in YearTwoSemsterOne)
            {
                box.ItemsSource = y2s1;
            }
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
