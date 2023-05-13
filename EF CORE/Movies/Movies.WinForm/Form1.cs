using Movies.Application;
using Movies.Data.Data;
using Movies.Data.Repositories;

namespace Movies.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var db = new MoviesDbContext();
            var repository = new EFMovieRepository(db);
            var movieService = new MovieService(repository);

            var list = await movieService.GetAllMovies();

            dataGridView1.DataSource = list.ToList();
        }

        private void buttonDirector_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlayers_Click(object sender, EventArgs e)
        {

        }
    }
}