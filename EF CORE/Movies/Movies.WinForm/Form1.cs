using Movies.Application;
using Movies.Data.Data;
using Movies.Data.Repositories;

namespace Movies.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private async void buttonGetMovies_Click(object sender, EventArgs e)
        {
            MoviesDbContext moviesDbContext = new MoviesDbContext();
            EFMovieRepository EFMovieRepository = new EFMovieRepository(moviesDbContext);
            MovieService movieService = new MovieService(EFMovieRepository);

            var responses = await movieService.GetAllMovies();

            foreach (var item in responses)
            {
                listBoxMovies.Items.Add($"{item.Name} {item?.Duration} dakika");
            }
        }
    }
}