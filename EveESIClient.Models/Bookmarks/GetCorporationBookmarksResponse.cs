using System;

namespace EveESIClient.Models.Bookmarks
{
    public class GetCorporationBookmarksResponse
    {
        public Int64 Bookmark_id { get; set; }
        public Int64? Folder_id { get; set; }
        public DateTime Created { get; set; }
        public string Label { get; set; }
        public string Notes { get; set; }
        public Int64 Location_id { get; set; }
        public Int64 Creator_id { get; set; }
        public BookmarkItem Item { get; set; }
        public BookmarkCoordinate Coordinates { get; set; }

        public class BookmarkItem
        {
            public Int64 Item_id { get; set; }
            public Int64 Type_id { get; set; }
        }

        public class BookmarkCoordinate
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }
        }
    }
}