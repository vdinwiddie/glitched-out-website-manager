using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace glitched_out_website_manager.ViewModels
{
    public class ShowDetails
    {
        public DateTime ShowDate { get; set; }
        public string Venue { get; set; }
        public string Location { get; set; }
        public string TicketLink { get; set; } = "";
    }

    public class ShowsViewModel
    {
        // TEMPORARY
        public ObservableCollection<ShowDetails> Shows { get; } =
            new ObservableCollection<ShowDetails>
            {
                new ShowDetails
                {
                    ShowDate = new DateTime(2026, 10, 17),
                    Venue = "Kombucha Club",
                    Location = "Chicago, IL",
                },

                new ShowDetails
                {
                    ShowDate = new DateTime(2026, 11, 12),
                    Venue = "Burlington Bar",
                    Location = "Chicago, IL",
                },

                new ShowDetails
                {
                    ShowDate = new DateTime(2027, 1, 10),
                    Venue = "Liars Club",
                    Location = "Chicago, IL",
                }
            };

    }
}
