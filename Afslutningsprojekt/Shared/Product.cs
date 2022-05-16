/*Item model, that is a reusable model that represents items in the webstore*/

using System.ComponentModel.DataAnnotations.Schema;

namespace Afslutningsprojekt.Shared
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        /*defining the digits for the migration*/
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        /*defining the digits for the migration*/
        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }


        static public int NumOfItem { get; set; }

        public string? Description { get; set; }

    /*    public Creator? Creator { get; set; }*/

        public string Image { get; set; } = string.Empty;

        /* used to hide the Item, if it is only drafted */
        public bool IsPublic { get; set; }

        public bool IsDeleted { get; set; }

     /*   public Category Category { get; set; }*/

        public int CategoryId { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public DateTime DateUpdated { get; set; }
    }
}
