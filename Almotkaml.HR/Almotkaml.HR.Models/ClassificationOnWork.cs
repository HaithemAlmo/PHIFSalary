using Almotkaml.Resources;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Almotkaml.HR.Resources;

namespace Almotkaml.HR.Models
{
    public class ClassificationOnWorkModel
    {
        public IEnumerable<ClassificationOnWorkGridRow> Grid { get; set; } = new HashSet<ClassificationOnWorkGridRow>();
        public bool CanCreate { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public int ClassificationOnWorkId { get; set; }
        [Required(ErrorMessageResourceType = typeof(SharedMessages),
         ErrorMessageResourceName = nameof(SharedMessages.IsRequired))]
        [Display(ResourceType = typeof(Title),
         Name = nameof(Title.Name))]
        public string Name { get; set; }
    }
    public class ClassificationOnWorkGridRow
    {
        public int ClassificationOnWorkId { get; set; }
        public string Name { get; set; }
    }
    public class ClassificationOnWorkListItem
    {
        public int ClassificationOnWorkId { get; set; }
        public string Name { get; set; }
    }



}