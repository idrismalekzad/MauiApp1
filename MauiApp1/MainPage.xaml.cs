namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void OnUploadFileClicked(object sender, EventArgs e)
        {
            var result = await PickAndShowFileAsync();
            if (!string.IsNullOrEmpty(result))
            {

            }
        }

        private async void OnStartActionClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Action", "Python Application Started", "OK");
        }

        private async Task<string> PickAndShowFileAsync()
        {
            try
            {
                var result = await FilePicker.PickAsync(new PickOptions
                {
                    PickerTitle = "Please Select a Title"
                });
                if (result is not null)
                {
                    var stream = await result.OpenReadAsync();
                    using (var reader = new StreamReader(stream))
                    {
                        string content = await reader.ReadToEndAsync();
                        return content;
                    }
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }

            return null;
        }
    }

}
