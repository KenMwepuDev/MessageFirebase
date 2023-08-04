using Firebase.Database;
using Firebase.Database.Query;
using MessageFirebase.Model;

namespace MessageFirebase;

public partial class MainPage : ContentPage
{
    private FirebaseClient firebaseClient;

    public MainPage()
    {
        InitializeComponent();
        firebaseClient = new FirebaseClient("https://chatmessage-a4377-default-rtdb.firebaseio.com/");
    }

    private async void BT_SendMessage_Clicked(object sender, EventArgs e)
    {
        if (EntryUserName.Text != string.Empty && EntryMessage.Text != string.Empty)
            await Navigation.PushAsync(new MessagePage());
        else
            await DisplayAlert("ENTRY ERROR", "Username and message cannot be empty, please try again !", "OK");

        await firebaseClient.Child("Message").Child(Guid.NewGuid().ToString()).PutAsync(new MesageObject()
        {
            MessageText = EntryMessage.Text,
            userOwner = EntryUserName.Text,
            DateSend = DateTime.Now
        });
    }
}

