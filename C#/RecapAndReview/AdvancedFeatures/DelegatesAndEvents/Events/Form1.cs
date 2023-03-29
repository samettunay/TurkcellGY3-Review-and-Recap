namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserService userService = new UserService();
            userService.UserCreated += UserService_UserCreated;
            User user = new() { UserName = "turkay" };
            userService.Create(user);
        }

        private void UserService_UserCreated(object? sender, UserCreatedEventArgs e)
        {
            MessageBox.Show($"{e.CreatedDate.ToLongDateString()} tarihinde, {e.User.UserName} kullanýcýsý eklendi");
        }
    }
}