using Movies.Application.DTOs.Requests;
using Movies.Application;
using Movies.Data.Data;
using Movies.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies.WinForm
{
    public partial class FormMovies : Form
    {
        public FormMovies()
        {
            InitializeComponent();
            MoviesDbContext moviesDbContext = new MoviesDbContext();
            EFMovieRepository movieRepository = new EFMovieRepository(moviesDbContext);
            EFPlayerRepository playerRepository = new EFPlayerRepository(moviesDbContext);
            EFDirectorRepository directorRepository = new EFDirectorRepository(moviesDbContext);

            playerService = new PlayerService(playerRepository);
            movieService = new MovieService(movieRepository);
            directorService = new DirectorService(directorRepository);
        }

        private readonly IPlayerService playerService;
        private readonly IMovieService movieService;
        private readonly IDirectorService directorService;
        private async void FormMovies_Load(object sender, EventArgs e)
        {
            await fillDirectories();
            await fillPlayers();
        }

        private async Task fillPlayers()
        {
            var players = await playerService.GetPlayerLists();
            var playerFullNames = players.Select(p => new
            {
                Id = p.Id,
                FullName = $"{p.Name} {p.LastName}"
            });

            listBoxPlayers.DataSource = playerFullNames.ToList();
            listBoxPlayers.DisplayMember = "FullName";
            listBoxPlayers.ValueMember = "Id";

        }

        private async Task fillDirectories()
        {
            var directors = await directorService.GetDirectorsAsync();
            var directorFullNames = directors.Select(p => new
            {
                Id = p.Id,
                FullName = $"{p.Name} {p.LastName}"
            });

            comboBoxDirectors.DataSource = directorFullNames.ToList();
            comboBoxDirectors.DisplayMember = "FullName";
            comboBoxDirectors.ValueMember = "Id";
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            List<int> selectedPlayerIds = new List<int>();


            //dynamic aValue="deneme";
            //MessageBox.Show(aValue.ToUpper());            


            foreach (dynamic item in listBoxPlayers.SelectedItems)
            {
                selectedPlayerIds.Add(item.Id);
            }

            var createNewMovieRequest = new CreateNewMovieRequest
            {
                DirectorId = (int)comboBoxDirectors.SelectedValue,
                Duration = Convert.ToInt32(textBoxDuration.Text),
                Name = textBoxTitle.Text,
                PublishDate = dateTimePickerPublishDate.Value


            };
            var movieId = await movieService.CreateNewMovie(createNewMovieRequest);

            await movieService.AddPlayerToMovie(movieId, selectedPlayerIds);


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
