using Firebase.Database;
using Firebase.Database.Query;
using MessageFirebase.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MessageFirebase;

public partial class MessagePage : ContentPage
{
    private FirebaseClient firebaseClient;

    public MessagePage()
	{
		InitializeComponent();
        firebaseClient = new FirebaseClient("https://chatmessage-a4377-default-rtdb.firebaseio.com/");

        //var result = firebaseClient.Child("Message").OnceAsync<Dictionary<string, MesageObject>>().Result;

        //List<MesageObject> messages = new List<MesageObject>();

        //foreach (var item in result)
        //{
        //    var message = JsonConvert.DeserializeObject<MesageObject>(item.Object.ToString());
        //    messages.Add(message);
        //}

        //ListMessge.ItemsSource = (List<MesageObject>)result;

    }
}