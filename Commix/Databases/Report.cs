namespace Commix.Databases
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Report")]
    public partial class Report
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public DateTime? data_download { get; set; }

        public DateTime? data_ultimo_salvataggio { get; set; }

        public DateTime? data_upload { get; set; }

        [StringLength(50)]
        public string stato { get; set; }

        public byte[] contenuto { get; set; }
    }
}
