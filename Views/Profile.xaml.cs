using MakeupStore.DataBase;
using MakeupStore.ViewModels;
namespace MakeupStore.Views;

public partial class Profile : ContentPage
{
	public Profile()
	{
		InitializeComponent();
		
	}

    

    static LoginDatabase database;	

	public static LoginDatabase Database
	{
		get
		{
			if (database == null)
			{
				database = new LoginDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SQLLiteSample.db"));
            }
			return database;
		}
	}
}