using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisJokesLibrary;

namespace ChuckNorrisJokes
{
    public partial class Form1 : Form
    {
        private string notFound = "Nothing found :(";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            categoriesListBox.SetSelected(0, true);
            var provider = new JokesDataProvider();
            var categories = provider.GetCategories();
            foreach(var category in categories) {
                categoriesListBox.Items.Add(category);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void jokeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var selectedCategory = categoriesListBox.SelectedItem;
            if (selectedCategory.ToString() == "any") {
                var provider = new JokesDataProvider();
                var randomJoke = provider.GetRandom();
                jokeText.Text = randomJoke.GetValue();
                jokeImage.Load(randomJoke.GetIconUrl());
            } else {
                var provider = new JokesDataProvider();
                var randomJoke = provider.GetRandomInCategory(selectedCategory.ToString());
                jokeText.Text = randomJoke.GetValue();
                jokeImage.Load(randomJoke.GetIconUrl());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void searchByNameBtn_Click(object sender, EventArgs e)
        {
            searchByName();
        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Return")
            {
                searchByName();
            }
        }

        private void searchByName()
        {
            var q = searchTextBox.Text;

            if (q.Length < 3 || q.Length > 120)
            {
                return;
            }

            var provider = new JokesDataProvider();
            var jokes = provider.FindByName(q);

            if (jokes.Count() == 0)
            {
                jokeText.Text = notFound;
                return;
            }

            jokeText.Text = "";

            foreach (var joke in jokes)
            {
                if (jokeText.Text.Length == 0)
                {
                    jokeText.Text = joke.GetValue();
                    jokeImage.Load(joke.GetIconUrl());
                    continue;
                }

                jokeText.AppendText("\r\n\n" + joke.GetValue());
            }
        }
    }
}
