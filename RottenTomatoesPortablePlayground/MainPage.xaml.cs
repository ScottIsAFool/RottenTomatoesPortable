using Microsoft.Phone.Controls;
using RottenTomatoesPortable;

namespace RottenTomatoesPortablePlayground
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Loaded += async (sender, args) =>
            {
                var client = new RottenTomatoClient("gmjcqafm3h943e89nmekr5ty");

                var movies = await client.GetCurrentBoxOfficeAsync();

                var s = "";
            };
        }
    }
}