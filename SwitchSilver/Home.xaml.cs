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
    /// Interaction logic for the home page
    /// </summary>
    public partial class Page1 : Page
    {
        // Lists for each Semester
        List<PaperBox> YearOneSemesterOne;
        List<PaperBox> YearOneSemesterTwo;
        List<PaperBox> YearTwoSemesterOne;
        List<PaperBox> YearTwoSemesterTwo;
        List<PaperBox> YearThreeSemesterOne;
        List<PaperBox> YearThreeSemesterTwo;

        /// <summary>
        /// List of all the lists for each Semester
        /// </summary>
        List<List<PaperBox>> AllSemesters;

        /// <summary>
        ///  The dataset from the database for the papers
        /// </summary>
        study4DataSet papersDataSet;

        /// <summary>
        /// Lists of the paper ids for papers available in each semester
        /// </summary>
        List<string> Semester1;
        List<string> Semester2;

        /// <summary>
        /// The number of credits the student has
        /// </summary>
        int credits;
        
        /// <summary>
        /// List of the categories that have been selected
        /// </summary>
        List<string> categories;


        public Page1()
        {
            categories = new List<string>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            pageDisplayFrame.Content = new Details((((Hyperlink)sender).DataContext) as SwitchSilver.study4DataSet.PapersRow, pageDisplayFrame);
            pageDisplayFrame.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Loads the dataset, and populates the combo boxes with the initial values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            test.Content = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName;
            credits = 0;

            // Creates the lists for each semester
            YearOneSemesterOne = new List<PaperBox>();
            YearOneSemesterOne.Add(new PaperBox(paper1, completed1, pass1, fail1));
            YearOneSemesterOne.Add(new PaperBox(paper2, completed2, pass2, fail2));
            YearOneSemesterOne.Add(new PaperBox(paper3, completed3, pass3, fail3));
            YearOneSemesterOne.Add(new PaperBox(paper4, completed4, pass4, fail4));

            YearOneSemesterTwo = new List<PaperBox>();
            YearOneSemesterTwo.Add(new PaperBox(paper5, completed5, pass5, fail5));
            YearOneSemesterTwo.Add(new PaperBox(paper6, completed6, pass6, fail6));
            YearOneSemesterTwo.Add(new PaperBox(paper7, completed7, pass7, fail7));
            YearOneSemesterTwo.Add(new PaperBox(paper8, completed8, pass8, fail8));

            YearTwoSemesterOne = new List<PaperBox>();
            YearTwoSemesterOne.Add(new PaperBox(paper9, completed9, pass9, fail9));
            YearTwoSemesterOne.Add(new PaperBox(paper10, completed10, pass10, fail10));
            YearTwoSemesterOne.Add(new PaperBox(paper11, completed11, pass11, fail11));
            YearTwoSemesterOne.Add(new PaperBox(paper12, completed12, pass12, fail12));

            YearTwoSemesterTwo = new List<PaperBox>();
            YearTwoSemesterTwo.Add(new PaperBox(paper13, completed13, pass13, fail13));
            YearTwoSemesterTwo.Add(new PaperBox(paper14, completed14, pass14, fail14));
            YearTwoSemesterTwo.Add(new PaperBox(paper15, completed15, pass15, fail15));
            YearTwoSemesterTwo.Add(new PaperBox(paper16, completed16, pass16, fail16));


            YearThreeSemesterOne = new List<PaperBox>();
            YearThreeSemesterOne.Add(new PaperBox(paper17, completed17, pass17, fail17));
            YearThreeSemesterOne.Add(new PaperBox(paper18, completed18, pass18, fail18));
            YearThreeSemesterOne.Add(new PaperBox(paper19, completed19, pass19, fail19));
            YearThreeSemesterOne.Add(new PaperBox(paper20, completed20, pass20, fail20));

            YearThreeSemesterTwo = new List<PaperBox>();
            YearThreeSemesterTwo.Add(new PaperBox(paper21, completed21, pass21, fail21));
            YearThreeSemesterTwo.Add(new PaperBox(paper22, completed22, pass22, fail22));
            YearThreeSemesterTwo.Add(new PaperBox(paper23, completed23, pass23, fail23));
            YearThreeSemesterTwo.Add(new PaperBox(paper24, completed24, pass24, fail24));

            // Puts all the semester lists in a combined list
            AllSemesters = new List<List<PaperBox>>();
            AllSemesters.Add(YearOneSemesterOne);
            AllSemesters.Add(YearOneSemesterTwo);
            AllSemesters.Add(YearTwoSemesterOne);
            AllSemesters.Add(YearTwoSemesterTwo);
            AllSemesters.Add(YearThreeSemesterOne);
            AllSemesters.Add(YearThreeSemesterTwo);

            // Loads the papers and paper semesters from the database
            papersDataSet = (study4DataSet)(this.FindResource("study4DataSet"));
            study4DataSetTableAdapters.PapersTableAdapter paperTableAdapter = new study4DataSetTableAdapters.PapersTableAdapter();
            paperTableAdapter.Fill(papersDataSet.Papers);

            study4DataSetTableAdapters.Paper_SemesterTableAdapter paperSemesterTableAdapater = new study4DataSetTableAdapters.Paper_SemesterTableAdapter();
            paperSemesterTableAdapater.Fill(papersDataSet.Paper_Semester);
            
            // Gets the ids of the papers available in semester one
            Semester1 = papersDataSet.Paper_Semester.Where(x => x.Semester == 1).Select(x => x.Paper_ID).ToList(); 


            // Gets the ids of the papers available in semester two
            Semester2 = papersDataSet.Paper_Semester.Where(x => x.Semester == 2).Select(x => x.Paper_ID).ToList(); 

            // gets all the different categories from the database
            categories.AddRange(papersDataSet.Papers.Select(x => x.Categories).Distinct());

            // Semester One

            // gets all the papers available in year one semester one and adds them to the comboboxes
            List<SwitchSilver.study4DataSet.PapersRow> s1 = new List<study4DataSet.PapersRow>();
            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year == 1 && Semester1.Contains(paper.Paper_ID))
                {
                    s1.Add(paper);
                }
            }
            foreach (var box in YearOneSemesterOne)
            {
                box.Paper.ItemsSource = s1.Distinct();
            }

            // adds the papers that aren't first year papers then adds them to year two and three semester 1
            s1.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "N/A" && Semester1.Contains(x.Paper_ID)));

            foreach (var box in YearTwoSemesterOne)
            {
                box.Paper.ItemsSource = s1.Distinct();
            }
            foreach (var box in YearThreeSemesterOne)
            {
                box.Paper.ItemsSource = s1.Distinct();
            }




            // Semester Two

            // gets all the papers available in year one semester two and adds them to the comboboxes
            List<SwitchSilver.study4DataSet.PapersRow> s2 = new List<study4DataSet.PapersRow>();
            foreach (var paper in papersDataSet.Papers)
            {
                if (paper.Year == 1 && Semester2.Contains(paper.Paper_ID))
                {
                    s2.Add(paper);
                }
            }

            foreach (var box in YearOneSemesterTwo)
            {
                box.Paper.ItemsSource = s2.Distinct();
            }

            // adds the papers that aren't first year papers then adds them to year two and three semester 2
            s2.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "N/A" && Semester2.Contains(x.Paper_ID)));

            foreach (var box in YearTwoSemesterTwo)
            {
                box.Paper.ItemsSource = s2.Distinct();
            }
            foreach (var box in YearThreeSemesterTwo)
            {
                box.Paper.ItemsSource = s2.Distinct();
            }
        }

     

        // Ryan & Khan
        /// <summary>
        /// Occurs when the selected paper is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paperSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Gets the semester containing the combo box that was just changed
            List<PaperBox> updated = AllSemesters.Where(x => x.Where(y => y.Paper == sender).Count() > 0).First();
            
            // Gets the combo box that was updated
            ComboBox papercbx = updated.Where(x => x.Paper == sender).First().Paper;
            credits = 0;

            // Whether professional practice has been done
            bool ppdone = false;
            
            // Whether industry project is done
            bool ipdone = false;

            // goes through the semesters before the one where the combo box was just changed
            for (int i = 0; i < AllSemesters.IndexOf(updated); i++)
            {
                // Checks if professional practice has been done
                if (AllSemesters[i].Where(x => x.Paper.SelectedItem is study4DataSet.PapersRow && x.Fail.IsChecked != true && (x.Paper.SelectedItem as study4DataSet.PapersRow).Paper_ID == "I301").Count() > 0)
                {
                    ppdone = true;
                }

                // Checks if industry project is done
                if (AllSemesters[i].Where(x => x.Paper.SelectedItem is study4DataSet.PapersRow && x.Fail.IsChecked != true && (x.Paper.SelectedItem as study4DataSet.PapersRow).Paper_ID == "I302").Count() > 0)
                {
                    ipdone = true;
                }

                // adds the credits earned in the semester
                credits += AllSemesters[i].Sum(x => (x.Paper.SelectedItem is study4DataSet.PapersRow && x.Fail.IsChecked != true) ? (x.Paper.SelectedItem as study4DataSet.PapersRow).Credits : 0);
            }

            // Goes through the rest of the semesters
            for (int i = AllSemesters.IndexOf(updated); i < AllSemesters.Count; i++)
            {
                // gets the list for the correct semester
                List<string> semester = i % 2 == 0 ? Semester1 : Semester2;

                List<study4DataSet.PapersRow> add = new List<study4DataSet.PapersRow>();
                List<study4DataSet.PapersRow> remove = new List<study4DataSet.PapersRow>();

                // if i is greater than the updated semester and in the second year at least
                if (i > Math.Max(AllSemesters.IndexOf(updated), 1))
                {
                    // gets the papers from the right semester and whose prerequisites have just been selected
                    add.AddRange(papersDataSet.Papers.Where(x => e.AddedItems.Cast<study4DataSet.PapersRow>().Where(y => y.Paper_ID == x.Prerequisite).Count() > 0 && semester.Contains(x.Paper_ID) && x.Year <= 1 + i/2));
                    
                    // gets the papers whose prerequistes have just been removed
                    remove.AddRange(papersDataSet.Papers.Where(x => e.RemovedItems.Cast<study4DataSet.PapersRow>().Where(y => y.Paper_ID == x.Prerequisite).Count() > 0));
                }

                // adds the removed paper if it is available in these semester
                add.AddRange(e.RemovedItems.Cast<study4DataSet.PapersRow>().Where(x => semester.Contains(x.Paper_ID)));
                
                // removed the added paper
                remove.AddRange(e.AddedItems.Cast<study4DataSet.PapersRow>());

                // checks if professional practice requirements are done and adds it or removes it to reflect this
                if (!ppdone && credits >= 240)
                {
                    if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Prerequisite == "CR240").Count() == 0)
                    add.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "CR240"));
                }
                else
                {
                    remove.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "CR240"));
                }

                // checks if industry project requirements are done and adds it or moves it to reflect this
                if (!ipdone && ppdone && credits >= 285)
                {
                    if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Prerequisite == "CR285").Count() == 0)
                    add.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "CR285"));
                }
                else
                {
                    remove.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "CR285"));
                }

                // updates the combo boxes to reflect the new papers that are available to select
                foreach (var paper in AllSemesters[i])
                {
                    // updates all the combo boxes other than the one that was just changed
                    if (paper.Paper != sender)
                    {
                        List<study4DataSet.PapersRow> items = paper.Paper.Items.Cast<study4DataSet.PapersRow>().ToList();
                        items.RemoveAll(x => remove.Contains(x));
                        items.AddRange(add.Where(x => categories.Contains(x.Categories) || x.Compulsory));
                        paper.Paper.ItemsSource = items.Distinct();
                    }
                    else
                    {
                        // deselects the completed, passed and failed controls
                        paper.Completed.IsChecked = false;
                        paper.Fail.IsChecked = false;
                        paper.Pass.IsChecked = false;
                    }
                } 
                // updates the status of whether professional practice is done, industry project is done and the credits
                if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Paper_ID == "I301").Count() > 0)
                {
                    ppdone = true;
                }
                if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Paper_ID == "I302").Count() > 0)
                {
                    ipdone = true;
                }
                credits += AllSemesters[i].Sum(x => x.Paper.SelectedItem is study4DataSet.PapersRow ? (x.Paper.SelectedItem as study4DataSet.PapersRow).Credits : 0);
            }
        }

        // Ryan & Khan
        /// <summary>
        /// Clears the pass and fail radio buttons when completed is unchecked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void completedUnchecked(object sender, RoutedEventArgs e)
        {
            List<PaperBox> updated = AllSemesters.Where(x => x.Where(y => y.Completed == sender).Count() > 0).First();
            PaperBox paper = updated.Where(x => x.Completed == sender).First();
            paper.Fail.IsChecked = false;
            paper.Pass.IsChecked = false;
        }

        // Ryan & Khan
        /// <summary>
        /// Updates the papers in comboboxes when fail is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void failChecked(object sender, RoutedEventArgs e)
        {
            // Gets the semester containing the combo box that was just changed
            List<PaperBox> updated = AllSemesters.Where(x => x.Where(y => y.Fail == sender).Count() > 0).First();

            // Gets the combo box that was updated
            ComboBox papercbx = updated.Where(x => x.Fail == sender).First().Paper;
            
            credits = 0;

            bool ppdone = false;
            bool ipdone = false;
            
            // goes through the semesters until the one containing the paper that was just changed
            for (int i = 0; i < AllSemesters.IndexOf(updated) + 1; i++)
            {
                // Checks if professional practice has been done
                if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Paper_ID == "I301").Count() > 0)
                {
                    ppdone = true;
                }

                // Checks if industry project has been done
                if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Paper_ID == "I302").Count() > 0)
                {
                    ipdone = true;
                }

                // adds the credits earned in the semester
                credits += AllSemesters[i].Sum(x => x.Paper.SelectedItem is study4DataSet.PapersRow ? (x.Paper.SelectedItem as study4DataSet.PapersRow).Credits : 0);
            }
             
            //goes through the rest of the semesters
            for (int i = AllSemesters.IndexOf(updated) + 1; i < AllSemesters.Count; i++)
            {
                // gets the list for the correct semester
                List<string> semester = i % 2 == 0 ? Semester1 : Semester2;

                List<study4DataSet.PapersRow> add = new List<study4DataSet.PapersRow>();
                List<study4DataSet.PapersRow> remove = new List<study4DataSet.PapersRow>();

                // if the failed paper is available in the current semester it is added
                if (semester.Contains((papercbx.SelectedItem as study4DataSet.PapersRow).Paper_ID))
                    add.Add(papercbx.SelectedItem as study4DataSet.PapersRow);
                // gets the papers with the failed paper as a prerequisite to remove
                remove.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == (paper1.SelectedItem as study4DataSet.PapersRow).Paper_ID));
                
                // checks if professional practice and industry project should be added or removed and does so
                if (!ppdone && credits >= 240)
                {
                    if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Prerequisite == "CR240").Count() == 0)
                        add.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "CR240"));
                }
                else
                {
                    remove.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "CR240"));
                }
                if (!ipdone && ppdone && credits >= 285)
                {
                    if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Prerequisite == "CR285").Count() == 0)
                        add.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "CR285"));
                }
                else
                {
                    remove.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "CR285"));
                }


                // updates the combo boxes to reflect the new papers that are available to select
                foreach (var paper in AllSemesters[i])
                {
                    List<study4DataSet.PapersRow> items = paper.Paper.Items.Cast<study4DataSet.PapersRow>().ToList();
                    items.RemoveAll(x => remove.Contains(x));
                    items.AddRange(add.Where(x => categories.Contains(x.Categories) || x.Compulsory));
                    paper.Paper.ItemsSource = items.Distinct();
                }


                // updates the status of whether professional practice is done, industry project is done and the credits
                if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Paper_ID == "I301").Count() > 0)
                {
                    ppdone = true;
                }
                if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Paper_ID == "I302").Count() > 0)
                {
                    ipdone = true;
                }
                credits += AllSemesters[i].Sum(x => x.Paper.SelectedItem is study4DataSet.PapersRow ? (x.Paper.SelectedItem as study4DataSet.PapersRow).Credits : 0);
            }
        }

        // Ryan & Khan
        private void failUnchecked(object sender, RoutedEventArgs e)
        {
            // Gets the semester containing the combo box that was just changed
            List<PaperBox> updated = AllSemesters.Where(x => x.Where(y => y.Fail == sender).Count() > 0).First();

            // Gets the combo box that was updated
            ComboBox papercbx = updated.Where(x => x.Fail == sender).First().Paper;
            credits = 0;
            bool ppdone = false;
            bool ipdone = false;

            // goes through the semesters until the one containing the paper that was just changed
            for (int i = 0; i < AllSemesters.IndexOf(updated) + 1; i++)
            {
                // Checks if professional practice has been done
                if (AllSemesters[i].Where(x => x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Paper_ID == "I301").Count() > 0)
                {
                    ppdone = true;
                }
                // Checks if industry project has been done
                if (AllSemesters[i].Where(x => x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Paper_ID == "I302").Count() > 0)
                {
                    ipdone = true;
                }
                // adds the credits earned in the semester
                credits += AllSemesters[i].Sum(x => x.Paper.SelectedItem is study4DataSet.PapersRow ? (x.Paper.SelectedItem as study4DataSet.PapersRow).Credits : 0);
            }

            // goes through the rest of the semesters
            for (int i = AllSemesters.IndexOf(updated) + 1; i < AllSemesters.Count; i++)
            {
                // gets the list for the correct semester
                List<string> semester = i % 2 == 0 ? Semester1 : Semester2;
                List<study4DataSet.PapersRow> add = new List<study4DataSet.PapersRow>();
                List<study4DataSet.PapersRow> remove = new List<study4DataSet.PapersRow>();

                // gets the paper that was just changed from being failed to not to remove
                remove.Add(papercbx.SelectedItem as study4DataSet.PapersRow);

                // gets the papers that prerequisties have just been completed by the paper that was just changed from failed
                add.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == (paper1.SelectedItem as study4DataSet.PapersRow).Paper_ID && semester.Contains(x.Paper_ID)));

                // checks if professional practice and industry project should be added or removed and does so 
                if (!ppdone && credits >= 240)
                {
                    if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Prerequisite == "CR240").Count() == 0)
                        add.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "CR240"));
                }
                else
                {
                    remove.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "CR240"));
                }
                if (!ipdone && ppdone && credits >= 285)
                {
                    if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Prerequisite == "CR285").Count() == 0)
                        add.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "CR285"));
                }
                else
                {
                    remove.AddRange(papersDataSet.Papers.Where(x => x.Prerequisite == "CR285"));
                }

                // updates the combo boxes to reflect the new papers that are available to select
                foreach (var paper in AllSemesters[i])
                {
                    List<study4DataSet.PapersRow> items = paper.Paper.Items.Cast<study4DataSet.PapersRow>().ToList();
                    items.RemoveAll(x => remove.Contains(x));
                    items.AddRange(add.Where(x => categories.Contains(x.Categories) || x.Compulsory));
                    paper.Paper.ItemsSource = items.Distinct();
                }

                // updates the status of whether professional practice is done, industry project is done and the credits
                if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Paper_ID == "I301").Count() > 0)
                {
                    ppdone = true;
                }
                if (AllSemesters[i].Where(x => x.Fail.IsChecked != true && x.Paper.SelectedItem is study4DataSet.PapersRow && (x.Paper.SelectedItem as study4DataSet.PapersRow).Paper_ID == "I302").Count() > 0)
                {
                    ipdone = true;
                }
                credits += AllSemesters[i].Sum(x => x.Paper.SelectedItem is study4DataSet.PapersRow ? (x.Paper.SelectedItem as study4DataSet.PapersRow).Credits : 0);
            }
        }

        /// <summary>
        /// Occurs when a category is checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void categoryChecked(object sender, RoutedEventArgs e)
        {
            if (IsLoaded)
            {
                // adds the category that was just ticked to the category list
                categories.Add((sender as CheckBox).Content.ToString());
                
                // gets the papers from that category
                List<study4DataSet.PapersRow> catPapers = papersDataSet.Papers.Where(x => x.Categories == (sender as CheckBox).Content.ToString()).ToList();
                
                // store the papers that have been done
                List<string> prerequisites = new List<string>();
                prerequisites.Add("N/A");
                
                // goes through all the semesters
                for (int i = 0; i < AllSemesters.Count; i++)
                {
                    // gets the list for the correct semester
                    List<string> semester = i % 2 == 0 ? Semester1 : Semester2;
                    foreach (var pap in AllSemesters[i])
                    {
                        // adds papers whose prequisites are done and are in the correct year and semester
                        List<study4DataSet.PapersRow> items = pap.Paper.Items.Cast<study4DataSet.PapersRow>().ToList();
                        items.AddRange(catPapers.Where(x => prerequisites.Contains(x.Prerequisite) && semester.Contains(x.Paper_ID) && x.Year <= 1 + i/2 && AllSemesters[i].Where(y => y.Paper.SelectedItem == x).Count() == 0));
                        pap.Paper.ItemsSource = items.Distinct();

                        // removes passed papers from the category papers and adds passed papers to the prerequisites
                        if (pap.Paper.SelectedItem is study4DataSet.PapersRow && pap.Fail.IsChecked != true)
                        {
                            prerequisites.Add((pap.Paper.SelectedItem as study4DataSet.PapersRow).Paper_ID);
                            catPapers.Remove(pap.Paper.SelectedItem as study4DataSet.PapersRow);
                        }
                    }
                }
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            // removes the category that was just ticked to the category list
            categories.Remove((sender as CheckBox).Content.ToString());
            // removes all the non compulsory, non selected papers that aren't from a checked category
            foreach (var sem in AllSemesters)
            {
                foreach (var pap in sem)
                {
                    pap.Paper.ItemsSource = pap.Paper.Items.Cast<study4DataSet.PapersRow>().Where(x => x.Compulsory || categories.Contains(x.Categories) || x == pap.Paper.SelectedItem);
                }
            }
        }
    }
}
