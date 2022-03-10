using Dio.Series.Enums;

namespace Dio.Series.Class
{
    public class Serie : BaseEntity
    {
        #region "Properties"
        private Genus Genus { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Exclude { get; set; }
        #endregion

        #region "Methods"
        public Serie(int id, Genus genus, string title, string description, int year)
        {
            this.Id = id;
            this.Genus = genus;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Exclude = false;
        }
        public override string ToString()
        {
            string @return = string.Empty;
            @return += $"Gender: {this.Genus} {Environment.NewLine}";
            @return += $"Title: {this.Title} {Environment.NewLine}";
            @return += $"Description: {this.Description} {Environment.NewLine}";
            @return += $"Release Year: {this.Year} {Environment.NewLine}";
            @return += $"Exclude: {this.Exclude} {Environment.NewLine}";
            return @return;
        }
        public string GetTitle()
        {
            return this.Title;
        }
        public int GetId()
        {
            return this.Id;
        }
        public bool GetExclude()
        {
            return this.Exclude;
        }
        public bool DeleteById()
        {
            return this.Exclude = true;
        }
        #endregion
    }
}
