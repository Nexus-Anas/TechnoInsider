using System.Collections.ObjectModel;
using TechnoInsider.Entities;

namespace TechnoInsider;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Speaker> Speakers { get; set; }
    public ObservableCollection<Speaker> Speakers2 { get; set; }
    
    
    public MainPage()
    {
        InitializeComponent();
        InitializeSpeakers();
        BindingContext = this;
    }



    private void InitializeSpeakers()
    {
        Speakers = new ObservableCollection<Speaker>
        {
            new Speaker { Name = "Elon Musk", EventName = "NBC Universal", Image = "elonmusk.jpg"},
            new Speaker { Name = "Bill Gates", EventName = "TED2010", Image = "billgates.jpg"},
            new Speaker { Name = "Mark Zuckerberg", EventName = "GDC", Image = "markzuck.jpg"}
        };

        Speakers2 = new ObservableCollection<Speaker>
        {
            new Speaker { Name = "To the future", EventName = "TED Talks", Image = "ted.png"},
            new Speaker { Name = "Jeff Bezos", EventName = "Amazon Day", Image = "jeffbezoz.jpg"}
        };
    }
}
