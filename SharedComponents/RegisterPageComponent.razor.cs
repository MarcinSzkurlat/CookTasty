namespace SharedComponents
{
    public partial class RegisterPageComponent
    {
        public string Email { get; set; }
        public string Password { get; set; }

        private void SubmitBtnHandler()
        {
            Console.WriteLine(Email);
            Console.WriteLine(Password);
            NavigationManager.NavigateTo("/");
        }
    }
}
