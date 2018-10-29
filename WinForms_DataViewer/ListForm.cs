using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_DataViewer.DAL;

namespace WinForms_DataViewer
{
    public partial class ListForm : Form
    {
        private List<Character> _characters;

        private string _sortNameDir;

        public enum FilterGenderType { Male, Female }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ListForm()
        {
            InitializeComponent();
        }
        #region EVENTS

        private void ListForm_Load(object sender, EventArgs e)
        {
            lbl_SearchMessage.Text = "";

            //
            // bind the data source to the datagridview
            //
            try
            {
                ReadMongoDBAndBindToDataGrid();
            }
            catch (FileNotFoundException)
            {

                MessageBox.Show("Unable to locate data file.\nExiting the application.");
                this.Close();
            }
        }

        private void btn_CheckList_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_Characters.SelectedRows)
            {
                dataGridView_Characters.Rows.RemoveAt(row.Index);
            }
        }

        private void btn_DetailView_Click(object sender, EventArgs e)
        {
            //
            // send the selected record to the DetailForm and launch the DetailForm
            //
            if (dataGridView_Characters.SelectedRows.Count == 1)
            {
                Character character = new Character();
                character = (Character)dataGridView_Characters.CurrentRow.DataBoundItem;

                DetailForm detailForm = new DetailForm(character);
                detailForm.ShowDialog();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            try
            {
                //
                // make sure the grid is replicated to the data source
                //
                IDataService dataService = new MongoDBDataService();
                dataService.WriteAll(_characters);

            }
            catch (Exception)
            {

                throw;
            }
            this.Close();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            SortSearchFilter();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            SortSearchFilter();
        }

        private void dataGridView_Characters_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //
            // display the number of matching records on the form
            //
            if (dataGridView_Characters.Rows.Count == 0)
            {
                lbl_SearchMessage.Text = "No results found";
            }
            else
            {
                int i = dataGridView_Characters.RowCount;
                lbl_SearchMessage.Text = String.Format("{0} record{1} found", (i.ToString()), (i == 1 ? "" : "s"));
            }
        }

        private void cmb_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortSearchFilter();     
        }

        private void btn_ClearSearch_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
        }

        private void btn_ClearFilter_Click(object sender, EventArgs e)
        {
            cmb_Filter.SelectedIndex = 0;
        }

        #endregion EVENTS

        #region METHODS

        /// <summary>
        /// Connect to the database, retrieve a list of Characters, and bind the list to the data grid
        /// </summary>
        private void ReadMongoDBAndBindToDataGrid()
        {
            //
            // read data file
            //
            IDataService dataService = new MongoDBDataService();

            //
            // insert data into the table, only needed when the table is empty
            //
            //dataService.WriteAll(GenerateListOfCharacters());

            _characters = dataService.ReadAll().ToList<Character>();

            //
            // bind list to DataGridView control
            //
            var bindingList = new BindingList<Character>(_characters);
            var source = new BindingSource(bindingList, null);
            dataGridView_Characters.DataSource = source;

            //
            // configure DataGridView control
            //
            this.dataGridView_Characters.Columns["Id"].Visible = false;
            this.dataGridView_Characters.Columns["ImageFileName"].Visible = false;
            this.dataGridView_Characters.Columns["Description"].Visible = false;
        }
        
        private void SortSearchFilter()
        {
            if (_characters.Any())
            {
                List<Character> resultList = SortList(FilterList(SearchList(_characters)));
                dataGridView_Characters.DataSource = resultList;
            }
        }

        /// <summary>
        /// Filters a list of Characters and returns a list of characters that match the filter criteria
        /// </summary>
        /// <param name="characterList"></param>
        /// <returns>List of Character</returns>
        private List<Character> FilterList(List<Character> characterList)
        {
            string searchTerm = txt_Search.Text;
            List<Character> filteredList;
            filteredList = characterList.Where(c => (cmb_Filter.Text == "" || c.Gender.ToString() == cmb_Filter.Text)).ToList();

            return filteredList;
        }

        /// <summary>
        /// Searches a list of Characters and returns a list of characters that match the search criteria
        /// </summary>
        /// <param name="characterList"></param>
        /// <returns>List of Character</returns>
        private List<Character> SearchList(List<Character> characterList)
        {
            string searchTerm = txt_Search.Text;

            List<Character> searchedList = characterList.Where(c => c.LastName.ToUpper().Contains(searchTerm.ToUpper())
                                                || c.FirstName.ToUpper().Contains(searchTerm.ToUpper())).ToList();

            return searchedList;
        }

        /// <summary>
        /// Sorts a list of Characters, alternately in ascending and descending order
        /// </summary>
        /// <param name="characterList"></param>
        /// <returns>List of Character</returns>
        private List<Character> SortList(List<Character> characterList)
        {
            List<Character> sortedList;

            //
            // sort ascending when _sortNameDir = "A", and descending otherwise
            //
            if (_sortNameDir == "A" || _sortNameDir == null)
            {
                sortedList = characterList.OrderBy(c => c.LastName + c.FirstName).ToList();
                _sortNameDir = "D";
                btn_Sort.Text = "Sort Desc";
            }
            else
            {
                sortedList = characterList.OrderByDescending(c => c.LastName + c.FirstName).ToList();
                _sortNameDir = "A";
                btn_Sort.Text = "Sort";
            }

            return sortedList;
        }

        /// <summary>
        /// Initializes a list of Character objects
        /// </summary>
        /// <returns>List of Character</returns>
        private static List<Character> GenerateListOfCharacters()
        {
            List<Character> characters = new List<Character>()
            {
                new Character()
                {
                    Id = 1,
                    LastName = "Flintstone",
                    FirstName = "Fred",
                    Age = 28,
                    Gender = Character.GenderType.Male,
                    ImageFileName = "fred_flintstone.jpg",
                    Description = "Fred is the main character of the series. He's an accident-prone bronto-crane operator at the Slate Rock and Gravel Company and the head of the Flintstone household. He is quick to anger (usually over trivial matters), but is nonetheless a very loving husband and father. He's also good at bowling and is a member of the fictional \"Loyal Order of Water Buffaloes\" (Lodge No. 26), a men-only club paralleling real-life fraternities such as the Loyal Order of Moose."
                },
                new Character()
                {
                    Id = 2,
                    LastName = "Flintstone",
                    FirstName = "Wilma",
                    Age = 27,
                    Gender = Character.GenderType.Female,
                    ImageFileName = "wilma_flintstone.jpg",
                    Description = "Wilma is Fred's wife. She is more intelligent and level-headed than her husband, though she often has a habit of spending money recklessly (with Betty and her catchphrase being \"Da-da-da duh da-da CHARGE IT!!\"). She's often a foil to Fred's poor behavior."
                },
                new Character()
                {
                    Id = 3,
                    LastName = "Flintstone",
                    FirstName = "Pebbles",
                    Age = 1,
                    Gender = Character.GenderType.Female,
                    ImageFileName = "pebbles_flintstone.jpg",
                    Description = "Pebbles is the Flintstones' infant daughter, who is born near the end of the third season."
                },
                new Character()
                {
                    Id = 4,
                    LastName = "Rubble",
                    FirstName = "Barney",
                    Age = 28,
                    Gender = Character.GenderType.Male,
                    ImageFileName = "barney_rubble.jpg",
                    Description = "Barney is the secondary main character and Fred's best friend and next-door neighbor. His occupation is, for the most part of the series, unknown, though later series depict him working in the same quarry as Fred. He shares many of Fred's interests such as bowling and golf, and is also a member of the \"Loyal Order of Water Buffaloes\". Though Fred and Barney frequently get into feuds with one another (usually due to Fred's short temper), their deep fraternal bond remains evident."
                },
                new Character()
                {
                    Id = 5,
                    LastName = "Rubble",
                    FirstName = "Betty",
                    Age = 26,
                    Gender = Character.GenderType.Female,
                    ImageFileName = "betty_rubble.gif",
                    Description = "Betty is Barney's wife and Wilma's best friend. Like Wilma, she, too, has a habit of carelessly spending money."
                },
                new Character()
                {
                    Id = 6,
                    LastName = "Rubble",
                    FirstName = "Bamm-Bamm",
                    Age = 2,
                    Gender = Character.GenderType.Male,
                    ImageFileName = "bamm_bamm_rubble.gif",
                    Description = "Bamm-Bamm is the Rubbles' abnormally strong adopted son, whom they adopt during the fourth season."
                },
                new Character()
                {
                    Id = 7,
                    LastName = "",
                    FirstName = "Dino",
                    Age = 7,
                    Gender = Character.GenderType.Female,
                    ImageFileName = "dino.jpg",
                    Description = "Dino, a prosauropod dinosaur, is the Flintstones' pet that barks and generally acts like a dog. A running gag in the series involves Dino knocking down Fred out of excitement and licking him repeatedly. Though this irritates Fred a lot, he generally likes Dino very much."
                }
            };

            return characters;
        }

        #endregion METHODS

    }
}
